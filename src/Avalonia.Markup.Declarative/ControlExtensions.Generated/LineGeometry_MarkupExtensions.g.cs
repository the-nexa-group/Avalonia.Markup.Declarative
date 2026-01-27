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
public static partial class LineGeometry_MarkupExtensions
{
//================= Properties ======================//
 // StartPoint

/*ValueSetterGenerator*/
public static T StartPoint<T>(this T control, Avalonia.Point value) where T : Avalonia.Media.LineGeometry 
=> control._set(() => control.StartPoint = value);

/*BindFromExpressionSetterGenerator*/
public static T StartPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.StartPointProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StartPoint<T>(this T control, Func<ValueTask<Avalonia.Point>> getter, Func<Avalonia.Point>? fallbackGetter = null, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.StartPointProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StartPoint<T>(this T control, IBinding binding) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.StartPointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StartPoint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.StartPointProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // EndPoint

/*ValueSetterGenerator*/
public static T EndPoint<T>(this T control, Avalonia.Point value) where T : Avalonia.Media.LineGeometry 
=> control._set(() => control.EndPoint = value);

/*BindFromExpressionSetterGenerator*/
public static T EndPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.EndPointProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T EndPoint<T>(this T control, Func<ValueTask<Avalonia.Point>> getter, Func<Avalonia.Point>? fallbackGetter = null, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.EndPointProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T EndPoint<T>(this T control, IBinding binding) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.EndPointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T EndPoint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.EndPointProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
