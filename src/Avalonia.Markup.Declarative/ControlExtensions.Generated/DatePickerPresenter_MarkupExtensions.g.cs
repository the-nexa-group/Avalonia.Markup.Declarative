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
public static partial class DatePickerPresenter_MarkupExtensions
{
//================= Properties ======================//
 // Date

/*ValueSetterGenerator*/
public static T Date<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.Date = value);

/*BindFromExpressionSetterGenerator*/
public static T Date<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Date<T>(this T control, Func<ValueTask<System.DateTimeOffset>> getter, Func<System.DateTimeOffset>? fallbackGetter = null, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Date<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Date<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // DayFormat

/*ValueSetterGenerator*/
public static T DayFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.DayFormat = value);

/*BindFromExpressionSetterGenerator*/
public static T DayFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DayFormat<T>(this T control, Func<ValueTask<System.String>> getter, Func<System.String>? fallbackGetter = null, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T DayFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DayFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // DayVisible

/*ValueSetterGenerator*/
public static T DayVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.DayVisible = value);

/*BindFromExpressionSetterGenerator*/
public static T DayVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DayVisible<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T DayVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DayVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MaxYear

/*ValueSetterGenerator*/
public static T MaxYear<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.MaxYear = value);

/*BindFromExpressionSetterGenerator*/
public static T MaxYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MaxYear<T>(this T control, Func<ValueTask<System.DateTimeOffset>> getter, Func<System.DateTimeOffset>? fallbackGetter = null, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MaxYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MinYear

/*ValueSetterGenerator*/
public static T MinYear<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.MinYear = value);

/*BindFromExpressionSetterGenerator*/
public static T MinYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MinYear<T>(this T control, Func<ValueTask<System.DateTimeOffset>> getter, Func<System.DateTimeOffset>? fallbackGetter = null, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MinYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MonthFormat

/*ValueSetterGenerator*/
public static T MonthFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.MonthFormat = value);

/*BindFromExpressionSetterGenerator*/
public static T MonthFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MonthFormat<T>(this T control, Func<ValueTask<System.String>> getter, Func<System.String>? fallbackGetter = null, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MonthFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MonthFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MonthVisible

/*ValueSetterGenerator*/
public static T MonthVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.MonthVisible = value);

/*BindFromExpressionSetterGenerator*/
public static T MonthVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MonthVisible<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MonthVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MonthVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // YearFormat

/*ValueSetterGenerator*/
public static T YearFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.YearFormat = value);

/*BindFromExpressionSetterGenerator*/
public static T YearFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T YearFormat<T>(this T control, Func<ValueTask<System.String>> getter, Func<System.String>? fallbackGetter = null, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T YearFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T YearFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // YearVisible

/*ValueSetterGenerator*/
public static T YearVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.YearVisible = value);

/*BindFromExpressionSetterGenerator*/
public static T YearVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T YearVisible<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T YearVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T YearVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Date

/*ValueStyleSetterGenerator*/
public static Style<T> Date<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Date<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DateProperty, binding);


 // DayFormat

/*ValueStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, binding);


 // DayVisible

/*ValueStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, binding);


 // MaxYear

/*ValueStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MaxYearProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, binding);


 // MinYear

/*ValueStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MinYearProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MinYearProperty, binding);


 // MonthFormat

/*ValueStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, binding);


 // MonthVisible

/*ValueStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, binding);


 // YearFormat

/*ValueStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, binding);


 // YearVisible

/*ValueStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, binding);



}
