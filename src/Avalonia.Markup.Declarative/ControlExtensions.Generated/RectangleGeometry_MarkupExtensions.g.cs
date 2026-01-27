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
public static partial class RectangleGeometry_MarkupExtensions
{
//================= Properties ======================//
 // RadiusX

/*ValueSetterGenerator*/
public static T RadiusX<T>(this T control, System.Double value) where T : Avalonia.Media.RectangleGeometry 
=> control._set(() => control.RadiusX = value);

/*BindFromExpressionSetterGenerator*/
public static T RadiusX<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusXProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T RadiusX<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusXProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T RadiusX<T>(this T control, IBinding binding) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RadiusX<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusXProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // RadiusY

/*ValueSetterGenerator*/
public static T RadiusY<T>(this T control, System.Double value) where T : Avalonia.Media.RectangleGeometry 
=> control._set(() => control.RadiusY = value);

/*BindFromExpressionSetterGenerator*/
public static T RadiusY<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusYProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T RadiusY<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusYProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T RadiusY<T>(this T control, IBinding binding) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RadiusY<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusYProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Rect

/*ValueSetterGenerator*/
public static T Rect<T>(this T control, Avalonia.Rect value) where T : Avalonia.Media.RectangleGeometry 
=> control._set(() => control.Rect = value);

/*BindFromExpressionSetterGenerator*/
public static T Rect<T>(this T control, Func<Avalonia.Rect> func, Action<Avalonia.Rect>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RectProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Rect<T>(this T control, Func<ValueTask<Avalonia.Rect>> getter, Func<Avalonia.Rect>? fallbackGetter = null, Action<Avalonia.Rect>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RectProperty!, getter, fallbackGetter, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T Rect<T>(this T control, System.Double x = default!, System.Double y = default!, System.Double width = default!, System.Double height = default!) where T : Avalonia.Media.RectangleGeometry 
   => control._set(() => control.Rect = new Avalonia.Rect(x, y, width, height));
public static T Rect<T>(this T control, Avalonia.Size size = default!) where T : Avalonia.Media.RectangleGeometry 
   => control._set(() => control.Rect = new Avalonia.Rect(size));
public static T Rect<T>(this T control, Avalonia.Point position = default!, Avalonia.Size size = default!) where T : Avalonia.Media.RectangleGeometry 
   => control._set(() => control.Rect = new Avalonia.Rect(position, size));
public static T Rect<T>(this T control, Avalonia.Point topLeft = default!, Avalonia.Point bottomRight = default!) where T : Avalonia.Media.RectangleGeometry 
   => control._set(() => control.Rect = new Avalonia.Rect(topLeft, bottomRight));

/*BindSetterGenerator*/
public static T Rect<T>(this T control, IBinding binding) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Rect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RectProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
