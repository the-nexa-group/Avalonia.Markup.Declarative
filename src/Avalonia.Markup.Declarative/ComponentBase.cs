using Avalonia.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Markup.Declarative.Helpers;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.NonPublicFields)]
public abstract class ComponentBase<TViewModel> : ComponentBase
{
    public virtual TViewModel? ViewModel
    {
        get => (TViewModel)DataContext!;
        set => DataContext = value;
    }

    // ComponentBase does not initialize immediately - derived classes or ComponentBase<TViewModel> will call Initialize()
    // This ensures that DataContext/ViewModel is set before Build() is called
    protected ComponentBase(TViewModel viewModel): base(ViewInitializationStrategy.Lazy)
    {
        DataContext = viewModel;
        // Initialize after DataContext is set, so Build(ViewModel) has a valid ViewModel
        Initialize();
    }

    protected abstract Control? Build(TViewModel? vm);

    protected override Control? Build() => Build(ViewModel);
}

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.NonPublicFields)]
public abstract class ComponentBase : ViewBase, IMvuComponent
{
    private ViewPropertyState[] _localPropertyStates = [];
    private List<ViewPropertyState> _externalPropertyStates = [];
    protected Dictionary<string, Action<object?>> _propertyUpdateCallbacks = new();

    private bool _isUpdatingState;

    protected ComponentBase() : this(ViewInitializationStrategy.Immediate)
    {
    }
   
    protected ComponentBase(ViewInitializationStrategy viewInitializationStrategy) : base(viewInitializationStrategy)
    {
    }

    protected override void OnCreated()
    {
        InjectServices();
        SubscribeToNotifyPropertyChangedMembers();
        InitStateMembers();
        StateHasChanged();
    }

    protected virtual void InjectServices() { }

    protected virtual void SubscribeToNotifyPropertyChangedMembers()
    {
        DataTemplates.PropertyChanged += HandlePropertyHasChanged; 
        Classes.PropertyChanged += HandlePropertyHasChanged;
        Styles.PropertyChanged += HandleAvPropertyHasChanged;
        VisualChildren.PropertyChanged += HandlePropertyHasChanged;
    }
    
    protected virtual void UnsubscribeToNotifyPropertyChangedMembers()
    {
        DataTemplates.PropertyChanged -= HandlePropertyHasChanged;
        Classes.PropertyChanged -= HandlePropertyHasChanged;
        Styles.PropertyChanged -= HandleAvPropertyHasChanged;
        VisualChildren.PropertyChanged -= HandlePropertyHasChanged;
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
        UnsubscribeToNotifyPropertyChangedMembers();
    }

    protected virtual void OnStateChanged() {}

    /// <summary>
    /// Creates a new instance of the control using the component factory. Injects services into the control if needed.
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static TControl New<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TControl>() where TControl : Control
    {
        if (AppBuilderExtensions.ComponentControlFactory == null)
            throw new InvalidOperationException("Please set Component Factory by calling UseComponentControlFactory on AppBuilder");

        var control = AppBuilderExtensions.ComponentControlFactory.CreateControlInstance<TControl>();
        return control;
    }

    [Obsolete]
    private void InitStateMembers()
    {
        var viewType = GetType();
        _localPropertyStates = viewType
            .GetProperties()
            .Where(p => p.DeclaringType == viewType)
            .Select(p => new ViewPropertyState(p, this))
            .ToArray();
    }
    
    public void UpdateState(Action? updateStateAction = null, bool bubbleToParent = false)
    {
        updateStateAction?.Invoke();
        StateHasChanged();

        //invalidate parent's state if bubbleToParent is true
        if (bubbleToParent && Parent is ComponentBase parentComponent)
            parentComponent.StateHasChanged();
    }

    protected void StateHasChanged()
    {
        if (Dispatcher.UIThread.CheckAccess())
        {
            // If on UI thread, proceed directly
            PerformStateUpdate();
        }
        else
        {
            // If not on UI thread, dispatch to UI thread
            Dispatcher.UIThread.Post(PerformStateUpdate, DispatcherPriority.Normal);
        }
    }

