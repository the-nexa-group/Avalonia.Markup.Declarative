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
public static partial class TextBox_MarkupExtensions
{
//================= Properties ======================//
 // IsInactiveSelectionHighlightEnabled

/*ValueSetterGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.IsInactiveSelectionHighlightEnabled = value);

/*BindFromExpressionSetterGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ClearSelectionOnLostFocus

/*ValueSetterGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.ClearSelectionOnLostFocus = value);

/*BindFromExpressionSetterGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // AcceptsReturn

/*ValueSetterGenerator*/
public static T AcceptsReturn<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.AcceptsReturn = value);

/*BindFromExpressionSetterGenerator*/
public static T AcceptsReturn<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsReturnProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T AcceptsReturn<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsReturnProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T AcceptsReturn<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsReturnProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AcceptsReturn<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsReturnProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // AcceptsTab

/*ValueSetterGenerator*/
public static T AcceptsTab<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.AcceptsTab = value);

/*BindFromExpressionSetterGenerator*/
public static T AcceptsTab<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsTabProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T AcceptsTab<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsTabProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T AcceptsTab<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsTabProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AcceptsTab<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsTabProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CaretIndex

/*ValueSetterGenerator*/
public static T CaretIndex<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.CaretIndex = value);

/*BindFromExpressionSetterGenerator*/
public static T CaretIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretIndexProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CaretIndex<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretIndexProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CaretIndex<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretIndexProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsReadOnly

/*ValueSetterGenerator*/
public static T IsReadOnly<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.IsReadOnly = value);

/*BindFromExpressionSetterGenerator*/
public static T IsReadOnly<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsReadOnlyProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsReadOnly<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsReadOnlyProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsReadOnly<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsReadOnlyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsReadOnly<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsReadOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PasswordChar

/*ValueSetterGenerator*/
public static T PasswordChar<T>(this T control, System.Char value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.PasswordChar = value);

/*BindFromExpressionSetterGenerator*/
public static T PasswordChar<T>(this T control, Func<System.Char> func, Action<System.Char>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.PasswordCharProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PasswordChar<T>(this T control, Func<ValueTask<System.Char>> getter, Func<System.Char>? fallbackGetter = null, Action<System.Char>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.PasswordCharProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PasswordChar<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.PasswordCharProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PasswordChar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.PasswordCharProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectionBrush

/*ValueSetterGenerator*/
public static T SelectionBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.SelectionBrush = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionBrushProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectionBrush<T>(this T control, Func<ValueTask<Avalonia.Media.IBrush?>> getter, Func<Avalonia.Media.IBrush?>? fallbackGetter = null, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionBrushProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectionBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectionForegroundBrush

/*ValueSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.SelectionForegroundBrush = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Func<ValueTask<Avalonia.Media.IBrush?>> getter, Func<Avalonia.Media.IBrush?>? fallbackGetter = null, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CaretBrush

/*ValueSetterGenerator*/
public static T CaretBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.CaretBrush = value);

/*BindFromExpressionSetterGenerator*/
public static T CaretBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBrushProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CaretBrush<T>(this T control, Func<ValueTask<Avalonia.Media.IBrush?>> getter, Func<Avalonia.Media.IBrush?>? fallbackGetter = null, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBrushProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CaretBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CaretBlinkInterval

/*ValueSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.CaretBlinkInterval = value);

/*BindFromExpressionSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, Func<ValueTask<System.TimeSpan>> getter, Func<System.TimeSpan>? fallbackGetter = null, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectionStart

/*ValueSetterGenerator*/
public static T SelectionStart<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.SelectionStart = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectionStart<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionStartProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectionStart<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionStartProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectionStart<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionStartProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionStartProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectionEnd

/*ValueSetterGenerator*/
public static T SelectionEnd<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.SelectionEnd = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectionEnd<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionEndProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectionEnd<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionEndProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectionEnd<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionEndProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionEndProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MaxLength

/*ValueSetterGenerator*/
public static T MaxLength<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.MaxLength = value);

/*BindFromExpressionSetterGenerator*/
public static T MaxLength<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLengthProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MaxLength<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLengthProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MaxLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLengthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MaxLines

/*ValueSetterGenerator*/
public static T MaxLines<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.MaxLines = value);

/*BindFromExpressionSetterGenerator*/
public static T MaxLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLinesProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MaxLines<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLinesProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MaxLines<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MinLines

/*ValueSetterGenerator*/
public static T MinLines<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.MinLines = value);

