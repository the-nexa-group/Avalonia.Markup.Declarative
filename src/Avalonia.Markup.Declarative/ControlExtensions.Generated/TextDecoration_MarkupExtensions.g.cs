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
public static partial class TextDecoration_MarkupExtensions
{
//================= Properties ======================//
 // Location

/*ValueSetterGenerator*/
public static T Location<T>(this T control, Avalonia.Media.TextDecorationLocation value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.Location = value);

/*BindFromExpressionSetterGenerator*/
public static T Location<T>(this T control, Func<Avalonia.Media.TextDecorationLocation> func, Action<Avalonia.Media.TextDecorationLocation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.LocationProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Location<T>(this T control, Func<ValueTask<Avalonia.Media.TextDecorationLocation>> getter, Func<Avalonia.Media.TextDecorationLocation>? fallbackGetter = null, Action<Avalonia.Media.TextDecorationLocation>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.LocationProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Location<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.LocationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Location<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.LocationProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Stroke

/*ValueSetterGenerator*/
public static T Stroke<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.Stroke = value);

/*BindFromExpressionSetterGenerator*/
public static T Stroke<T>(this T control, Func<Avalonia.Media.IBrush?> func, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Stroke<T>(this T control, Func<ValueTask<Avalonia.Media.IBrush?>> getter, Func<Avalonia.Media.IBrush?>? fallbackGetter = null, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Stroke<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Stroke<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StrokeThicknessUnit

/*ValueSetterGenerator*/
public static T StrokeThicknessUnit<T>(this T control, Avalonia.Media.TextDecorationUnit value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeThicknessUnit = value);

/*BindFromExpressionSetterGenerator*/
public static T StrokeThicknessUnit<T>(this T control, Func<Avalonia.Media.TextDecorationUnit> func, Action<Avalonia.Media.TextDecorationUnit>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StrokeThicknessUnit<T>(this T control, Func<ValueTask<Avalonia.Media.TextDecorationUnit>> getter, Func<Avalonia.Media.TextDecorationUnit>? fallbackGetter = null, Action<Avalonia.Media.TextDecorationUnit>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StrokeThicknessUnit<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeThicknessUnit<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StrokeDashArray

/*ValueSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double>? value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeDashArray = value);

/*BindFromExpressionSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>?> func, Action<Avalonia.Collections.AvaloniaList<System.Double>?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashArrayProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Func<ValueTask<Avalonia.Collections.AvaloniaList<System.Double>?>> getter, Func<Avalonia.Collections.AvaloniaList<System.Double>?>? fallbackGetter = null, Action<Avalonia.Collections.AvaloniaList<System.Double>?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashArrayProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StrokeDashArray<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashArrayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeDashArray<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashArrayProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StrokeDashOffset

/*ValueSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, System.Double value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeDashOffset = value);

/*BindFromExpressionSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StrokeThickness

/*ValueSetterGenerator*/
public static T StrokeThickness<T>(this T control, System.Double value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeThickness = value);

/*BindFromExpressionSetterGenerator*/
public static T StrokeThickness<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StrokeThickness<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StrokeThickness<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StrokeLineCap

/*ValueSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Avalonia.Media.PenLineCap value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeLineCap = value);

/*BindFromExpressionSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Func<Avalonia.Media.PenLineCap> func, Action<Avalonia.Media.PenLineCap>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeLineCapProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Func<ValueTask<Avalonia.Media.PenLineCap>> getter, Func<Avalonia.Media.PenLineCap>? fallbackGetter = null, Action<Avalonia.Media.PenLineCap>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeLineCapProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StrokeLineCap<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeLineCapProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeLineCap<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeLineCapProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StrokeOffset

/*ValueSetterGenerator*/
public static T StrokeOffset<T>(this T control, System.Double value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeOffset = value);

/*BindFromExpressionSetterGenerator*/
public static T StrokeOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StrokeOffset<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StrokeOffset<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StrokeOffsetUnit

/*ValueSetterGenerator*/
public static T StrokeOffsetUnit<T>(this T control, Avalonia.Media.TextDecorationUnit value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeOffsetUnit = value);

/*BindFromExpressionSetterGenerator*/
public static T StrokeOffsetUnit<T>(this T control, Func<Avalonia.Media.TextDecorationUnit> func, Action<Avalonia.Media.TextDecorationUnit>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StrokeOffsetUnit<T>(this T control, Func<ValueTask<Avalonia.Media.TextDecorationUnit>> getter, Func<Avalonia.Media.TextDecorationUnit>? fallbackGetter = null, Action<Avalonia.Media.TextDecorationUnit>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StrokeOffsetUnit<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeOffsetUnit<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
