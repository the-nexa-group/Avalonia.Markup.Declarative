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
public static partial class CalendarItem_MarkupExtensions
{
//================= Properties ======================//
 // HeaderBackground

/*ValueSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, Avalonia.Media.IBrush? value)  
=> control._set(() => control.HeaderBackground = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, Func<Avalonia.Media.IBrush?> func, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, Func<ValueTask<Avalonia.Media.IBrush?>> getter, Func<Avalonia.Media.IBrush?>? fallbackGetter = null, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, IBinding binding)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // DayTitleTemplate

/*ValueSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control>? value)  
=> control._set(() => control.DayTitleTemplate = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>?> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, Func<ValueTask<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>?>> getter, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>?>? fallbackGetter = null, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, IBinding binding)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // HeaderBackground

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> HeaderBackground(this Style<Avalonia.Controls.Primitives.CalendarItem> style, Avalonia.Media.IBrush? value)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> HeaderBackground(this Style<Avalonia.Controls.Primitives.CalendarItem> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, binding);


 // DayTitleTemplate

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> DayTitleTemplate(this Style<Avalonia.Controls.Primitives.CalendarItem> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control>? value)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> DayTitleTemplate(this Style<Avalonia.Controls.Primitives.CalendarItem> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, binding);



}
