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
public static partial class PathGeometry_MarkupExtensions
{
//================= Properties ======================//
 // Figures

/*ValueSetterGenerator*/
public static T Figures<T>(this T control, Avalonia.Media.PathFigures? value) where T : Avalonia.Media.PathGeometry 
=> control._set(() => control.Figures = value);

/*BindFromExpressionSetterGenerator*/
public static T Figures<T>(this T control, Func<Avalonia.Media.PathFigures?> func, Action<Avalonia.Media.PathFigures?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FiguresProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Figures<T>(this T control, Func<ValueTask<Avalonia.Media.PathFigures?>> getter, Func<Avalonia.Media.PathFigures?>? fallbackGetter = null, Action<Avalonia.Media.PathFigures?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FiguresProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Figures<T>(this T control, IBinding binding) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FiguresProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Figures<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FiguresProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // FillRule

/*ValueSetterGenerator*/
public static T FillRule<T>(this T control, Avalonia.Media.FillRule value) where T : Avalonia.Media.PathGeometry 
=> control._set(() => control.FillRule = value);

/*BindFromExpressionSetterGenerator*/
public static T FillRule<T>(this T control, Func<Avalonia.Media.FillRule> func, Action<Avalonia.Media.FillRule>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FillRuleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T FillRule<T>(this T control, Func<ValueTask<Avalonia.Media.FillRule>> getter, Func<Avalonia.Media.FillRule>? fallbackGetter = null, Action<Avalonia.Media.FillRule>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FillRuleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T FillRule<T>(this T control, IBinding binding) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FillRuleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FillRule<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FillRuleProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
