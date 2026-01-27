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
public static partial class MaskedTextBox_MarkupExtensions
{
//================= Properties ======================//
 // AsciiOnly

/*ValueSetterGenerator*/
public static T AsciiOnly<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.AsciiOnly = value);

/*BindFromExpressionSetterGenerator*/
public static T AsciiOnly<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T AsciiOnly<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T AsciiOnly<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AsciiOnly<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Culture

/*ValueSetterGenerator*/
public static T Culture<T>(this T control, System.Globalization.CultureInfo? value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.Culture = value);

/*BindFromExpressionSetterGenerator*/
public static T Culture<T>(this T control, Func<System.Globalization.CultureInfo?> func, Action<System.Globalization.CultureInfo?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.CultureProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Culture<T>(this T control, Func<ValueTask<System.Globalization.CultureInfo?>> getter, Func<System.Globalization.CultureInfo?>? fallbackGetter = null, Action<System.Globalization.CultureInfo?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.CultureProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Culture<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.CultureProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Culture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.CultureProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HidePromptOnLeave

/*ValueSetterGenerator*/
public static T HidePromptOnLeave<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.HidePromptOnLeave = value);

/*BindFromExpressionSetterGenerator*/
public static T HidePromptOnLeave<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HidePromptOnLeave<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HidePromptOnLeave<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HidePromptOnLeave<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Mask

/*ValueSetterGenerator*/
public static T Mask<T>(this T control, System.String? value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.Mask = value);

/*BindFromExpressionSetterGenerator*/
public static T Mask<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.MaskProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Mask<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.MaskProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Mask<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.MaskProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Mask<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.MaskProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PromptChar

/*ValueSetterGenerator*/
public static T PromptChar<T>(this T control, System.Char value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.PromptChar = value);

/*BindFromExpressionSetterGenerator*/
public static T PromptChar<T>(this T control, Func<System.Char> func, Action<System.Char>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.PromptCharProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PromptChar<T>(this T control, Func<ValueTask<System.Char>> getter, Func<System.Char>? fallbackGetter = null, Action<System.Char>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.PromptCharProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PromptChar<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.PromptCharProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PromptChar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.PromptCharProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ResetOnPrompt

/*ValueSetterGenerator*/
public static T ResetOnPrompt<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.ResetOnPrompt = value);

/*BindFromExpressionSetterGenerator*/
public static T ResetOnPrompt<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ResetOnPrompt<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ResetOnPrompt<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ResetOnPrompt<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ResetOnSpace

/*ValueSetterGenerator*/
public static T ResetOnSpace<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.ResetOnSpace = value);

/*BindFromExpressionSetterGenerator*/
public static T ResetOnSpace<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ResetOnSpace<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ResetOnSpace<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ResetOnSpace<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // AsciiOnly

/*ValueStyleSetterGenerator*/
public static Style<T> AsciiOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AsciiOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, binding);


 // Culture

/*ValueStyleSetterGenerator*/
public static Style<T> Culture<T>(this Style<T> style, System.Globalization.CultureInfo? value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.CultureProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Culture<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.CultureProperty, binding);


 // HidePromptOnLeave

/*ValueStyleSetterGenerator*/
public static Style<T> HidePromptOnLeave<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HidePromptOnLeave<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, binding);


 // Mask

/*ValueStyleSetterGenerator*/
public static Style<T> Mask<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.MaskProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Mask<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.MaskProperty, binding);


 // PromptChar

/*ValueStyleSetterGenerator*/
public static Style<T> PromptChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.PromptCharProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PromptChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.PromptCharProperty, binding);


 // ResetOnPrompt

/*ValueStyleSetterGenerator*/
public static Style<T> ResetOnPrompt<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResetOnPrompt<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, binding);


 // ResetOnSpace

/*ValueStyleSetterGenerator*/
public static Style<T> ResetOnSpace<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResetOnSpace<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, binding);



}
