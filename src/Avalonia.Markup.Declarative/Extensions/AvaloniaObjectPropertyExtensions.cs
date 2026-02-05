using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Avalonia.Data;
using Avalonia.Data.Converters;

namespace Avalonia.Markup.Declarative;

public static class AvaloniaObjectPropertyExtensions
{
    /// <param name="control"></param>
    /// <typeparam name="TAvObject"></typeparam>
    extension<TAvObject>(TAvObject control) where TAvObject : AvaloniaObject
    {
        /// <summary>
        /// Used to pass Binding object constructed by end-user
        /// </summary>
        /// <param name="avaloniaProperty"></param>
        /// <param name="binding"></param>
        /// <returns></returns>
        [RequiresUnreferencedCode("Except for Direct Properties, the value used by the Avalonia Property may be trimmed")]
        public TAvObject BindR(
            AvaloniaProperty avaloniaProperty,
            IBinding binding)
        {
            control[!avaloniaProperty] = binding;
            return control;
        } 
        
        /// <summary>
        /// Used to bind one avalonia property to another
        /// </summary>
        /// <param name="avaloniaProperty"></param>
        /// <param name="propertyToBindTo"></param>
        /// <param name="bindingMode"></param>
        /// <param name="converter"></param>
        /// <param name="overrideView"></param>
        /// <returns></returns>
        [RequiresUnreferencedCode("Except for Direct Properties, the value used by the Avalonia Property may be trimmed")]
        public TAvObject Bind(
            AvaloniaProperty avaloniaProperty,
            AvaloniaProperty propertyToBindTo,
            BindingMode? bindingMode,
            IValueConverter? converter,
            ViewBase? overrideView)
        {
            ViewBase? view = overrideView ?? ViewBuildContext.CurrentView;
            Binding binding = new() 
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
        /// Creates *Avalonia property* binding based on expression argument
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="avaloniaProperty"></param>
        /// <param name="getterFunc"></param>
        /// <param name="setChangedHandler"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        [RequiresUnreferencedCode("Except for Direct Properties, the value used by the Avalonia Property may be trimmed")]
        public TAvObject Bind<TValue>(
            AvaloniaProperty<TValue> avaloniaProperty,
            Func<TValue> getterFunc, 
            Action<TValue>? setChangedHandler,
            string? expression)
        {
            ViewBase? view = ViewBuildContext.CurrentView;

            if (view == null)
                throw new InvalidOperationException("Current view is not set! If you are using expression binding inside of FuncTemplate, wrap it's content into FuncView or FuncComponent, to make bindings work.");

            Action<TValue>? handler = setChangedHandler;

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

            ViewPropertyComputedState<TAvObject, TValue> state = new(expression, getterFunc, handler, control, avaloniaProperty);
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
        public TAvObject Bind<TValue>(
            Action<TValue> setter, 
            Func<TValue> getterFunc,
            Action<TValue>? setChangedHandler,
            string? expression)
        {
            ViewBase? view = ViewBuildContext.CurrentView;

            if (view == null)
                throw new InvalidOperationException("Current view is not set. Control must be put into view (inherited from ViewBase of ComponentBase) that can store binding information.");

            Action<TValue>? handler = setChangedHandler;

            if (view is ComponentBase componentBase && setChangedHandler != null)
            {
                // Extract property name for tracking (if possible)
                string propertyName = expression ?? "unknown";

                if (control is ComponentBase)
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
                                setChangedHandler((TValue)Convert.ChangeType(value, typeof(TValue)));
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

            ViewPropertyComputedState<TAvObject, TValue> state = new(expression, setter, getterFunc, handler, control);
            view.AddComputedState(state, control);
            return control;
        }
        
        public TAvObject Bind<TValue>(AvaloniaProperty<TValue> avaloniaProperty, 
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
}