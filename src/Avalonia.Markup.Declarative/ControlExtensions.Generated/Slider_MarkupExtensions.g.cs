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
public static partial class Slider_MarkupExtensions
{
//================= Properties ======================//
 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Slider 
=> control._set(() => control.Orientation = value);

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.OrientationProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Orientation<T>(this T control, Func<ValueTask<Avalonia.Layout.Orientation>> getter, Func<Avalonia.Layout.Orientation>? fallbackGetter = null, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.OrientationProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsDirectionReversed

/*ValueSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Slider 
=> control._set(() => control.IsDirectionReversed = value);

/*BindFromExpressionSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsDirectionReversedProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsDirectionReversedProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsDirectionReversedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsSnapToTickEnabled

/*ValueSetterGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Slider 
=> control._set(() => control.IsSnapToTickEnabled = value);

/*BindFromExpressionSetterGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // TickFrequency

/*ValueSetterGenerator*/
public static T TickFrequency<T>(this T control, System.Double value) where T : Avalonia.Controls.Slider 
=> control._set(() => control.TickFrequency = value);

/*BindFromExpressionSetterGenerator*/
public static T TickFrequency<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickFrequencyProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T TickFrequency<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickFrequencyProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T TickFrequency<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickFrequencyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TickFrequency<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickFrequencyProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // TickPlacement

/*ValueSetterGenerator*/
public static T TickPlacement<T>(this T control, Avalonia.Controls.TickPlacement value) where T : Avalonia.Controls.Slider 
=> control._set(() => control.TickPlacement = value);

/*BindFromExpressionSetterGenerator*/
public static T TickPlacement<T>(this T control, Func<Avalonia.Controls.TickPlacement> func, Action<Avalonia.Controls.TickPlacement>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickPlacementProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T TickPlacement<T>(this T control, Func<ValueTask<Avalonia.Controls.TickPlacement>> getter, Func<Avalonia.Controls.TickPlacement>? fallbackGetter = null, Action<Avalonia.Controls.TickPlacement>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickPlacementProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T TickPlacement<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickPlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TickPlacement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickPlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Ticks

/*ValueSetterGenerator*/
public static T Ticks<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double>? value) where T : Avalonia.Controls.Slider 
=> control._set(() => control.Ticks = value);

/*BindFromExpressionSetterGenerator*/
public static T Ticks<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>?> func, Action<Avalonia.Collections.AvaloniaList<System.Double>?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TicksProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Ticks<T>(this T control, Func<ValueTask<Avalonia.Collections.AvaloniaList<System.Double>?>> getter, Func<Avalonia.Collections.AvaloniaList<System.Double>?>? fallbackGetter = null, Action<Avalonia.Collections.AvaloniaList<System.Double>?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TicksProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Ticks<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TicksProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Ticks<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TicksProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.OrientationProperty, binding);


 // IsDirectionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsDirectionReversedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsDirectionReversedProperty, binding);


 // IsSnapToTickEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsSnapToTickEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSnapToTickEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, binding);


 // TickFrequency

/*ValueStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickFrequencyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickFrequencyProperty, binding);


 // TickPlacement

/*ValueStyleSetterGenerator*/
public static Style<T> TickPlacement<T>(this Style<T> style, Avalonia.Controls.TickPlacement value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickPlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TickPlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickPlacementProperty, binding);


 // Ticks

/*ValueStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double>? value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TicksProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TicksProperty, binding);



}
