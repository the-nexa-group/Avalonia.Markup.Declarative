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
public static partial class CalendarDatePicker_MarkupExtensions
{
//================= Properties ======================//
 // DisplayDate

/*ValueSetterGenerator*/
public static T DisplayDate<T>(this T control, System.DateTime value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.DisplayDate = value);

/*BindFromExpressionSetterGenerator*/
public static T DisplayDate<T>(this T control, Func<System.DateTime> func, Action<System.DateTime>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DisplayDate<T>(this T control, Func<ValueTask<System.DateTime>> getter, Func<System.DateTime>? fallbackGetter = null, Action<System.DateTime>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T DisplayDate<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // DisplayDateStart

/*ValueSetterGenerator*/
public static T DisplayDateStart<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.DisplayDateStart = value);

/*BindFromExpressionSetterGenerator*/
public static T DisplayDateStart<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DisplayDateStart<T>(this T control, Func<ValueTask<System.Nullable<System.DateTime>>> getter, Func<System.Nullable<System.DateTime>>? fallbackGetter = null, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T DisplayDateStart<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayDateStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // DisplayDateEnd

/*ValueSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.DisplayDateEnd = value);

/*BindFromExpressionSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, Func<ValueTask<System.Nullable<System.DateTime>>> getter, Func<System.Nullable<System.DateTime>>? fallbackGetter = null, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // FirstDayOfWeek

/*ValueSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, System.DayOfWeek value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.FirstDayOfWeek = value);

/*BindFromExpressionSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, Func<System.DayOfWeek> func, Action<System.DayOfWeek>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, Func<ValueTask<System.DayOfWeek>> getter, Func<System.DayOfWeek>? fallbackGetter = null, Action<System.DayOfWeek>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsDropDownOpen

/*ValueSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.IsDropDownOpen = value);

/*BindFromExpressionSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsTodayHighlighted

/*ValueSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.IsTodayHighlighted = value);

/*BindFromExpressionSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectedDate

/*ValueSetterGenerator*/
public static T SelectedDate<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.SelectedDate = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectedDate<T>(this T control, Func<ValueTask<System.Nullable<System.DateTime>>> getter, Func<System.Nullable<System.DateTime>>? fallbackGetter = null, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectedDate<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectedDateFormat

/*ValueSetterGenerator*/
public static T SelectedDateFormat<T>(this T control, Avalonia.Controls.CalendarDatePickerFormat value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.SelectedDateFormat = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectedDateFormat<T>(this T control, Func<Avalonia.Controls.CalendarDatePickerFormat> func, Action<Avalonia.Controls.CalendarDatePickerFormat>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectedDateFormat<T>(this T control, Func<ValueTask<Avalonia.Controls.CalendarDatePickerFormat>> getter, Func<Avalonia.Controls.CalendarDatePickerFormat>? fallbackGetter = null, Action<Avalonia.Controls.CalendarDatePickerFormat>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectedDateFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedDateFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CustomDateFormatString

/*ValueSetterGenerator*/
public static T CustomDateFormatString<T>(this T control, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.CustomDateFormatString = value);

/*BindFromExpressionSetterGenerator*/
public static T CustomDateFormatString<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CustomDateFormatString<T>(this T control, Func<ValueTask<System.String>> getter, Func<System.String>? fallbackGetter = null, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CustomDateFormatString<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CustomDateFormatString<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String? value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.Text = value);

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.TextProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Text<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.TextProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String? value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.Watermark = value);

/*BindFromExpressionSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.WatermarkProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Watermark<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.WatermarkProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Watermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // UseFloatingWatermark

/*ValueSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.UseFloatingWatermark = value);

/*BindFromExpressionSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.HorizontalContentAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<ValueTask<Avalonia.Layout.HorizontalAlignment>> getter, Func<Avalonia.Layout.HorizontalAlignment>? fallbackGetter = null, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.VerticalContentAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<ValueTask<Avalonia.Layout.VerticalAlignment>> getter, Func<Avalonia.Layout.VerticalAlignment>? fallbackGetter = null, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // CalendarClosed

/*ActionToEventGenerator*/
public static T OnCalendarClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.CalendarDatePicker  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CalendarClosed += h);


 // CalendarOpened

/*ActionToEventGenerator*/
public static T OnCalendarOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.CalendarDatePicker  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CalendarOpened += h);


 // DateValidationError

/*ActionToEventGenerator*/
public static T OnDateValidationError<T>(this T control, Action<Avalonia.Controls.CalendarDatePickerDateValidationErrorEventArgs> action) where T : Avalonia.Controls.CalendarDatePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.CalendarDatePickerDateValidationErrorEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DateValidationError += h);


 // SelectedDateChanged

/*ActionToEventGenerator*/
public static T OnSelectedDateChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.CalendarDatePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedDateChanged += h);



//================= Styles ======================//
 // DisplayDate

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, System.DateTime value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, binding);


 // DisplayDateStart

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, binding);


 // DisplayDateEnd

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, binding);


 // FirstDayOfWeek

/*ValueStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, System.DayOfWeek value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, binding);


 // IsDropDownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, binding);


 // IsTodayHighlighted

/*ValueStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, binding);


 // SelectedDate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, binding);


 // SelectedDateFormat

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDateFormat<T>(this Style<T> style, Avalonia.Controls.CalendarDatePickerFormat value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDateFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, binding);


 // CustomDateFormatString

/*ValueStyleSetterGenerator*/
public static Style<T> CustomDateFormatString<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CustomDateFormatString<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.TextProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, binding);


 // UseFloatingWatermark

/*ValueStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, binding);



}
