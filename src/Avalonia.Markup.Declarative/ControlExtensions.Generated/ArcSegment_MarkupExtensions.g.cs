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
public static partial class ArcSegment_MarkupExtensions
{
//================= Properties ======================//
 // IsLargeArc

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, System.Boolean value)  
=> control._set(() => control.IsLargeArc = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.IsLargeArcProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.IsLargeArcProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, IBinding binding)  
   => control._set(Avalonia.Media.ArcSegment.IsLargeArcProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ArcSegment.IsLargeArcProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Point

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, Avalonia.Point value)  
=> control._set(() => control.Point = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.PointProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, Func<ValueTask<Avalonia.Point>> getter, Func<Avalonia.Point>? fallbackGetter = null, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.PointProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, IBinding binding)  
   => control._set(Avalonia.Media.ArcSegment.PointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ArcSegment.PointProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // RotationAngle

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, System.Double value)  
=> control._set(() => control.RotationAngle = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.RotationAngleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.RotationAngleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, IBinding binding)  
   => control._set(Avalonia.Media.ArcSegment.RotationAngleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ArcSegment.RotationAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Size

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, Avalonia.Size value)  
=> control._set(() => control.Size = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, Func<Avalonia.Size> func, Action<Avalonia.Size>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.SizeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, Func<ValueTask<Avalonia.Size>> getter, Func<Avalonia.Size>? fallbackGetter = null, Action<Avalonia.Size>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.SizeProperty!, getter, fallbackGetter, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, System.Double width = default!, System.Double height = default!)  
   => control._set(() => control.Size = new Avalonia.Size(width, height));
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, System.Numerics.Vector2 vector2 = default!)  
   => control._set(() => control.Size = new Avalonia.Size(vector2));

/*BindSetterGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, IBinding binding)  
   => control._set(Avalonia.Media.ArcSegment.SizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ArcSegment.SizeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SweepDirection

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, Avalonia.Media.SweepDirection value)  
=> control._set(() => control.SweepDirection = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, Func<Avalonia.Media.SweepDirection> func, Action<Avalonia.Media.SweepDirection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.SweepDirectionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, Func<ValueTask<Avalonia.Media.SweepDirection>> getter, Func<Avalonia.Media.SweepDirection>? fallbackGetter = null, Action<Avalonia.Media.SweepDirection>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.SweepDirectionProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, IBinding binding)  
   => control._set(Avalonia.Media.ArcSegment.SweepDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ArcSegment.SweepDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