    private void PerformStateUpdate()
    {
        if (_isUpdatingState)
            return;
        _isUpdatingState = true;
        try
        {
            //obsolete
            foreach (var prop in _externalPropertyStates)
                if (prop.CheckStateChangedAndUpdate())
                    OnPropertyChanged(prop.Name);

            //obsolete
            foreach (var prop in _localPropertyStates)
                if (prop.CheckStateChangedAndUpdate())
                    OnPropertyChanged(prop.Name);

            foreach (var dependentView in DependentViews.OfType<ComponentBase>())
                dependentView.UpdateState();

            foreach (var computedState in ViewComputedStates)
                computedState.OnPropertyChanged();
        }
        finally
        {
            _isUpdatingState = false;
        }
        
        OnStateChanged();
    }
    
    void HandleAvPropertyHasChanged(object? sender, AvaloniaPropertyChangedEventArgs e)
    {
        StateHasChanged();
    }

    void HandlePropertyHasChanged(object? sender, PropertyChangedEventArgs e)
    {
        StateHasChanged();
    }

    [Obsolete("Should not used directly and will be removed in future")]
    public void AddExternalState<TControl, TValue>(TControl source, string propertyName, Action<TValue?> setAction)
        where TControl : ComponentBase
    {
        _externalPropertyStates ??= [];

        var propInfo = source.GetType().GetProperty(propertyName);

        if (propInfo == null)
            throw new NullReferenceException($"Property info {propertyName} is null");

        var propertyState = new ViewPropertyState<TValue>(propInfo, source, setAction);
        _externalPropertyStates.Add(propertyState);

        source.AddDependentView(this);
    }

    #region ObsoleteMvuBinding

    [Obsolete("This is old binding method relies on Reflection. Use lambda expressions instead.")]
    protected Binding Bind(object value, BindingMode bindingMode = BindingMode.Default, [CallerArgumentExpression(nameof(value))] string? valueExpressionString = null)
    {
        return CreateMvuBinding(value, bindingMode, valueExpressionString);
    }

    [Obsolete("This is old binding method relies on Reflection.")]
    private Binding CreateMvuBinding(object value, BindingMode? bindingMode, string? valueExpressionString)
    {
        object? bindingSource = this;
        var useStateValueAsSource = false;

        var propName = PropertyPathHelper.GetNameFromPropertyPath(valueExpressionString);
        var stateName = propName;

        var splitterIndex = valueExpressionString!.IndexOf('.');

        if (splitterIndex > -1)
        {
            var startIndex = valueExpressionString.StartsWith("@") ? 1 : 0;
            stateName = valueExpressionString.Substring(startIndex, splitterIndex - startIndex);

            useStateValueAsSource = true;
        }

        var stateInfo = FindStateForBindingString(stateName);
        if (stateInfo == null)
            throw new ArgumentException("No properties found in binding string. Make sure that your properties are public!");

        if (useStateValueAsSource)
            bindingSource = stateInfo.Value;

        return new MvuBinding()
        {
            Source = bindingSource,
            Path = propName,
            Mode = bindingMode ?? BindingMode.Default,
            Value = value
        };
    }

    [Obsolete("This is old binding method relies on Reflection.")]
    public class MvuBinding : Binding
    {
        public object? Value { get; set; }
    }

    [Obsolete("This is old binding method relies on Reflection.")]
    private ViewPropertyState? FindStateForBindingString(string stateName) =>
        _localPropertyStates?.FirstOrDefault(x => x.Name == stateName);

    #endregion

    public new event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void RegisterPropertyCallback(string propertyName, Action<object?> callback)
    {
        _propertyUpdateCallbacks[propertyName] = callback;
    }
    public void NotifyExternalPropertyChanged(string propertyName, object? newValue)
    {
        // Update our own value if we have a callback
        if (_propertyUpdateCallbacks.TryGetValue(propertyName, out var callback))
        {
            callback(newValue);
        }

        // Trigger state update on this component
        StateHasChanged();

        // Bubble up to parent if needed
        if (Parent is ComponentBase parent)
            parent.NotifyExternalPropertyChanged(propertyName, newValue);
    }


}
