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
public static partial class Rectangle_MarkupExtensions
{
//================= Properties ======================//
 // RadiusX

/*ValueSetterGenerator*/
public static T RadiusX<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
=> control._set(() => control.RadiusX = value);

/*BindFromExpressionSetterGenerator*/
public static T RadiusX<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T RadiusX<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T RadiusX<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RadiusX<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // RadiusY

/*ValueSetterGenerator*/
public static T RadiusY<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
=> control._set(() => control.RadiusY = value);

/*BindFromExpressionSetterGenerator*/
public static T RadiusY<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T RadiusY<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T RadiusY<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RadiusY<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // RadiusX

/*ValueStyleSetterGenerator*/
public static Style<T> RadiusX<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RadiusX<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty, binding);


 // RadiusY

/*ValueStyleSetterGenerator*/
public static Style<T> RadiusY<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RadiusY<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty, binding);



}
