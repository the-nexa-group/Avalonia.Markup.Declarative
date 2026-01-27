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
public static partial class TimePickerPresenter_MarkupExtensions
{
//================= Properties ======================//
 // MinuteIncrement

/*ValueSetterGenerator*/
public static T MinuteIncrement<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
=> control._set(() => control.MinuteIncrement = value);

/*BindFromExpressionSetterGenerator*/
public static T MinuteIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MinuteIncrement<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MinuteIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinuteIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SecondIncrement

/*ValueSetterGenerator*/
public static T SecondIncrement<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
=> control._set(() => control.SecondIncrement = value);

/*BindFromExpressionSetterGenerator*/
public static T SecondIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SecondIncrement<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SecondIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SecondIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ClockIdentifier

/*ValueSetterGenerator*/
public static T ClockIdentifier<T>(this T control, System.String value) where T : Avalonia.Controls.TimePickerPresenter 
=> control._set(() => control.ClockIdentifier = value);

/*BindFromExpressionSetterGenerator*/
public static T ClockIdentifier<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ClockIdentifier<T>(this T control, Func<ValueTask<System.String>> getter, Func<System.String>? fallbackGetter = null, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ClockIdentifier<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClockIdentifier<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // UseSeconds

/*ValueSetterGenerator*/
public static T UseSeconds<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TimePickerPresenter 
=> control._set(() => control.UseSeconds = value);

/*BindFromExpressionSetterGenerator*/
public static T UseSeconds<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T UseSeconds<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T UseSeconds<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseSeconds<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Time

/*ValueSetterGenerator*/
public static T Time<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.TimePickerPresenter 
=> control._set(() => control.Time = value);

/*BindFromExpressionSetterGenerator*/
public static T Time<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.TimeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Time<T>(this T control, Func<ValueTask<System.TimeSpan>> getter, Func<System.TimeSpan>? fallbackGetter = null, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.TimeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Time<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.TimeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Time<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.TimeProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // MinuteIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, binding);


 // SecondIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty, binding);


 // ClockIdentifier

/*ValueStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, binding);


 // UseSeconds

/*ValueStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty, binding);


 // Time

/*ValueStyleSetterGenerator*/
public static Style<T> Time<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.TimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Time<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.TimeProperty, binding);



}
