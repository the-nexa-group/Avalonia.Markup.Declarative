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
public static partial class Arc_MarkupExtensions
{
//================= Properties ======================//
 // StartAngle

/*ValueSetterGenerator*/
public static T StartAngle<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Arc 
=> control._set(() => control.StartAngle = value);

/*BindFromExpressionSetterGenerator*/
public static T StartAngle<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.StartAngleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StartAngle<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.StartAngleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StartAngle<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.StartAngleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StartAngle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.StartAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SweepAngle

/*ValueSetterGenerator*/
public static T SweepAngle<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Arc 
=> control._set(() => control.SweepAngle = value);

/*BindFromExpressionSetterGenerator*/
public static T SweepAngle<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.SweepAngleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SweepAngle<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.SweepAngleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SweepAngle<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.SweepAngleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SweepAngle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.SweepAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // StartAngle

/*ValueStyleSetterGenerator*/
public static Style<T> StartAngle<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Arc 
=> style._addSetter(Avalonia.Controls.Shapes.Arc.StartAngleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StartAngle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Arc 
=> style._addSetter(Avalonia.Controls.Shapes.Arc.StartAngleProperty, binding);


 // SweepAngle

/*ValueStyleSetterGenerator*/
public static Style<T> SweepAngle<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Arc 
=> style._addSetter(Avalonia.Controls.Shapes.Arc.SweepAngleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SweepAngle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Arc 
=> style._addSetter(Avalonia.Controls.Shapes.Arc.SweepAngleProperty, binding);



}
