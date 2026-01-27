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
public static partial class SelectingItemsControl_MarkupExtensions
{
//================= Properties ======================//
 // AutoScrollToSelectedItem

/*ValueSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.AutoScrollToSelectedItem = value);

/*BindFromExpressionSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectedIndex

/*ValueSetterGenerator*/
public static T SelectedIndex<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.SelectedIndex = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectedIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectedIndex<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectedIndex<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectedItem

/*ValueSetterGenerator*/
public static T SelectedItem<T>(this T control, System.Object? value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.SelectedItem = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectedItem<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectedItem<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectedItem<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectedValue

/*ValueSetterGenerator*/
public static T SelectedValue<T>(this T control, System.Object? value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.SelectedValue = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectedValue<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectedValue<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectedValue<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectedValueBinding

/*ValueSetterGenerator*/
public static T SelectedValueBinding<T>(this T control, Avalonia.Data.IBinding? value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.SelectedValueBinding = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectedValueBinding<T>(this T control, Func<Avalonia.Data.IBinding?> func, Action<Avalonia.Data.IBinding?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectedValueBinding<T>(this T control, Func<ValueTask<Avalonia.Data.IBinding?>> getter, Func<Avalonia.Data.IBinding?>? fallbackGetter = null, Action<Avalonia.Data.IBinding?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty!, getter, fallbackGetter, onChanged, expression);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedValueBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsTextSearchEnabled

/*ValueSetterGenerator*/
public static T IsTextSearchEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.IsTextSearchEnabled = value);

/*BindFromExpressionSetterGenerator*/
public static T IsTextSearchEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsTextSearchEnabled<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsTextSearchEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTextSearchEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // WrapSelection

/*ValueSetterGenerator*/
public static T WrapSelection<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.WrapSelection = value);

/*BindFromExpressionSetterGenerator*/
public static T WrapSelection<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T WrapSelection<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T WrapSelection<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T WrapSelection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
{
  control.AddHandler(Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // AutoScrollToSelectedItem

/*ValueStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, binding);


 // SelectedValue

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedValue<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedValue<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, binding);


 // SelectedValueBinding

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedValueBinding<T>(this Style<T> style, Avalonia.Data.IBinding? value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped SelectedValueBinding because already exist in value setters


 // IsTextSearchEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsTextSearchEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTextSearchEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, binding);


 // WrapSelection

/*ValueStyleSetterGenerator*/
public static Style<T> WrapSelection<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WrapSelection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, binding);



}
