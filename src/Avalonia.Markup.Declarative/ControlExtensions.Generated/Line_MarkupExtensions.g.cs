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
public static partial class Line_MarkupExtensions
{
//================= Properties ======================//
 // StartPoint

/*ValueSetterGenerator*/
public static T StartPoint<T>(this T control, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
=> control._set(() => control.StartPoint = value);

/*BindFromExpressionSetterGenerator*/
public static T StartPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.StartPointProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StartPoint<T>(this T control, Func<ValueTask<Avalonia.Point>> getter, Func<Avalonia.Point>? fallbackGetter = null, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.StartPointProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StartPoint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.StartPointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StartPoint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.StartPointProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // EndPoint

/*ValueSetterGenerator*/
public static T EndPoint<T>(this T control, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
=> control._set(() => control.EndPoint = value);

/*BindFromExpressionSetterGenerator*/
public static T EndPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.EndPointProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T EndPoint<T>(this T control, Func<ValueTask<Avalonia.Point>> getter, Func<Avalonia.Point>? fallbackGetter = null, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.EndPointProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T EndPoint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.EndPointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T EndPoint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.EndPointProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // StartPoint

/*ValueStyleSetterGenerator*/
public static Style<T> StartPoint<T>(this Style<T> style, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.StartPointProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StartPoint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.StartPointProperty, binding);


 // EndPoint

/*ValueStyleSetterGenerator*/
public static Style<T> EndPoint<T>(this Style<T> style, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.EndPointProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> EndPoint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.EndPointProperty, binding);



}
