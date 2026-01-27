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
public static partial class LineSegment_MarkupExtensions
{
//================= Properties ======================//
 // Point

/*ValueSetterGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, Avalonia.Point value)  
=> control._set(() => control.Point = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.LineSegment.PointProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, Func<ValueTask<Avalonia.Point>> getter, Func<Avalonia.Point>? fallbackGetter = null, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.LineSegment.PointProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, IBinding binding)  
   => control._set(Avalonia.Media.LineSegment.PointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.LineSegment.PointProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
