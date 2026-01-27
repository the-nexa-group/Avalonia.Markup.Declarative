#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class Expander_MarkupExtensions
{
//================= Properties ======================//
 // ContentTransition

/*ValueSetterGenerator*/
public static T ContentTransition<T>(this T control, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.Expander 
=> control._set(() => control.ContentTransition = value);

/*BindFromExpressionSetterGenerator*/
public static T ContentTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition?> func, Action<Avalonia.Animation.IPageTransition?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ContentTransitionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ContentTransition<T>(this T control, Func<ValueTask<Avalonia.Animation.IPageTransition?>> getter, Func<Avalonia.Animation.IPageTransition?>? fallbackGetter = null, Action<Avalonia.Animation.IPageTransition?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ContentTransitionProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ContentTransition<T>(this T control, IBinding binding) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ContentTransitionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContentTransition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ContentTransitionProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ExpandDirection

/*ValueSetterGenerator*/
public static T ExpandDirection<T>(this T control, Avalonia.Controls.ExpandDirection value) where T : Avalonia.Controls.Expander 
=> control._set(() => control.ExpandDirection = value);

/*BindFromExpressionSetterGenerator*/
public static T ExpandDirection<T>(this T control, Func<Avalonia.Controls.ExpandDirection> func, Action<Avalonia.Controls.ExpandDirection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ExpandDirectionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ExpandDirection<T>(this T control, Func<ValueTask<Avalonia.Controls.ExpandDirection>> getter, Func<Avalonia.Controls.ExpandDirection>? fallbackGetter = null, Action<Avalonia.Controls.ExpandDirection>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ExpandDirectionProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ExpandDirection<T>(this T control, IBinding binding) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ExpandDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ExpandDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ExpandDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsExpanded

/*ValueSetterGenerator*/
public static T IsExpanded<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Expander 
=> control._set(() => control.IsExpanded = value);

/*BindFromExpressionSetterGenerator*/
public static T IsExpanded<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.IsExpandedProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsExpanded<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.IsExpandedProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsExpanded<T>(this T control, IBinding binding) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.IsExpandedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsExpanded<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.IsExpandedProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // Collapsed

/*ActionToEventGenerator*/
public static T OnCollapsed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Expander 
{
  control.AddHandler(Avalonia.Controls.Expander.CollapsedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Expander.CollapsedEvent.RoutingStrategies);
  return control;
}



 // Collapsing

/*ActionToEventGenerator*/
public static T OnCollapsing<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Expander 
{
  control.AddHandler(Avalonia.Controls.Expander.CollapsingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Expander.CollapsingEvent.RoutingStrategies);
  return control;
}



 // Expanded

/*ActionToEventGenerator*/
public static T OnExpanded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Expander 
{
  control.AddHandler(Avalonia.Controls.Expander.ExpandedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Expander.ExpandedEvent.RoutingStrategies);
  return control;
}



 // Expanding

/*ActionToEventGenerator*/
public static T OnExpanding<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Expander 
{
  control.AddHandler(Avalonia.Controls.Expander.ExpandingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Expander.ExpandingEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // ContentTransition

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ContentTransitionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ContentTransitionProperty, binding);


 // ExpandDirection

/*ValueStyleSetterGenerator*/
public static Style<T> ExpandDirection<T>(this Style<T> style, Avalonia.Controls.ExpandDirection value) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ExpandDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExpandDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ExpandDirectionProperty, binding);


 // IsExpanded

/*ValueStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.IsExpandedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.IsExpandedProperty, binding);



}
