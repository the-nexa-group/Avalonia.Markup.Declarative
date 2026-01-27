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
public static partial class WrapPanel_MarkupExtensions
{
//================= Properties ======================//
 // ItemSpacing

/*ValueSetterGenerator*/
public static T ItemSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.ItemSpacing = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemSpacingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemSpacing<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemSpacingProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // LineSpacing

/*ValueSetterGenerator*/
public static T LineSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.LineSpacing = value);

/*BindFromExpressionSetterGenerator*/
public static T LineSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.LineSpacingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T LineSpacing<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.LineSpacingProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T LineSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.LineSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LineSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.LineSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.Orientation = value);

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Orientation<T>(this T control, Func<ValueTask<Avalonia.Layout.Orientation>> getter, Func<Avalonia.Layout.Orientation>? fallbackGetter = null, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ItemsAlignment

/*ValueSetterGenerator*/
public static T ItemsAlignment<T>(this T control, Avalonia.Controls.WrapPanelItemsAlignment value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.ItemsAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemsAlignment<T>(this T control, Func<Avalonia.Controls.WrapPanelItemsAlignment> func, Action<Avalonia.Controls.WrapPanelItemsAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemsAlignment<T>(this T control, Func<ValueTask<Avalonia.Controls.WrapPanelItemsAlignment>> getter, Func<Avalonia.Controls.WrapPanelItemsAlignment>? fallbackGetter = null, Action<Avalonia.Controls.WrapPanelItemsAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemsAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ItemWidth

/*ValueSetterGenerator*/
public static T ItemWidth<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.ItemWidth = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemWidth<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemWidth<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ItemHeight

/*ValueSetterGenerator*/
public static T ItemHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.ItemHeight = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemHeight<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // ItemSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> ItemSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemSpacingProperty, binding);


 // LineSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.LineSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.LineSpacingProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.OrientationProperty, binding);


 // ItemsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsAlignment<T>(this Style<T> style, Avalonia.Controls.WrapPanelItemsAlignment value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty, binding);


 // ItemWidth

/*ValueStyleSetterGenerator*/
public static Style<T> ItemWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemWidthProperty, binding);


 // ItemHeight

/*ValueStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemHeightProperty, binding);



}
