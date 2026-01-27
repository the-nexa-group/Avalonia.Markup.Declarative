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
public static partial class GradientBrush_MarkupExtensions
{
//================= Properties ======================//
 // SpreadMethod

/*ValueSetterGenerator*/
public static T SpreadMethod<T>(this T control, Avalonia.Media.GradientSpreadMethod value) where T : Avalonia.Media.GradientBrush 
=> control._set(() => control.SpreadMethod = value);

/*BindFromExpressionSetterGenerator*/
public static T SpreadMethod<T>(this T control, Func<Avalonia.Media.GradientSpreadMethod> func, Action<Avalonia.Media.GradientSpreadMethod>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.SpreadMethodProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SpreadMethod<T>(this T control, Func<ValueTask<Avalonia.Media.GradientSpreadMethod>> getter, Func<Avalonia.Media.GradientSpreadMethod>? fallbackGetter = null, Action<Avalonia.Media.GradientSpreadMethod>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.SpreadMethodProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SpreadMethod<T>(this T control, IBinding binding) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.SpreadMethodProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SpreadMethod<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.SpreadMethodProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // GradientStops

/*ValueSetterGenerator*/
public static T GradientStops<T>(this T control, Avalonia.Media.GradientStops value) where T : Avalonia.Media.GradientBrush 
=> control._set(() => control.GradientStops = value);

/*BindFromExpressionSetterGenerator*/
public static T GradientStops<T>(this T control, Func<Avalonia.Media.GradientStops> func, Action<Avalonia.Media.GradientStops>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.GradientStopsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T GradientStops<T>(this T control, Func<ValueTask<Avalonia.Media.GradientStops>> getter, Func<Avalonia.Media.GradientStops>? fallbackGetter = null, Action<Avalonia.Media.GradientStops>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.GradientStopsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T GradientStops<T>(this T control, IBinding binding) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.GradientStopsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T GradientStops<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.GradientStopsProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
