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
public static partial class RangeBase_MarkupExtensions
{
//================= Properties ======================//
 // Minimum

/*ValueSetterGenerator*/
public static T Minimum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.Minimum = value);

/*BindFromExpressionSetterGenerator*/
public static T Minimum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MinimumProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Minimum<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MinimumProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Minimum<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Minimum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Maximum

/*ValueSetterGenerator*/
public static T Maximum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.Maximum = value);

/*BindFromExpressionSetterGenerator*/
public static T Maximum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MaximumProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Maximum<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MaximumProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Maximum<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Maximum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Value

/*ValueSetterGenerator*/
public static T Value<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.Value = value);

/*BindFromExpressionSetterGenerator*/
public static T Value<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.ValueProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Value<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.ValueProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Value<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.ValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Value<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SmallChange

/*ValueSetterGenerator*/
public static T SmallChange<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.SmallChange = value);

/*BindFromExpressionSetterGenerator*/
public static T SmallChange<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SmallChange<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SmallChange<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SmallChange<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // LargeChange

/*ValueSetterGenerator*/
public static T LargeChange<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.LargeChange = value);

/*BindFromExpressionSetterGenerator*/
public static T LargeChange<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T LargeChange<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T LargeChange<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LargeChange<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // ValueChanged

/*ActionToEventGenerator*/
public static T OnValueChanged<T>(this T control, Action<Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.RangeBase 
{
  control.AddHandler(Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MinimumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MaximumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, binding);


 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.ValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.ValueProperty, binding);


 // SmallChange

/*ValueStyleSetterGenerator*/
public static Style<T> SmallChange<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SmallChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, binding);


 // LargeChange

/*ValueStyleSetterGenerator*/
public static Style<T> LargeChange<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LargeChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, binding);



}
