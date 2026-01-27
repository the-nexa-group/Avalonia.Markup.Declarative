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
public static partial class Animation_MarkupExtensions
{
//================= Properties ======================//
 // Duration

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, System.TimeSpan value)  
=> control._set(() => control.Duration = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.DurationProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, Func<ValueTask<System.TimeSpan>> getter, Func<System.TimeSpan>? fallbackGetter = null, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.DurationProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, IBinding binding)  
   => control._set(Avalonia.Animation.Animation.DurationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Animation.Animation.DurationProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IterationCount

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, Avalonia.Animation.IterationCount value)  
=> control._set(() => control.IterationCount = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, Func<Avalonia.Animation.IterationCount> func, Action<Avalonia.Animation.IterationCount>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.IterationCountProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, Func<ValueTask<Avalonia.Animation.IterationCount>> getter, Func<Avalonia.Animation.IterationCount>? fallbackGetter = null, Action<Avalonia.Animation.IterationCount>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.IterationCountProperty!, getter, fallbackGetter, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, System.UInt64 value = default!)  
   => control._set(() => control.IterationCount = new Avalonia.Animation.IterationCount(value));
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, System.UInt64 value = default!, Avalonia.Animation.IterationType type = default!)  
   => control._set(() => control.IterationCount = new Avalonia.Animation.IterationCount(value, type));

/*BindSetterGenerator*/
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, IBinding binding)  
   => control._set(Avalonia.Animation.Animation.IterationCountProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Animation.Animation.IterationCountProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlaybackDirection

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, Avalonia.Animation.PlaybackDirection value)  
=> control._set(() => control.PlaybackDirection = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, Func<Avalonia.Animation.PlaybackDirection> func, Action<Avalonia.Animation.PlaybackDirection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.PlaybackDirectionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, Func<ValueTask<Avalonia.Animation.PlaybackDirection>> getter, Func<Avalonia.Animation.PlaybackDirection>? fallbackGetter = null, Action<Avalonia.Animation.PlaybackDirection>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.PlaybackDirectionProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, IBinding binding)  
   => control._set(Avalonia.Animation.Animation.PlaybackDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Animation.Animation.PlaybackDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // FillMode

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, Avalonia.Animation.FillMode value)  
=> control._set(() => control.FillMode = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, Func<Avalonia.Animation.FillMode> func, Action<Avalonia.Animation.FillMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.FillModeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, Func<ValueTask<Avalonia.Animation.FillMode>> getter, Func<Avalonia.Animation.FillMode>? fallbackGetter = null, Action<Avalonia.Animation.FillMode>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.FillModeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, IBinding binding)  
   => control._set(Avalonia.Animation.Animation.FillModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Animation.Animation.FillModeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Easing

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, Avalonia.Animation.Easings.Easing value)  
=> control._set(() => control.Easing = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, Func<Avalonia.Animation.Easings.Easing> func, Action<Avalonia.Animation.Easings.Easing>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.EasingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, Func<ValueTask<Avalonia.Animation.Easings.Easing>> getter, Func<Avalonia.Animation.Easings.Easing>? fallbackGetter = null, Action<Avalonia.Animation.Easings.Easing>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.EasingProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, IBinding binding)  
   => control._set(Avalonia.Animation.Animation.EasingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Animation.Animation.EasingProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Delay

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, System.TimeSpan value)  
=> control._set(() => control.Delay = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.DelayProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, Func<ValueTask<System.TimeSpan>> getter, Func<System.TimeSpan>? fallbackGetter = null, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.DelayProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, IBinding binding)  
   => control._set(Avalonia.Animation.Animation.DelayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Animation.Animation.DelayProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // DelayBetweenIterations

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, System.TimeSpan value)  
=> control._set(() => control.DelayBetweenIterations = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.DelayBetweenIterationsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, Func<ValueTask<System.TimeSpan>> getter, Func<System.TimeSpan>? fallbackGetter = null, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.DelayBetweenIterationsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, IBinding binding)  
   => control._set(Avalonia.Animation.Animation.DelayBetweenIterationsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Animation.Animation.DelayBetweenIterationsProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SpeedRatio

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, System.Double value)  
=> control._set(() => control.SpeedRatio = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.SpeedRatioProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Animation.Animation.SpeedRatioProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, IBinding binding)  
   => control._set(Avalonia.Animation.Animation.SpeedRatioProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Animation.Animation.SpeedRatioProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
