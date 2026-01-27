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
public static partial class LinearGradientBrush_MarkupExtensions
{
//================= Properties ======================//
 // StartPoint

/*ValueSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.RelativePoint value)  
=> control._set(() => control.StartPoint = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.LinearGradientBrush.StartPointProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Func<ValueTask<Avalonia.RelativePoint>> getter, Func<Avalonia.RelativePoint>? fallbackGetter = null, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.LinearGradientBrush.StartPointProperty!, getter, fallbackGetter, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.StartPoint = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.StartPoint = new Avalonia.RelativePoint(point, unit));

/*BindSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, IBinding binding)  
   => control._set(Avalonia.Media.LinearGradientBrush.StartPointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.LinearGradientBrush.StartPointProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // EndPoint

/*ValueSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.RelativePoint value)  
=> control._set(() => control.EndPoint = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.LinearGradientBrush.EndPointProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Func<ValueTask<Avalonia.RelativePoint>> getter, Func<Avalonia.RelativePoint>? fallbackGetter = null, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.LinearGradientBrush.EndPointProperty!, getter, fallbackGetter, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.EndPoint = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.EndPoint = new Avalonia.RelativePoint(point, unit));

/*BindSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, IBinding binding)  
   => control._set(Avalonia.Media.LinearGradientBrush.EndPointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.LinearGradientBrush.EndPointProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
