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
public static partial class ColumnDefinition_MarkupExtensions
{
//================= Properties ======================//
 // MaxWidth

/*ValueSetterGenerator*/
public static T MaxWidth<T>(this T control, System.Double value) where T : Avalonia.Controls.ColumnDefinition 
=> control._set(() => control.MaxWidth = value);

/*BindFromExpressionSetterGenerator*/
public static T MaxWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MaxWidthProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MaxWidth<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MaxWidthProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MaxWidth<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MaxWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MaxWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MinWidth

/*ValueSetterGenerator*/
public static T MinWidth<T>(this T control, System.Double value) where T : Avalonia.Controls.ColumnDefinition 
=> control._set(() => control.MinWidth = value);

/*BindFromExpressionSetterGenerator*/
public static T MinWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MinWidthProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MinWidth<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MinWidthProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MinWidth<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MinWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MinWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Width

/*ValueSetterGenerator*/
public static T Width<T>(this T control, Avalonia.Controls.GridLength value) where T : Avalonia.Controls.ColumnDefinition 
=> control._set(() => control.Width = value);

/*BindFromExpressionSetterGenerator*/
public static T Width<T>(this T control, Func<Avalonia.Controls.GridLength> func, Action<Avalonia.Controls.GridLength>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.WidthProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Width<T>(this T control, Func<ValueTask<Avalonia.Controls.GridLength>> getter, Func<Avalonia.Controls.GridLength>? fallbackGetter = null, Action<Avalonia.Controls.GridLength>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.WidthProperty!, getter, fallbackGetter, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T Width<T>(this T control, System.Double value = default!) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(() => control.Width = new Avalonia.Controls.GridLength(value));
public static T Width<T>(this T control, System.Double value = default!, Avalonia.Controls.GridUnitType type = default!) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(() => control.Width = new Avalonia.Controls.GridLength(value, type));

/*BindSetterGenerator*/
public static T Width<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.WidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Width<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.WidthProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
