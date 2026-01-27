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
public static partial class QuadraticBezierSegment_MarkupExtensions
{
//================= Properties ======================//
 // Point1

/*ValueSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, Avalonia.Point value)  
=> control._set(() => control.Point1 = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point1Property!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, Func<ValueTask<Avalonia.Point>> getter, Func<Avalonia.Point>? fallbackGetter = null, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point1Property!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, IBinding binding)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point1Property, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point1Property, avaloniaProperty, bindingMode, converter, overrideView);


 // Point2

/*ValueSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, Avalonia.Point value)  
=> control._set(() => control.Point2 = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point2Property!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, Func<ValueTask<Avalonia.Point>> getter, Func<Avalonia.Point>? fallbackGetter = null, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point2Property!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, IBinding binding)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point2Property, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point2Property, avaloniaProperty, bindingMode, converter, overrideView);



}
