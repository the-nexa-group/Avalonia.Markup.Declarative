using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
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

public abstract class ComponentBase(
    ViewInitializationStrategy viewInitializationStrategy = ViewInitializationStrategy.Immediate)
    : ViewBase(viewInitializationStrategy), IMvuComponent
{
    public new event PropertyChangedEventHandler? PropertyChanged;
    
    private readonly HashSet<INotifyPropertyChanged> _trackedNotifyMembers = [];
    private readonly Dictionary<string, Action<object?>> _propertyUpdateCallbacks = new();
    private bool _isUpdatingState;
    
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
    
    public void UpdateState(Action? updateStateAction = null, bool bubbleToParent = false)
    {
        updateStateAction?.Invoke();
        StateHasChanged();

        //invalidate parent's state if bubbleToParent is true
        if (bubbleToParent && Parent is ComponentBase parentComponent)
            parentComponent.StateHasChanged();
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
    
    protected override void OnCreated()
    {
        InjectServices();
        SubscribeToNotifyPropertyChangedMembers();
        StateHasChanged();
    }
    
    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
        UnsubscribeToNotifyPropertyChangedMembers();
    }
    
    protected virtual void InjectServices() {}
    protected virtual void OnStateChanged() {}

    protected virtual void SubscribeToNotifyPropertyChangedMembers()
    {
        TrackPropertyChanged(DataTemplates);
        TrackPropertyChanged(Classes);
        TrackPropertyChanged(Styles);
        TrackPropertyChanged(VisualChildren);
    }
    
    protected virtual void UnsubscribeToNotifyPropertyChangedMembers()
    {
        UntrackPropertyChanged(DataTemplates);
        UntrackPropertyChanged(Classes);
        UntrackPropertyChanged(Styles);
        UntrackPropertyChanged(VisualChildren);
        
        // Clean-up any potentially lingering members.
        foreach (var trackedNotifyMember in _trackedNotifyMembers)
            UntrackPropertyChanged(trackedNotifyMember); 
    }

    protected void TrackPropertyChanged(INotifyPropertyChanged? notifier)
    {
        if (notifier is not null && _trackedNotifyMembers.Add(notifier))
            notifier.PropertyChanged += HandlePropertyHasChanged;
    }

    protected void UntrackPropertyChanged(INotifyPropertyChanged? notifier)
    {
        if (notifier is not null && _trackedNotifyMembers.Remove(notifier))
            notifier.PropertyChanged -= HandlePropertyHasChanged;
    }
    
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    protected void StateHasChanged()
    {
        if (Dispatcher.UIThread.CheckAccess())
        {
            PerformStateUpdate();
        }
        else
        {
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
            foreach (var dependentView in DependentViews)
            {
                if (dependentView is ComponentBase componentBase)
                    componentBase.UpdateState();
            }

            foreach (var computedState in ViewComputedStates)
                computedState.OnPropertyChanged();
        }
        finally
        {
            _isUpdatingState = false;
        }
        
        OnStateChanged();
    }
    
    private void HandlePropertyHasChanged(object? sender, PropertyChangedEventArgs e)
    {
        StateHasChanged();
    }
}
