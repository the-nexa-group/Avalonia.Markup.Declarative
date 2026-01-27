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
public static partial class PolylineGeometry_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*ValueSetterGenerator*/
public static T Points<T>(this T control, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Media.PolylineGeometry 
=> control._set(() => control.Points = value);

/*BindFromExpressionSetterGenerator*/
public static T Points<T>(this T control, Func<System.Collections.Generic.IList<Avalonia.Point>> func, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.PointsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Points<T>(this T control, Func<ValueTask<System.Collections.Generic.IList<Avalonia.Point>>> getter, Func<System.Collections.Generic.IList<Avalonia.Point>>? fallbackGetter = null, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.PointsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Points<T>(this T control, IBinding binding) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.PointsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Points<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.PointsProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsFilled

/*ValueSetterGenerator*/
public static T IsFilled<T>(this T control, System.Boolean value) where T : Avalonia.Media.PolylineGeometry 
=> control._set(() => control.IsFilled = value);

/*BindFromExpressionSetterGenerator*/
public static T IsFilled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.IsFilledProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsFilled<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.IsFilledProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsFilled<T>(this T control, IBinding binding) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.IsFilledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsFilled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.IsFilledProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
