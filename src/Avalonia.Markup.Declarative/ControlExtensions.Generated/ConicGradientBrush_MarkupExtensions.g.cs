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
public static partial class ConicGradientBrush_MarkupExtensions
{
//================= Properties ======================//
 // Center

/*ValueSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Avalonia.RelativePoint value)  
=> control._set(() => control.Center = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.ConicGradientBrush.CenterProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Func<ValueTask<Avalonia.RelativePoint>> getter, Func<Avalonia.RelativePoint>? fallbackGetter = null, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.ConicGradientBrush.CenterProperty!, getter, fallbackGetter, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.Center = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.Center = new Avalonia.RelativePoint(point, unit));

/*BindSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, IBinding binding)  
   => control._set(Avalonia.Media.ConicGradientBrush.CenterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ConicGradientBrush.CenterProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Angle

/*ValueSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, System.Double value)  
=> control._set(() => control.Angle = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.ConicGradientBrush.AngleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.ConicGradientBrush.AngleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, IBinding binding)  
   => control._set(Avalonia.Media.ConicGradientBrush.AngleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ConicGradientBrush.AngleProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
