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
public static partial class TimePicker_MarkupExtensions
{
//================= Properties ======================//
 // MinuteIncrement

/*ValueSetterGenerator*/
public static T MinuteIncrement<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TimePicker 
=> control._set(() => control.MinuteIncrement = value);

/*BindFromExpressionSetterGenerator*/
public static T MinuteIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MinuteIncrement<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MinuteIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinuteIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SecondIncrement

/*ValueSetterGenerator*/
public static T SecondIncrement<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TimePicker 
=> control._set(() => control.SecondIncrement = value);

/*BindFromExpressionSetterGenerator*/
public static T SecondIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SecondIncrementProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SecondIncrement<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SecondIncrementProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SecondIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SecondIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SecondIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SecondIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ClockIdentifier

/*ValueSetterGenerator*/
public static T ClockIdentifier<T>(this T control, System.String value) where T : Avalonia.Controls.TimePicker 
=> control._set(() => control.ClockIdentifier = value);

/*BindFromExpressionSetterGenerator*/
public static T ClockIdentifier<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ClockIdentifier<T>(this T control, Func<ValueTask<System.String>> getter, Func<System.String>? fallbackGetter = null, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ClockIdentifier<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClockIdentifier<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // UseSeconds

/*ValueSetterGenerator*/
public static T UseSeconds<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TimePicker 
=> control._set(() => control.UseSeconds = value);

/*BindFromExpressionSetterGenerator*/
public static T UseSeconds<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.UseSecondsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T UseSeconds<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.UseSecondsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T UseSeconds<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.UseSecondsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseSeconds<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.UseSecondsProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectedTime

/*ValueSetterGenerator*/
public static T SelectedTime<T>(this T control, System.Nullable<System.TimeSpan> value) where T : Avalonia.Controls.TimePicker 
=> control._set(() => control.SelectedTime = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectedTime<T>(this T control, Func<System.Nullable<System.TimeSpan>> func, Action<System.Nullable<System.TimeSpan>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectedTime<T>(this T control, Func<ValueTask<System.Nullable<System.TimeSpan>>> getter, Func<System.Nullable<System.TimeSpan>>? fallbackGetter = null, Action<System.Nullable<System.TimeSpan>>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectedTime<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedTime<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // SelectedTimeChanged

/*ActionToEventGenerator*/
public static T OnSelectedTimeChanged<T>(this T control, Action<Avalonia.Controls.TimePickerSelectedValueChangedEventArgs> action) where T : Avalonia.Controls.TimePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.TimePickerSelectedValueChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedTimeChanged += h);



//================= Styles ======================//
 // MinuteIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.MinuteIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.MinuteIncrementProperty, binding);


 // SecondIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SecondIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SecondIncrementProperty, binding);


 // ClockIdentifier

/*ValueStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.ClockIdentifierProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.ClockIdentifierProperty, binding);


 // UseSeconds

/*ValueStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.UseSecondsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.UseSecondsProperty, binding);


 // SelectedTime

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedTime<T>(this Style<T> style, System.Nullable<System.TimeSpan> value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SelectedTimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedTime<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SelectedTimeProperty, binding);



}
