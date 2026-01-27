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
public static partial class BezierSegment_MarkupExtensions
{
//================= Properties ======================//
 // Point1

/*ValueSetterGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control, Avalonia.Point value)  
=> control._set(() => control.Point1 = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.BezierSegment.Point1Property!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control, Func<ValueTask<Avalonia.Point>> getter, Func<Avalonia.Point>? fallbackGetter = null, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.BezierSegment.Point1Property!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control, IBinding binding)  
   => control._set(Avalonia.Media.BezierSegment.Point1Property, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.BezierSegment.Point1Property, avaloniaProperty, bindingMode, converter, overrideView);


 // Point2

/*ValueSetterGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control, Avalonia.Point value)  
=> control._set(() => control.Point2 = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.BezierSegment.Point2Property!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control, Func<ValueTask<Avalonia.Point>> getter, Func<Avalonia.Point>? fallbackGetter = null, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.BezierSegment.Point2Property!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control, IBinding binding)  
   => control._set(Avalonia.Media.BezierSegment.Point2Property, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.BezierSegment.Point2Property, avaloniaProperty, bindingMode, converter, overrideView);


 // Point3

/*ValueSetterGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control, Avalonia.Point value)  
=> control._set(() => control.Point3 = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.BezierSegment.Point3Property!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control, Func<ValueTask<Avalonia.Point>> getter, Func<Avalonia.Point>? fallbackGetter = null, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.BezierSegment.Point3Property!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control, IBinding binding)  
   => control._set(Avalonia.Media.BezierSegment.Point3Property, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.BezierSegment.Point3Property, avaloniaProperty, bindingMode, converter, overrideView);



}
