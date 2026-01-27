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
public static partial class PathFigure_MarkupExtensions
{
//================= Properties ======================//
 // IsClosed

/*ValueSetterGenerator*/
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, System.Boolean value)  
=> control._set(() => control.IsClosed = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.PathFigure.IsClosedProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.PathFigure.IsClosedProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, IBinding binding)  
   => control._set(Avalonia.Media.PathFigure.IsClosedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.PathFigure.IsClosedProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsFilled

/*ValueSetterGenerator*/
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, System.Boolean value)  
=> control._set(() => control.IsFilled = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.PathFigure.IsFilledProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.PathFigure.IsFilledProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, IBinding binding)  
   => control._set(Avalonia.Media.PathFigure.IsFilledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.PathFigure.IsFilledProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Segments

/*ValueSetterGenerator*/
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, Avalonia.Media.PathSegments? value)  
=> control._set(() => control.Segments = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, Func<Avalonia.Media.PathSegments?> func, Action<Avalonia.Media.PathSegments?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.PathFigure.SegmentsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, Func<ValueTask<Avalonia.Media.PathSegments?>> getter, Func<Avalonia.Media.PathSegments?>? fallbackGetter = null, Action<Avalonia.Media.PathSegments?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.PathFigure.SegmentsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, IBinding binding)  
   => control._set(Avalonia.Media.PathFigure.SegmentsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.PathFigure.SegmentsProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StartPoint

/*ValueSetterGenerator*/
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, Avalonia.Point value)  
=> control._set(() => control.StartPoint = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.PathFigure.StartPointProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, Func<ValueTask<Avalonia.Point>> getter, Func<Avalonia.Point>? fallbackGetter = null, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.PathFigure.StartPointProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, IBinding binding)  
   => control._set(Avalonia.Media.PathFigure.StartPointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.PathFigure.StartPointProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
