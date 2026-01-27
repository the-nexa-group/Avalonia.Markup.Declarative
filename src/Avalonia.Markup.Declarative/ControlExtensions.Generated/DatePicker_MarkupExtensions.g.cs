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
public static partial class DatePicker_MarkupExtensions
{
//================= Properties ======================//
 // DayFormat

/*ValueSetterGenerator*/
public static T DayFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.DayFormat = value);

/*BindFromExpressionSetterGenerator*/
public static T DayFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayFormatProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DayFormat<T>(this T control, Func<ValueTask<System.String>> getter, Func<System.String>? fallbackGetter = null, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayFormatProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T DayFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DayFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // DayVisible

/*ValueSetterGenerator*/
public static T DayVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.DayVisible = value);

/*BindFromExpressionSetterGenerator*/
public static T DayVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayVisibleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DayVisible<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayVisibleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T DayVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DayVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MaxYear

/*ValueSetterGenerator*/
public static T MaxYear<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.MaxYear = value);

/*BindFromExpressionSetterGenerator*/
public static T MaxYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MaxYearProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MaxYear<T>(this T control, Func<ValueTask<System.DateTimeOffset>> getter, Func<System.DateTimeOffset>? fallbackGetter = null, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MaxYearProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MaxYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MaxYearProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MaxYearProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MinYear

/*ValueSetterGenerator*/
public static T MinYear<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.MinYear = value);

/*BindFromExpressionSetterGenerator*/
public static T MinYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MinYearProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MinYear<T>(this T control, Func<ValueTask<System.DateTimeOffset>> getter, Func<System.DateTimeOffset>? fallbackGetter = null, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MinYearProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MinYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MinYearProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MinYearProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MonthFormat

/*ValueSetterGenerator*/
public static T MonthFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.MonthFormat = value);

/*BindFromExpressionSetterGenerator*/
public static T MonthFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthFormatProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MonthFormat<T>(this T control, Func<ValueTask<System.String>> getter, Func<System.String>? fallbackGetter = null, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthFormatProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MonthFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MonthFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MonthVisible

/*ValueSetterGenerator*/
public static T MonthVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.MonthVisible = value);

/*BindFromExpressionSetterGenerator*/
public static T MonthVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthVisibleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MonthVisible<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthVisibleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MonthVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MonthVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // YearFormat

/*ValueSetterGenerator*/
public static T YearFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.YearFormat = value);

/*BindFromExpressionSetterGenerator*/
public static T YearFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearFormatProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T YearFormat<T>(this T control, Func<ValueTask<System.String>> getter, Func<System.String>? fallbackGetter = null, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearFormatProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T YearFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T YearFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // YearVisible

/*ValueSetterGenerator*/
public static T YearVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.YearVisible = value);

/*BindFromExpressionSetterGenerator*/
public static T YearVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearVisibleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T YearVisible<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearVisibleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T YearVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T YearVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectedDate

/*ValueSetterGenerator*/
public static T SelectedDate<T>(this T control, System.Nullable<System.DateTimeOffset> value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.SelectedDate = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTimeOffset>> func, Action<System.Nullable<System.DateTimeOffset>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.SelectedDateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectedDate<T>(this T control, Func<ValueTask<System.Nullable<System.DateTimeOffset>>> getter, Func<System.Nullable<System.DateTimeOffset>>? fallbackGetter = null, Action<System.Nullable<System.DateTimeOffset>>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.SelectedDateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectedDate<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.SelectedDateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // SelectedDateChanged

/*ActionToEventGenerator*/
public static T OnSelectedDateChanged<T>(this T control, Action<Avalonia.Controls.DatePickerSelectedValueChangedEventArgs> action) where T : Avalonia.Controls.DatePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.DatePickerSelectedValueChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedDateChanged += h);



//================= Styles ======================//
 // DayFormat

/*ValueStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayFormatProperty, binding);


 // DayVisible

/*ValueStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayVisibleProperty, binding);


 // MaxYear

/*ValueStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MaxYearProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MaxYearProperty, binding);


 // MinYear

/*ValueStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MinYearProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MinYearProperty, binding);


 // MonthFormat

/*ValueStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthFormatProperty, binding);


 // MonthVisible

/*ValueStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthVisibleProperty, binding);


 // YearFormat

/*ValueStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearFormatProperty, binding);


 // YearVisible

/*ValueStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearVisibleProperty, binding);


 // SelectedDate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTimeOffset> value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.SelectedDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.SelectedDateProperty, binding);



}
