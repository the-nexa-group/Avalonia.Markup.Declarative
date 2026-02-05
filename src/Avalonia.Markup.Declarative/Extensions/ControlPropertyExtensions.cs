using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Markup.Declarative.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;

public static class ControlPropertyExtensions
{
    /// <param name="control"></param>
    /// <typeparam name="TAvObject"></typeparam>
    extension<TAvObject>(TAvObject control) where TAvObject : AvaloniaObject
    {
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
        public TAvObject _setEx(
            AvaloniaProperty destProperty,
            string? sourcePropertyPathString, 
            Action setAction,
            BindingMode? bindingMode,
            IValueConverter? converter, 
            object? bindingSource)
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
    }

    public static TElement DataContext<TElement, TDataContext>(
        this TElement control,
        TDataContext value,
        out TDataContext dataContext,
        BindingMode? bindingMode = null,
        IValueConverter? converter = null,
        [CallerArgumentExpression(nameof(value))] string? ps = null)
        where TElement : StyledElement 
        where TDataContext : class
    {
        dataContext = value;
        return control._setEx(StyledElement.DataContextProperty, ps, () => control.DataContext = value, bindingMode,
            converter, null);
    }

    extension<TElement>(TElement control) where TElement : Control
    {
        public TElement DataTemplates(params IDataTemplate[] dataTemplates)
        {
            control.DataTemplates.AddRange(dataTemplates);
            return control;
        }
        
        public TElement DataTemplates(IEnumerable<IDataTemplate> dataTemplates)
        {
            control.DataTemplates.AddRange(dataTemplates);
            return control;
        }

        public TElement SetProp<TValue>(
            AvaloniaProperty property,
            TValue value)
        {
            if (value is IBinding binding)
                control[!property] = binding;
            else
                control[property] = value;

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
}