/*BindFromExpressionSetterGenerator*/
public static T MinLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MinLinesProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MinLines<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MinLinesProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MinLines<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MinLinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MinLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String? value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.Text = value);

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Text<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // TextAlignment

/*ValueSetterGenerator*/
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.TextAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<ValueTask<Avalonia.Media.TextAlignment>> getter, Func<Avalonia.Media.TextAlignment>? fallbackGetter = null, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T TextAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.HorizontalContentAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<ValueTask<Avalonia.Layout.HorizontalAlignment>> getter, Func<Avalonia.Layout.HorizontalAlignment>? fallbackGetter = null, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.VerticalContentAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<ValueTask<Avalonia.Layout.VerticalAlignment>> getter, Func<Avalonia.Layout.VerticalAlignment>? fallbackGetter = null, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // TextWrapping

/*ValueSetterGenerator*/
public static T TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.TextWrapping = value);

/*BindFromExpressionSetterGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextWrappingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T TextWrapping<T>(this T control, Func<ValueTask<Avalonia.Media.TextWrapping>> getter, Func<Avalonia.Media.TextWrapping>? fallbackGetter = null, Action<Avalonia.Media.TextWrapping>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextWrappingProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T TextWrapping<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextWrappingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextWrapping<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // LineHeight

/*ValueSetterGenerator*/
public static T LineHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.LineHeight = value);

/*BindFromExpressionSetterGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LineHeightProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T LineHeight<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LineHeightProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T LineHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LineHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LineHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // LetterSpacing

/*ValueSetterGenerator*/
public static T LetterSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.LetterSpacing = value);

/*BindFromExpressionSetterGenerator*/
public static T LetterSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LetterSpacingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T LetterSpacing<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LetterSpacingProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T LetterSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LetterSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LetterSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LetterSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String? value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.Watermark = value);

/*BindFromExpressionSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.WatermarkProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Watermark<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.WatermarkProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Watermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.WatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // UseFloatingWatermark

/*ValueSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.UseFloatingWatermark = value);

/*BindFromExpressionSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // NewLine

/*ValueSetterGenerator*/
public static T NewLine<T>(this T control, System.String value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.NewLine = value);

/*BindFromExpressionSetterGenerator*/
public static T NewLine<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.NewLineProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T NewLine<T>(this T control, Func<ValueTask<System.String>> getter, Func<System.String>? fallbackGetter = null, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.NewLineProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T NewLine<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.NewLineProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T NewLine<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.NewLineProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // InnerLeftContent

/*ValueSetterGenerator*/
public static T InnerLeftContent<T>(this T control, System.Object? value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.InnerLeftContent = value);

/*BindFromExpressionSetterGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerLeftContentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T InnerLeftContent<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerLeftContentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerLeftContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // InnerRightContent

/*ValueSetterGenerator*/
public static T InnerRightContent<T>(this T control, System.Object? value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.InnerRightContent = value);

/*BindFromExpressionSetterGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerRightContentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T InnerRightContent<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerRightContentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T InnerRightContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerRightContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerRightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // RevealPassword

/*ValueSetterGenerator*/
public static T RevealPassword<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.RevealPassword = value);

/*BindFromExpressionSetterGenerator*/
public static T RevealPassword<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.RevealPasswordProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T RevealPassword<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.RevealPasswordProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T RevealPassword<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.RevealPasswordProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RevealPassword<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.RevealPasswordProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsUndoEnabled

