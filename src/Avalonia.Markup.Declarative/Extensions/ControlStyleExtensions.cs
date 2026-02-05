using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Declarative.Helpers;
using Avalonia.Styling;

namespace Avalonia.Markup.Declarative;

public static class ControlStyleExtensions
{
    extension<TElement>(TElement control) where TElement : Control
    {
        public TElement Name(string name, INameScope ns)
        {
            ns.Register(name, control);
            control.Name = name;
            return control;
        }

        public TElement Styles(params Style[] styles)
        {
            control.Styles.AddRange(styles);
            return control;
        }

        public TElement Styles(IEnumerable<IStyle> styles)
        {
            control.Styles.AddRange(styles);
            return control;
        }

        public TElement Classes(params string[] classNames)
        {
            control.Classes.AddRange(classNames);
            return control;
        } 
        
        public TElement Classes(IEnumerable<string> classNames)
        {
            control.Classes.AddRange(classNames);
            return control;
        }

        public TElement BindClass(
            Func<bool> func, 
            string className,
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

        public TElement BindClass(
            bool value,
            string className,
            object? bindingSource = null,
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
}