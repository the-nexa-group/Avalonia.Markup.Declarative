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
public static partial class Shape_MarkupExtensions
{
//================= Properties ======================//
 // Fill

/*ValueSetterGenerator*/
public static T Fill<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.Fill = value);

/*BindFromExpressionSetterGenerator*/
public static T Fill<T>(this T control, Func<Avalonia.Media.IBrush?> func, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.FillProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Fill<T>(this T control, Func<ValueTask<Avalonia.Media.IBrush?>> getter, Func<Avalonia.Media.IBrush?>? fallbackGetter = null, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.FillProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Fill<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.FillProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Fill<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.FillProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Stretch

/*ValueSetterGenerator*/
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.Stretch = value);

/*BindFromExpressionSetterGenerator*/
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func, Action<Avalonia.Media.Stretch>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StretchProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Stretch<T>(this T control, Func<ValueTask<Avalonia.Media.Stretch>> getter, Func<Avalonia.Media.Stretch>? fallbackGetter = null, Action<Avalonia.Media.Stretch>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StretchProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Stretch<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StretchProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Stretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StretchProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Stroke

/*ValueSetterGenerator*/
public static T Stroke<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.Stroke = value);

/*BindFromExpressionSetterGenerator*/
public static T Stroke<T>(this T control, Func<Avalonia.Media.IBrush?> func, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Stroke<T>(this T control, Func<ValueTask<Avalonia.Media.IBrush?>> getter, Func<Avalonia.Media.IBrush?>? fallbackGetter = null, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Stroke<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Stroke<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StrokeDashArray

/*ValueSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double>? value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.StrokeDashArray = value);

/*BindFromExpressionSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>?> func, Action<Avalonia.Collections.AvaloniaList<System.Double>?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Func<ValueTask<Avalonia.Collections.AvaloniaList<System.Double>?>> getter, Func<Avalonia.Collections.AvaloniaList<System.Double>?>? fallbackGetter = null, Action<Avalonia.Collections.AvaloniaList<System.Double>?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StrokeDashArray<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeDashArray<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StrokeDashOffset

/*ValueSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.StrokeDashOffset = value);

/*BindFromExpressionSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StrokeThickness

/*ValueSetterGenerator*/
public static T StrokeThickness<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.StrokeThickness = value);

/*BindFromExpressionSetterGenerator*/
public static T StrokeThickness<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StrokeThickness<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StrokeThickness<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StrokeLineCap

/*ValueSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Avalonia.Media.PenLineCap value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.StrokeLineCap = value);

/*BindFromExpressionSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Func<Avalonia.Media.PenLineCap> func, Action<Avalonia.Media.PenLineCap>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Func<ValueTask<Avalonia.Media.PenLineCap>> getter, Func<Avalonia.Media.PenLineCap>? fallbackGetter = null, Action<Avalonia.Media.PenLineCap>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StrokeLineCap<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeLineCap<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StrokeJoin

/*ValueSetterGenerator*/
public static T StrokeJoin<T>(this T control, Avalonia.Media.PenLineJoin value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.StrokeJoin = value);

/*BindFromExpressionSetterGenerator*/
public static T StrokeJoin<T>(this T control, Func<Avalonia.Media.PenLineJoin> func, Action<Avalonia.Media.PenLineJoin>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StrokeJoin<T>(this T control, Func<ValueTask<Avalonia.Media.PenLineJoin>> getter, Func<Avalonia.Media.PenLineJoin>? fallbackGetter = null, Action<Avalonia.Media.PenLineJoin>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StrokeJoin<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeJoin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Fill

/*ValueStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.FillProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.FillProperty, binding);


 // Stretch

/*ValueStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StretchProperty, binding);


 // Stroke

/*ValueStyleSetterGenerator*/
public static Style<T> Stroke<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Stroke<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeProperty, binding);


 // StrokeDashArray

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeDashArray<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double>? value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeDashArray<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, binding);


 // StrokeDashOffset

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeDashOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeDashOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, binding);


 // StrokeThickness

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeThickness<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, binding);


 // StrokeLineCap

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeLineCap<T>(this Style<T> style, Avalonia.Media.PenLineCap value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeLineCap<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, binding);


 // StrokeJoin

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeJoin<T>(this Style<T> style, Avalonia.Media.PenLineJoin value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeJoin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, binding);



}
