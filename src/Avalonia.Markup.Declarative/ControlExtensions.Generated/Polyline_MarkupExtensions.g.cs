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
public static partial class Polyline_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*ValueSetterGenerator*/
public static T Points<T>(this T control, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Controls.Shapes.Polyline 
=> control._set(() => control.Points = value);

/*BindFromExpressionSetterGenerator*/
public static T Points<T>(this T control, Func<System.Collections.Generic.IList<Avalonia.Point>> func, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(Avalonia.Controls.Shapes.Polyline.PointsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Points<T>(this T control, Func<ValueTask<System.Collections.Generic.IList<Avalonia.Point>>> getter, Func<System.Collections.Generic.IList<Avalonia.Point>>? fallbackGetter = null, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(Avalonia.Controls.Shapes.Polyline.PointsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Points<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(Avalonia.Controls.Shapes.Polyline.PointsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Points<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(Avalonia.Controls.Shapes.Polyline.PointsProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Points

/*ValueStyleSetterGenerator*/
public static Style<T> Points<T>(this Style<T> style, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Controls.Shapes.Polyline 
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.PointsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Points<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Polyline 
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.PointsProperty, binding);



}
