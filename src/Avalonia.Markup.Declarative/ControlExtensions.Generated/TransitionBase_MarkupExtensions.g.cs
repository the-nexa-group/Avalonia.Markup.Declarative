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
public static partial class TransitionBase_MarkupExtensions
{
//================= Properties ======================//
 // Duration

/*ValueSetterGenerator*/
public static T Duration<T>(this T control, System.TimeSpan value) where T : Avalonia.Animation.TransitionBase 
=> control._set(() => control.Duration = value);

/*BindFromExpressionSetterGenerator*/
public static T Duration<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DurationProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Duration<T>(this T control, Func<ValueTask<System.TimeSpan>> getter, Func<System.TimeSpan>? fallbackGetter = null, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DurationProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Duration<T>(this T control, IBinding binding) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DurationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Duration<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DurationProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Delay

/*ValueSetterGenerator*/
public static T Delay<T>(this T control, System.TimeSpan value) where T : Avalonia.Animation.TransitionBase 
=> control._set(() => control.Delay = value);

/*BindFromExpressionSetterGenerator*/
public static T Delay<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DelayProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Delay<T>(this T control, Func<ValueTask<System.TimeSpan>> getter, Func<System.TimeSpan>? fallbackGetter = null, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DelayProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Delay<T>(this T control, IBinding binding) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DelayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Delay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DelayProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Easing

/*ValueSetterGenerator*/
public static T Easing<T>(this T control, Avalonia.Animation.Easings.Easing value) where T : Avalonia.Animation.TransitionBase 
=> control._set(() => control.Easing = value);

/*BindFromExpressionSetterGenerator*/
public static T Easing<T>(this T control, Func<Avalonia.Animation.Easings.Easing> func, Action<Avalonia.Animation.Easings.Easing>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.EasingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Easing<T>(this T control, Func<ValueTask<Avalonia.Animation.Easings.Easing>> getter, Func<Avalonia.Animation.Easings.Easing>? fallbackGetter = null, Action<Avalonia.Animation.Easings.Easing>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.EasingProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Easing<T>(this T control, IBinding binding) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.EasingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Easing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.EasingProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
