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
public static partial class TransitioningContentControl_MarkupExtensions
{
//================= Properties ======================//
 // PageTransition

/*ValueSetterGenerator*/
public static T PageTransition<T>(this T control, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.TransitioningContentControl 
=> control._set(() => control.PageTransition = value);

/*BindFromExpressionSetterGenerator*/
public static T PageTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition?> func, Action<Avalonia.Animation.IPageTransition?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PageTransition<T>(this T control, Func<ValueTask<Avalonia.Animation.IPageTransition?>> getter, Func<Avalonia.Animation.IPageTransition?>? fallbackGetter = null, Action<Avalonia.Animation.IPageTransition?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PageTransition<T>(this T control, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PageTransition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsTransitionReversed

/*ValueSetterGenerator*/
public static T IsTransitionReversed<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TransitioningContentControl 
=> control._set(() => control.IsTransitionReversed = value);

/*BindFromExpressionSetterGenerator*/
public static T IsTransitionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsTransitionReversed<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsTransitionReversed<T>(this T control, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTransitionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // TransitionCompleted

/*ActionToEventGenerator*/
public static T OnTransitionCompleted<T>(this T control, Action<Avalonia.Controls.TransitionCompletedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TransitioningContentControl 
{
  control.AddHandler(Avalonia.Controls.TransitioningContentControl.TransitionCompletedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TransitioningContentControl.TransitionCompletedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // PageTransition

/*ValueStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, binding);


 // IsTransitionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsTransitionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTransitionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, binding);



}
