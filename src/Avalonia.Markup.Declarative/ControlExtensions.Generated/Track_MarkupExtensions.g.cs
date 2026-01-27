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
public static partial class Track_MarkupExtensions
{
//================= Properties ======================//
 // Minimum

/*ValueSetterGenerator*/
public static T Minimum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.Minimum = value);

/*BindFromExpressionSetterGenerator*/
public static T Minimum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MinimumProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Minimum<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MinimumProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Minimum<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MinimumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Minimum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Maximum

/*ValueSetterGenerator*/
public static T Maximum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.Maximum = value);

/*BindFromExpressionSetterGenerator*/
public static T Maximum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MaximumProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Maximum<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MaximumProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Maximum<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MaximumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Maximum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Value

/*ValueSetterGenerator*/
public static T Value<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.Value = value);

/*BindFromExpressionSetterGenerator*/
public static T Value<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ValueProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Value<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ValueProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Value<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Value<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ViewportSize

/*ValueSetterGenerator*/
public static T ViewportSize<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.ViewportSize = value);

/*BindFromExpressionSetterGenerator*/
public static T ViewportSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ViewportSizeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ViewportSize<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ViewportSizeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ViewportSize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ViewportSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.Orientation = value);

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.OrientationProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Orientation<T>(this T control, Func<ValueTask<Avalonia.Layout.Orientation>> getter, Func<Avalonia.Layout.Orientation>? fallbackGetter = null, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.OrientationProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Thumb

/*ValueSetterGenerator*/
public static T Thumb<T>(this T control, Avalonia.Controls.Primitives.Thumb? value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.Thumb = value);

/*BindFromExpressionSetterGenerator*/
public static T Thumb<T>(this T control, Func<Avalonia.Controls.Primitives.Thumb?> func, Action<Avalonia.Controls.Primitives.Thumb?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ThumbProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Thumb<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.Thumb?>> getter, Func<Avalonia.Controls.Primitives.Thumb?>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.Thumb?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ThumbProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Thumb<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ThumbProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Thumb<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ThumbProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IncreaseButton

/*ValueSetterGenerator*/
public static T IncreaseButton<T>(this T control, Avalonia.Controls.Button? value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.IncreaseButton = value);

/*BindFromExpressionSetterGenerator*/
public static T IncreaseButton<T>(this T control, Func<Avalonia.Controls.Button?> func, Action<Avalonia.Controls.Button?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IncreaseButton<T>(this T control, Func<ValueTask<Avalonia.Controls.Button?>> getter, Func<Avalonia.Controls.Button?>? fallbackGetter = null, Action<Avalonia.Controls.Button?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IncreaseButton<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IncreaseButton<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // DecreaseButton

/*ValueSetterGenerator*/
public static T DecreaseButton<T>(this T control, Avalonia.Controls.Button? value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.DecreaseButton = value);

/*BindFromExpressionSetterGenerator*/
public static T DecreaseButton<T>(this T control, Func<Avalonia.Controls.Button?> func, Action<Avalonia.Controls.Button?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DecreaseButton<T>(this T control, Func<ValueTask<Avalonia.Controls.Button?>> getter, Func<Avalonia.Controls.Button?>? fallbackGetter = null, Action<Avalonia.Controls.Button?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T DecreaseButton<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DecreaseButton<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsDirectionReversed

/*ValueSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.IsDirectionReversed = value);

/*BindFromExpressionSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IgnoreThumbDrag

/*ValueSetterGenerator*/
public static T IgnoreThumbDrag<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.IgnoreThumbDrag = value);

/*BindFromExpressionSetterGenerator*/
public static T IgnoreThumbDrag<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IgnoreThumbDrag<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IgnoreThumbDrag<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IgnoreThumbDrag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // DeferThumbDrag

/*ValueSetterGenerator*/
public static T DeferThumbDrag<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.DeferThumbDrag = value);

/*BindFromExpressionSetterGenerator*/
public static T DeferThumbDrag<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DeferThumbDrag<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T DeferThumbDrag<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DeferThumbDrag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MinimumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MinimumProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MaximumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MaximumProperty, binding);


 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ValueProperty, binding);


 // ViewportSize

/*ValueStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ViewportSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.OrientationProperty, binding);


 // Thumb

/*ValueStyleSetterGenerator*/
public static Style<T> Thumb<T>(this Style<T> style, Avalonia.Controls.Primitives.Thumb? value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ThumbProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Thumb<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ThumbProperty, binding);


 // IncreaseButton

/*ValueStyleSetterGenerator*/
public static Style<T> IncreaseButton<T>(this Style<T> style, Avalonia.Controls.Button? value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IncreaseButton<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, binding);


 // DecreaseButton

/*ValueStyleSetterGenerator*/
public static Style<T> DecreaseButton<T>(this Style<T> style, Avalonia.Controls.Button? value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DecreaseButton<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, binding);


 // IsDirectionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, binding);


 // IgnoreThumbDrag

/*ValueStyleSetterGenerator*/
public static Style<T> IgnoreThumbDrag<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IgnoreThumbDrag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, binding);


 // DeferThumbDrag

/*ValueStyleSetterGenerator*/
public static Style<T> DeferThumbDrag<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DeferThumbDrag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, binding);



}
