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
public static partial class RepeatButton_MarkupExtensions
{
//================= Properties ======================//
 // Interval

/*ValueSetterGenerator*/
public static T Interval<T>(this T control, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
=> control._set(() => control.Interval = value);

/*BindFromExpressionSetterGenerator*/
public static T Interval<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.IntervalProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Interval<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.IntervalProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Interval<T>(this T control, IBinding binding) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.IntervalProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Interval<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.IntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Delay

/*ValueSetterGenerator*/
public static T Delay<T>(this T control, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
=> control._set(() => control.Delay = value);

/*BindFromExpressionSetterGenerator*/
public static T Delay<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.DelayProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Delay<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.DelayProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Delay<T>(this T control, IBinding binding) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.DelayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Delay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.DelayProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Interval

/*ValueStyleSetterGenerator*/
public static Style<T> Interval<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.IntervalProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Interval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.IntervalProperty, binding);


 // Delay

/*ValueStyleSetterGenerator*/
public static Style<T> Delay<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.DelayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Delay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.DelayProperty, binding);



}
