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
public static partial class Layoutable_MarkupExtensions
{
//================= Properties ======================//
 // Width

/*ValueSetterGenerator*/
public static T Width<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.Width = value);

/*BindFromExpressionSetterGenerator*/
public static T Width<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.WidthProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Width<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.WidthProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Width<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.WidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Width<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.WidthProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Height

/*ValueSetterGenerator*/
public static T Height<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.Height = value);

/*BindFromExpressionSetterGenerator*/
public static T Height<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HeightProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Height<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HeightProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Height<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Height<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HeightProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MinWidth

/*ValueSetterGenerator*/
public static T MinWidth<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.MinWidth = value);

/*BindFromExpressionSetterGenerator*/
public static T MinWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinWidthProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MinWidth<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinWidthProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MinWidth<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MaxWidth

/*ValueSetterGenerator*/
public static T MaxWidth<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.MaxWidth = value);

/*BindFromExpressionSetterGenerator*/
public static T MaxWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxWidthProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MaxWidth<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxWidthProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MaxWidth<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MinHeight

/*ValueSetterGenerator*/
public static T MinHeight<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.MinHeight = value);

/*BindFromExpressionSetterGenerator*/
public static T MinHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinHeightProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MinHeight<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinHeightProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MinHeight<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MaxHeight

/*ValueSetterGenerator*/
public static T MaxHeight<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.MaxHeight = value);

/*BindFromExpressionSetterGenerator*/
public static T MaxHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxHeightProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MaxHeight<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxHeightProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MaxHeight<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Margin

/*ValueSetterGenerator*/
public static T Margin<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.Margin = value);

/*BindFromExpressionSetterGenerator*/
public static T Margin<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MarginProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Margin<T>(this T control, Func<ValueTask<Avalonia.Thickness>> getter, Func<Avalonia.Thickness>? fallbackGetter = null, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MarginProperty!, getter, fallbackGetter, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T Margin<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Layout.Layoutable 
   => control._set(() => control.Margin = new Avalonia.Thickness(uniformLength));
public static T Margin<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Layout.Layoutable 
   => control._set(() => control.Margin = new Avalonia.Thickness(horizontal, vertical));
public static T Margin<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Layout.Layoutable 
   => control._set(() => control.Margin = new Avalonia.Thickness(left, top, right, bottom));

/*BindSetterGenerator*/
public static T Margin<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MarginProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Margin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MarginProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HorizontalAlignment

/*ValueSetterGenerator*/
public static T HorizontalAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.HorizontalAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HorizontalAlignment<T>(this T control, Func<ValueTask<Avalonia.Layout.HorizontalAlignment>> getter, Func<Avalonia.Layout.HorizontalAlignment>? fallbackGetter = null, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HorizontalAlignment<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // VerticalAlignment

/*ValueSetterGenerator*/
public static T VerticalAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.VerticalAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T VerticalAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.VerticalAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T VerticalAlignment<T>(this T control, Func<ValueTask<Avalonia.Layout.VerticalAlignment>> getter, Func<Avalonia.Layout.VerticalAlignment>? fallbackGetter = null, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.VerticalAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T VerticalAlignment<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.VerticalAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.VerticalAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // UseLayoutRounding

/*ValueSetterGenerator*/
public static T UseLayoutRounding<T>(this T control, System.Boolean value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.UseLayoutRounding = value);

/*BindFromExpressionSetterGenerator*/
public static T UseLayoutRounding<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T UseLayoutRounding<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T UseLayoutRounding<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseLayoutRounding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // EffectiveViewportChanged

/*ActionToEventGenerator*/
public static T OnEffectiveViewportChanged<T>(this T control, Action<Avalonia.Layout.EffectiveViewportChangedEventArgs> action) where T : Avalonia.Layout.Layoutable  => 
 control._setEvent((System.EventHandler<Avalonia.Layout.EffectiveViewportChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.EffectiveViewportChanged += h);


 // LayoutUpdated

/*ActionToEventGenerator*/
public static T OnLayoutUpdated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Layout.Layoutable  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.LayoutUpdated += h);



//================= Styles ======================//
 // Width

/*ValueStyleSetterGenerator*/
public static Style<T> Width<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.WidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Width<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.WidthProperty, binding);


 // Height

/*ValueStyleSetterGenerator*/
public static Style<T> Height<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.HeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Height<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.HeightProperty, binding);


 // MinWidth

/*ValueStyleSetterGenerator*/
public static Style<T> MinWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MinWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MinWidthProperty, binding);


 // MaxWidth

/*ValueStyleSetterGenerator*/
public static Style<T> MaxWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MaxWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MaxWidthProperty, binding);


 // MinHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MinHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MinHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MinHeightProperty, binding);


 // MaxHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MaxHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MaxHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MaxHeightProperty, binding);


 // Margin

/*ValueStyleSetterGenerator*/
public static Style<T> Margin<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MarginProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Margin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Margin<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Layout.Layoutable 
   => style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Margin<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Layout.Layoutable 
   => style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Margin<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Layout.Layoutable 
   => style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, new Avalonia.Thickness(left, top, right, bottom));


 // HorizontalAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty, binding);


 // VerticalAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.VerticalAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.VerticalAlignmentProperty, binding);


 // UseLayoutRounding

/*ValueStyleSetterGenerator*/
public static Style<T> UseLayoutRounding<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseLayoutRounding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty, binding);



}