/*ValueSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.IsUndoEnabled = value);

/*BindFromExpressionSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsUndoEnabledProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsUndoEnabledProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsUndoEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsUndoEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // UndoLimit

/*ValueSetterGenerator*/
public static T UndoLimit<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.UndoLimit = value);

/*BindFromExpressionSetterGenerator*/
public static T UndoLimit<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UndoLimitProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T UndoLimit<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UndoLimitProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T UndoLimit<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UndoLimitProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UndoLimit<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UndoLimitProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // CopyingToClipboard

/*ActionToEventGenerator*/
public static T OnCopyingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.CopyingToClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.CopyingToClipboardEvent.RoutingStrategies);
  return control;
}



 // CuttingToClipboard

/*ActionToEventGenerator*/
public static T OnCuttingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.CuttingToClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.CuttingToClipboardEvent.RoutingStrategies);
  return control;
}



 // PastingFromClipboard

/*ActionToEventGenerator*/
public static T OnPastingFromClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.PastingFromClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.PastingFromClipboardEvent.RoutingStrategies);
  return control;
}



 // TextChanged

/*ActionToEventGenerator*/
public static T OnTextChanged<T>(this T control, Action<Avalonia.Controls.TextChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.TextChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.TextChangedEvent.RoutingStrategies);
  return control;
}



 // TextChanging

/*ActionToEventGenerator*/
public static T OnTextChanging<T>(this T control, Action<Avalonia.Controls.TextChangingEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.TextChangingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.TextChangingEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsInactiveSelectionHighlightEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsInactiveSelectionHighlightEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsInactiveSelectionHighlightEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty, binding);


 // ClearSelectionOnLostFocus

/*ValueStyleSetterGenerator*/
public static Style<T> ClearSelectionOnLostFocus<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClearSelectionOnLostFocus<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty, binding);


 // AcceptsReturn

/*ValueStyleSetterGenerator*/
public static Style<T> AcceptsReturn<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsReturnProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AcceptsReturn<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsReturnProperty, binding);


 // AcceptsTab

/*ValueStyleSetterGenerator*/
public static Style<T> AcceptsTab<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsTabProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AcceptsTab<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsTabProperty, binding);


 // CaretIndex

/*ValueStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretIndexProperty, binding);


 // IsReadOnly

/*ValueStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsReadOnlyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsReadOnlyProperty, binding);


 // PasswordChar

/*ValueStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.PasswordCharProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.PasswordCharProperty, binding);


 // SelectionBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionBrushProperty, binding);


 // SelectionForegroundBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, binding);


 // CaretBrush

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBrushProperty, binding);


 // CaretBlinkInterval

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, binding);


 // SelectionStart

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionStartProperty, binding);


 // SelectionEnd

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionEndProperty, binding);


 // MaxLength

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLengthProperty, binding);


 // MaxLines

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLinesProperty, binding);


 // MinLines

/*ValueStyleSetterGenerator*/
public static Style<T> MinLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MinLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MinLinesProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextAlignmentProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, binding);


 // TextWrapping

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextWrappingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextWrappingProperty, binding);


 // LineHeight

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LineHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LineHeightProperty, binding);


 // LetterSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LetterSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LetterSpacingProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.WatermarkProperty, binding);


 // UseFloatingWatermark

/*ValueStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, binding);


 // NewLine

/*ValueStyleSetterGenerator*/
public static Style<T> NewLine<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.NewLineProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NewLine<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.NewLineProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerLeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerRightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerRightContentProperty, binding);


 // RevealPassword

/*ValueStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.RevealPasswordProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.RevealPasswordProperty, binding);


 // IsUndoEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsUndoEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsUndoEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsUndoEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsUndoEnabledProperty, binding);


 // UndoLimit

/*ValueStyleSetterGenerator*/
public static Style<T> UndoLimit<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UndoLimitProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UndoLimit<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UndoLimitProperty, binding);



}
