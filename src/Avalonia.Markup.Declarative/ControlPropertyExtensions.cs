using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Markup.Declarative.Helpers;
using Avalonia.Media;
using Avalonia.Styling;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Interactivity;

namespace Avalonia.Markup.Declarative;

public static class ControlPropertyExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TAvObject _set<TAvObject>(this TAvObject control, Action setAction)
    {
        setAction();
        return control;
    }

    /// <param name="control"></param>
    /// <typeparam name="TAvObject"></typeparam>
    extension<TAvObject>(TAvObject control) where TAvObject : AvaloniaObject
    {
        /// <summary>
        /// Used to bind one avalonia property to another
        /// </summary>
        /// <param name="avaloniaProperty"></param>
        /// <param name="propertyToBindTo"></param>
        /// <param name="bindingMode"></param>
        /// <param name="converter"></param>
        /// <param name="overrideView"></param>
        /// <returns></returns>
        public TAvObject _set(AvaloniaProperty avaloniaProperty,
            AvaloniaProperty propertyToBindTo, BindingMode? bindingMode, IValueConverter? converter, ViewBase? overrideView)
        {
            var view = overrideView ?? ViewBuildContext.CurrentView;
            var binding = new Binding()
            {
                Source = view,
                Path = propertyToBindTo.Name,
                Mode = bindingMode ?? BindingMode.Default,
                Converter = converter
            };

            control[!avaloniaProperty] = binding;
            return control;
        }

        /// <summary>
        /// Used to pass Binding object constructed by end-user
        /// </summary>
        /// <param name="avaloniaProperty"></param>
        /// <param name="binding"></param>
        /// <returns></returns>
        public TAvObject _set(AvaloniaProperty avaloniaProperty, IBinding binding)
        {
            control[!avaloniaProperty] = binding;
            return control;
        }

        /// <summary>
        /// Creates *Avalonia property* binding based on expression argument
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="avaloniaProperty"></param>
        /// <param name="getterFunc"></param>
        /// <param name="setChangedHandler"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public TAvObject _set<TValue>(AvaloniaProperty<TValue> avaloniaProperty, Func<TValue> getterFunc, Action<TValue>? setChangedHandler, string? expression)
        {
            var view = ViewBuildContext.CurrentView;

            if (view == null)
                throw new InvalidOperationException("Current view is not set! If you are using expression binding inside of FuncTemplate, wrap it's content into FuncView or FuncComponent, to make bindings work.");

            var handler = setChangedHandler;

            //override handler for MVU components so changing of such properties will trigger StateHasChanged method
            if (view is ComponentBase componentBase && setChangedHandler != null)
            {
                handler = v =>
                {
                    // Update this component's state first
                    componentBase.UpdateState(() => setChangedHandler(v), bubbleToParent: true);

                    // Also notify listeners (e.g., parent components) that track this property by expression
                    if (!string.IsNullOrEmpty(expression))
                    {
                        try
                        {
                            componentBase.NotifyExternalPropertyChanged(expression!, v);
                        }
                        catch
                        {
                            // Swallow diagnostics-only issues
                        }
                    }
                };
            }

            var state = new ViewPropertyComputedState<TAvObject, TValue>(expression, getterFunc, handler, control, avaloniaProperty);

            view.AddComputedState(state, control);
            return control;
        }

        /// <summary>
        /// Creates *Common property* binding based on expression argument
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="setter">Property setter action</param>
        /// <param name="getterFunc">Property getterFunc function</param>
        /// <param name="setChangedHandler"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public TAvObject _set<TValue>(Action<TValue> setter, Func<TValue> getterFunc, Action<TValue>? setChangedHandler, string? expression)
        {
            var view = ViewBuildContext.CurrentView;

            if (view == null)
                throw new InvalidOperationException("Current view is not set. Control must be put into view (inherited from ViewBase of ComponentBase) that can store binding information.");

            var handler = setChangedHandler;

            if (view is ComponentBase componentBase && setChangedHandler != null)
            {
                // Extract property name for tracking (if possible)
                string propertyName = expression ?? "unknown";

                if (control is ComponentBase childComponent)
                {
                    // Register callback on PARENT to handle child changes by expression key
                    componentBase.RegisterPropertyCallback(propertyName, value =>
                    {
                        try
                        {
                            if (value is TValue typedValue)
                                setChangedHandler(typedValue);
                            else if (value is null)
                                setChangedHandler(default!);
                            else
                                setChangedHandler((TValue)Convert.ChangeType(value, typeof(TValue))!);
                        }
                        catch
                        {
                            // ignore conversion issues
                        }
                    });

                    // When child local setter fires via binding, bubble to parent listeners
                    handler = v =>
                    {
                        setChangedHandler(v);
                        componentBase.NotifyExternalPropertyChanged(propertyName, v);
                    };
                }
                else
                {
                    handler = v => componentBase.UpdateState(() => setChangedHandler(v), bubbleToParent: true);
                }
            }

            var state = new ViewPropertyComputedState<TAvObject, TValue>(expression, setter, getterFunc, handler, control);
            view.AddComputedState(state, control);
            return control;
        }

        /// <summary>
        /// Creates binding to property on DataContext of the control parsed from Value's expression arg , used by generated extensions
        /// </summary>
        /// <param name="destProperty"></param>
        /// <param name="sourcePropertyPathString"></param>
        /// <param name="setAction"></param>
        /// <param name="bindingMode"></param>
        /// <param name="converter"></param>
        /// <param name="bindingSource"></param>
        /// <returns></returns>
        public TAvObject _setEx(AvaloniaProperty destProperty,
            string? sourcePropertyPathString, Action setAction,
            BindingMode? bindingMode, IValueConverter? converter, object? bindingSource)
        {
            if (sourcePropertyPathString == null
                || bindingMode.HasValue
                || bindingSource != default
                || sourcePropertyPathString.StartsWith("@"))
            {
                var binding = new Binding
                {
                    Path = PropertyPathHelper.GetNameFromPropertyPath(sourcePropertyPathString),
                    Mode = bindingMode ?? BindingMode.Default,
                    Converter = converter
                };

                // This is needed as setting a null Source breaks the Binding
                if (bindingSource != null)
                {
                    binding.Source = bindingSource;
                }
                else
                {
                    //for components the default binding context is the component itself instead of the control's data context
                    // except cases, where the binding source is defined directly
                    var view = ViewBuildContext.CurrentView;
                    if (view is IMvuComponent component)
                    {
                        binding.Source ??= component;
                    }
                }


                setAction();
                control.Bind(destProperty, binding);
            }
            else
            {
                setAction();
            }

            return control;
        }

        public TAvObject _set<TValue>(AvaloniaProperty<TValue> avaloniaProperty, 
            Func<ValueTask<TValue>> getterFunc, 
            Func<TValue>? fallbackGetter = null,
            Action<TValue>? setChangedHandler = null, 
            string? expression = null)
        {
            var view = ViewBuildContext.CurrentView;

            if (view == null)
                throw new InvalidOperationException("Current view is not set! If you are using expression binding inside of FuncTemplate, wrap it's content into FuncView or FuncComponent, to make bindings work.");

            var handler = PrepareHandler(view, setChangedHandler, expression);

            var state = new ViewPropertyAsyncComputedState<TAvObject, TValue>(
                expression, getterFunc, fallbackGetter, handler, control, avaloniaProperty);

            view.AddComputedState(state, control);
            return control;
        }
    }


    private static Action<TValue>? PrepareHandler<TValue>(ViewBase view, Action<TValue>? handler, string? expression)
    {
        if (view is ComponentBase cb && handler != null)
        {
            return v =>
            {
                cb.UpdateState(() => handler(v), bubbleToParent: true);
                if (!string.IsNullOrEmpty(expression)) cb.NotifyExternalPropertyChanged(expression, v);
            };
        }
        return handler;
    }

    /// <param name="control"></param>
    /// <typeparam name="TAvObject"></typeparam>
    extension<TAvObject>(TAvObject control) where TAvObject : AvaloniaObject
    {
        /// <summary>
        /// Binds an Avalonia Property to a getter and setter function.
        /// </summary>
        public TAvObject Bind<TValue>(AvaloniaProperty<TValue> property,
            Func<TValue> getter,
            Action<TValue>? setter = null)
        {
            return control._set(property, getter, setter, null);
        }

        /// <summary>
        /// Binds an Avalonia Property to another Avalonia Property from another object.
        /// </summary>
        /// <param name="property">Destination property to bind to.</param>
        /// <param name="otherProperty">Source property to bind from.</param>
        /// <param name="otherObject">Source object to bind from.</param>
        /// <param name="mode">Binding mode, i.e. source to destination or bidirectional</param>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public TAvObject Bind<TValue>(AvaloniaProperty<TValue> property,
            AvaloniaProperty<TValue> otherProperty,
            object otherObject,
            BindingMode mode = BindingMode.Default)
        {
            control.Bind(property, new Binding
            {
                Path = otherProperty.Name,
                Source = otherObject,
                Mode = mode
            });

            return control;
        }

        /// <summary>
        /// Binds an Avalonia Property to a Value Task getter, allowing for async bindings.
        /// <param name="fallbackGetter">What to set the Property to whiles the async operation is still going.</param>
        /// </summary>
        public TAvObject Bind<TValue>(AvaloniaProperty<TValue> property,
            Func<ValueTask<TValue>> getter,
            Func<TValue>? fallbackGetter = null)
        {
            return control._set(property, getter, fallbackGetter);
        }
    }

    public static TElement DataContext<TElement, TDataContext>(
        this TElement control,
        TDataContext value,
        out TDataContext dataContext,
        BindingMode? bindingMode = null,
        IValueConverter? converter = null,
        [CallerArgumentExpression(nameof(value))] string? ps = null)
        where TElement : StyledElement where TDataContext : class
    {
        dataContext = value;
        return control._setEx(StyledElement.DataContextProperty, ps, () => control.DataContext = value, bindingMode,
            converter, null);
    }

    public static Brush ToBrush(this Color color) => new SolidColorBrush(color);

    /// <param name="control">Control for positioning</param>
    /// <typeparam name="TElement"></typeparam>
    extension<TElement>(TElement control) where TElement : Control
    {
        public TElement Dock(Dock dock)
        {
            DockPanel.SetDock(control, dock);
            return control;
        }

        /// <summary>
        /// It's a shortcut for Grid_Column (in xaml: Grid.Column) extension 
        /// </summary>
        /// <param name="value">Grid.Column value</param>
        /// <returns></returns>
        public TElement Col(int value)
        {
            Grid.SetColumn(control, value);
            return control;
        }

        /// <summary>
        /// It's a shortcut for Grid_Row (in xaml: Grid.Row) extension 
        /// </summary>
        /// <param name="value">Grid.Row value</param>
        /// <returns></returns>
        public TElement Row(int value)
        {
            Grid.SetRow(control, value);
            return control;
        }
    }

    /// <param name="control">Grid control</param>
    /// <typeparam name="TElement">Grid</typeparam>
    extension<TElement>(TElement control) where TElement : Grid
    {
        /// <summary>
        /// It's a shortcut for Grid_ColumnDefinitions (in xaml: Grid.ColumnDefinitions) extension 
        /// </summary>
        /// <param name="value">Grid.ColumnDefinitions value</param>
        /// <returns></returns>
        public TElement Cols(ColumnDefinitions value)
        {
            control.ColumnDefinitions = value;
            return control;
        }

        /// <summary>
        /// It's a shortcut for Grid_RowDefinitions (in xaml: Grid.RowDefinitions) extension 
        /// </summary>
        /// <param name="value">Grid.RowDefinitions value</param>
        /// <returns></returns>
        public TElement Rows(RowDefinitions value)
        {
            control.RowDefinitions = value;
            return control;
        }

        /// <summary>
        /// It's a shortcut for Grid_ColumnDefinitions (in xaml: Grid.ColumnDefinitions) extension 
        /// </summary>
        /// <param name="value">String representing ColumnDefinitions i.e. "0,*,30,Auto" </param>
        /// <returns></returns>
        public TElement Cols(string value)
        {
            control.ColumnDefinitions = ColumnDefinitions.Parse(value);
            return control;
        }

        /// <summary>
        /// It's a shortcut for Grid_RowDefinitions (in xaml: Grid.RowDefinitions) extension 
        /// </summary>
        /// <param name="value">String representing RowDefinitions i.e. "0,*,30,Auto" </param>
        /// <returns></returns>
        public TElement Rows(string value)
        {
            control.RowDefinitions = RowDefinitions.Parse(value);
            return control;
        }
    }

    /// <param name="control">Control for positioning</param>
    /// <typeparam name="TElement">Control Type</typeparam>
    extension<TElement>(TElement control) where TElement : Control
    {
        /// <summary>
        /// It's a shortcut for Grid_ColumnSpan (in xaml: Grid.ColumnSpan) extension 
        /// </summary>
        /// <param name="value">Grid.ColumnSpan value</param>
        /// <returns></returns>
        public TElement ColSpan(int value)
        {
            Grid.SetColumnSpan(control, value);
            return control;
        }

        /// <summary>
        /// It's a shortcut for Grid_RowSpan (in xaml: Grid.RowSpan) extension 
        /// </summary>
        /// <param name="value">Grid.RowSpan value</param>
        /// <returns></returns>
        public TElement RowSpan(int value)
        {
            Grid.SetRowSpan(control, value);
            return control;
        }
    }

    public static TPanel Children<TPanel>(this TPanel container, params Control[] children)
        where TPanel : Panel
    {
        foreach (var child in children)
            container.Children.Add(child);
        return container;
    }

    public static TItemsControl Items<TItemsControl>(this TItemsControl container, params AvaloniaObject[] items)
        where TItemsControl : ItemsControl
    {
        if (container.Items is IList itemsCollection)
            foreach (var item in items)
                itemsCollection.Add(item);
        return container;
    }

    public static TabControl ItemTemplate<TItem>(this TabControl control, Func<TItem, Control> build) =>
        ItemTemplate<TItem, TabControl>(control, build);

    public static SelectingItemsControl ItemTemplate<TItem>(this SelectingItemsControl control,
        Func<TItem, Control> build) =>
        ItemTemplate<TItem, SelectingItemsControl>(control, build);

    //public static ItemsControl ItemTemplate<TItem>(this ItemsControl control, Func<TItem, Control> build) =>
    //	ItemTemplate<TItem, ItemsControl>(control, build);

    public static TItemsControl ItemTemplate<TItem, TItemsControl>(this TItemsControl control,
        Func<TItem, Control> build)
        where TItemsControl : ItemsControl
    {
        control.ItemTemplate = control.ItemTemplate = new FuncDataTemplate<TItem>((val, _) => build(val));
        return control;
    }

    public static MenuFlyout ItemTemplate<TItem>(this MenuFlyout control, Func<TItem, Control> build)
    {
        control.ItemTemplate = new FuncDataTemplate<TItem>((val, _) => build(val));
        return control;
    }
    public static MenuItem ItemTemplate<TItem>(this MenuItem control, Func<TItem, Control> build)
    {
        control.ItemTemplate = new FuncDataTemplate<TItem>((val, _) => build(val));
        return control;
    }
    public static Menu ItemTemplate<TItem>(this Menu control, Func<TItem, Control> build)
    {
        control.ItemTemplate = new FuncDataTemplate<TItem>((val, _) => build(val));
        return control;
    }

    public static TItemsControl ItemsPanel<TItemsControl>(this TItemsControl control, Panel panel)
        where TItemsControl : ItemsControl
    {
        control.ItemsPanel = new PanelTemplate(panel);
        return control;
    }

    record PanelTemplate(Panel panel) : ITemplate<Panel?>
    {
        public Panel Build() => panel;
        object ITemplate.Build() => throw new NotImplementedException();
    }

    public static TElement With<TElement>(this TElement control, Action<TElement> process)
    {
        process?.Invoke(control);
        return control;
    }

    extension<TElement>(TElement control) where TElement : Control
    {
        public TElement Name(string name, INameScope ns)
        {
            ns?.Register(name, control);
            control.Name = name;
            return control;
        }

        public TElement Styles(params Style[] styles)
        {
            foreach (var style in styles)
                control.Styles.Add(style);

            return control;
        }

        public TElement Styles(IEnumerable<Style> styles)
        {
            foreach (var style in styles)
                control.Styles.Add(style);

            return control;
        }

        public TElement Classes(string className, [CallerLineNumber] int line = 0,
            [CallerMemberName] string? caller = null)
        {
            control.Classes.Add(className);
            return control;
        }

        public TElement BindClass(Func<bool> func, string className,
            [CallerArgumentExpression(nameof(func))] string? ps = null)
        {

            var view = ViewBuildContext.CurrentView;

            if (view == null)
                throw new InvalidOperationException("Current view is not set");

            var state = new ViewPropertyComputedState<bool>(ps, func);

            view.AddComputedState(state, control);

            var binding = state.ToBinding();

            control.BindClass(className, binding, null!);

            return control;
        }

        public TElement BindClass(bool value, string className,
            object? bindingSource = null, [CallerLineNumber] int line = 0, [CallerMemberName] string? caller = null,
            [CallerArgumentExpression(nameof(value))] string? ps = null)
        {
            var path = PropertyPathHelper.GetNameFromPropertyPath(ps);
            var binding = new Binding(path, BindingMode.OneWay);

            if (bindingSource != null)
                binding.Source = bindingSource;

            control.BindClass(className, binding, null!);
            return control;
        }
    }

    public static StackTrace GetDeeperStackTrace(int depth) =>
        depth > 0 ? GetDeeperStackTrace(depth - 1) : new StackTrace(0, true);


    extension<TElement>(TElement control) where TElement : Control
    {
        public TElement DataTemplates(params IDataTemplate[] dataTemplate)
        {
            foreach (var template in dataTemplate)
                control.DataTemplates.Add(template);
            return control;
        }

        public TElement SetProp<TValue>(Avalonia.AvaloniaProperty property,
            TValue value)
        {
            if (value is IBinding binding)
            {
                control[!property] = binding;
            }
            else
            {
                control[property] = value;
            }

            return control;
        }

        public TElement ToolTip<TValue>(TValue value)
        {
            var prop = Avalonia.Controls.ToolTip.TipProperty;
            if (value is IBinding binding)
            {
                control[!prop] = binding;
            }
            else
            {
                control[prop] = value;
            }

            return control;
        }
    }

    /// <summary>
    /// Adds flyout to button and activates it on button click
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
    /// <param name="control">target button</param>
    /// <param name="flyout">flyout to activate</param>
    /// <returns></returns>
    public static TElement AddFlyoutOnClick<TElement>(this TElement control, FlyoutBase flyout)
        where TElement : Button
    {
        control.Click += (_, _) => flyout.ShowAt(control);
        return control;
    }

    /// <summary>
    /// Adds a menu item to the specified menu flyout.
    /// </summary>
    /// <typeparam name="TElement">The type of the menu flyout element.</typeparam>
    /// <param name="menuFlyout">The menu flyout to which the item will be added.</param>
    /// <param name="menuItem">The menu item to be added to the flyout.</param>
    /// <returns>The menu flyout with the added item.</returns>
    public static TElement AddItem<TElement>(this TElement menuFlyout, MenuItem menuItem)
        where TElement : MenuFlyout
    {
        menuFlyout.Items.Add(menuItem);
        return menuFlyout;
    }

    /// <summary>
    /// Adds item to MenuFlyout
    /// </summary>
    /// <typeparam name="TElement">MenuFlyout type</typeparam>
    /// <param name="menuFlyout">Target MenuFlyout control</param>
    /// <param name="text">Item text</param>
    /// <param name="command">Item command</param>
    /// <param name="commandParameter">Command parameter</param>
    /// <returns></returns>
    public static TElement AddItem<TElement>(this TElement menuFlyout, string text, ICommand command,
        object? commandParameter = null)
        where TElement : MenuFlyout
    {
        var item = new MenuItem() { Header = text, Command = command };
        if (commandParameter != null)
            item.CommandParameter = commandParameter;

        menuFlyout.Items.Add(item);
        return menuFlyout;
    }

    /// <summary>
    /// Sets control instance reference to field so it can be accessed later in Markup
    /// </summary>
    /// <typeparam name="TElement">Control Type</typeparam>
    /// <param name="control">Control instance</param>
    /// <param name="field">field that will accept reference to control</param>
    /// <returns></returns>
    public static TElement Ref<TElement>(this TElement control, out TElement field)
    {
        field = control;
        return control;
    }
    
    extension<T>(T interactive) where T : Interactive
    {
        /// <summary>
        /// Binds a delegate to an Avalonia Routed Event.
        /// Useful for when Declarative Bindings don't already exist for a particular control.
        /// </summary>
        public T Handle<TEvent>(RoutedEvent<TEvent> routedEvent,
            Action<TEvent> action,
            RoutingStrategies? routes = null) where TEvent : RoutedEventArgs
        {
            interactive.AddHandler(routedEvent, (EventHandler<TEvent>) ((_, args) => action(args)), routes ??  routedEvent.RoutingStrategies);
            return interactive;
        }
    }
}
