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
public static partial class TreeView_MarkupExtensions
{
//================= Properties ======================//
 // AutoScrollToSelectedItem

/*ValueSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TreeView 
=> control._set(() => control.AutoScrollToSelectedItem = value);

/*BindFromExpressionSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, IBinding binding) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectedItem

/*ValueSetterGenerator*/
public static T SelectedItem<T>(this T control, System.Object? value) where T : Avalonia.Controls.TreeView 
=> control._set(() => control.SelectedItem = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectedItem<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectedItem<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectedItem<T>(this T control, IBinding binding) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectedItems

/*ValueSetterGenerator*/
public static T SelectedItems<T>(this T control, System.Collections.IList value) where T : Avalonia.Controls.TreeView 
=> control._set(() => control.SelectedItems = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectedItems<T>(this T control, Func<System.Collections.IList> func, Action<System.Collections.IList>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectedItems<T>(this T control, Func<ValueTask<System.Collections.IList>> getter, Func<System.Collections.IList>? fallbackGetter = null, Action<System.Collections.IList>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectedItems<T>(this T control, IBinding binding) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedItems<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectionMode

/*ValueSetterGenerator*/
public static T SelectionMode<T>(this T control, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.TreeView 
=> control._set(() => control.SelectionMode = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectionMode<T>(this T control, Func<Avalonia.Controls.SelectionMode> func, Action<Avalonia.Controls.SelectionMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectionModeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectionMode<T>(this T control, Func<ValueTask<Avalonia.Controls.SelectionMode>> getter, Func<Avalonia.Controls.SelectionMode>? fallbackGetter = null, Action<Avalonia.Controls.SelectionMode>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectionModeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectionMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectionModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectionModeProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.TreeView  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectionChanged += h);



//================= Styles ======================//
 // AutoScrollToSelectedItem

/*ValueStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, binding);


 // SelectionMode

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.SelectionModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.SelectionModeProperty, binding);



}
