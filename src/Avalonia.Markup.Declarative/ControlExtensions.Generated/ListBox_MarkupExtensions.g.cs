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
public static partial class ListBox_MarkupExtensions
{
//================= Properties ======================//
 // SelectedItems

/*ValueSetterGenerator*/
public static T SelectedItems<T>(this T control, System.Collections.IList? value) where T : Avalonia.Controls.ListBox 
=> control._set(() => control.SelectedItems = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectedItems<T>(this T control, Func<System.Collections.IList?> func, Action<System.Collections.IList?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectedItemsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectedItems<T>(this T control, Func<ValueTask<System.Collections.IList?>> getter, Func<System.Collections.IList?>? fallbackGetter = null, Action<System.Collections.IList?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectedItemsProperty!, getter, fallbackGetter, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectedItems<T>(this T control,System.Collections.IList? value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ListBox 
=> control._setEx(Avalonia.Controls.ListBox.SelectedItemsProperty, ps, () => control.SelectedItems = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedItems<T>(this T control, IBinding binding) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectedItemsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedItems<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectedItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectedItems<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.IList?> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ListBox 
=> control._setEx(Avalonia.Controls.ListBox.SelectedItemsProperty, ps, () => control.SelectedItems = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Selection

/*ValueSetterGenerator*/
public static T Selection<T>(this T control, Avalonia.Controls.Selection.ISelectionModel? value) where T : Avalonia.Controls.ListBox 
=> control._set(() => control.Selection = value);

/*BindFromExpressionSetterGenerator*/
public static T Selection<T>(this T control, Func<Avalonia.Controls.Selection.ISelectionModel?> func, Action<Avalonia.Controls.Selection.ISelectionModel?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Selection<T>(this T control, Func<ValueTask<Avalonia.Controls.Selection.ISelectionModel?>> getter, Func<Avalonia.Controls.Selection.ISelectionModel?>? fallbackGetter = null, Action<Avalonia.Controls.Selection.ISelectionModel?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionProperty!, getter, fallbackGetter, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Selection<T>(this T control,Avalonia.Controls.Selection.ISelectionModel? value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ListBox 
=> control._setEx(Avalonia.Controls.ListBox.SelectionProperty, ps, () => control.Selection = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Selection<T>(this T control, IBinding binding) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Selection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Selection<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Selection.ISelectionModel?> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ListBox 
=> control._setEx(Avalonia.Controls.ListBox.SelectionProperty, ps, () => control.Selection = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectionMode

/*ValueSetterGenerator*/
public static T SelectionMode<T>(this T control, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.ListBox 
=> control._set(() => control.SelectionMode = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectionMode<T>(this T control, Func<Avalonia.Controls.SelectionMode> func, Action<Avalonia.Controls.SelectionMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionModeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectionMode<T>(this T control, Func<ValueTask<Avalonia.Controls.SelectionMode>> getter, Func<Avalonia.Controls.SelectionMode>? fallbackGetter = null, Action<Avalonia.Controls.SelectionMode>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionModeProperty!, getter, fallbackGetter, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectionMode<T>(this T control,Avalonia.Controls.SelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ListBox 
=> control._setEx(Avalonia.Controls.ListBox.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectionMode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.SelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ListBox 
=> control._setEx(Avalonia.Controls.ListBox.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // SelectionMode

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.ListBox 
=> style._addSetter(Avalonia.Controls.ListBox.SelectionModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ListBox 
=> style._addSetter(Avalonia.Controls.ListBox.SelectionModeProperty, binding);



}
