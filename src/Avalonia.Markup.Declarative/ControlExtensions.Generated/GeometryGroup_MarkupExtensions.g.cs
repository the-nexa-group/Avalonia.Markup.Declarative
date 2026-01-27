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
public static partial class GeometryGroup_MarkupExtensions
{
//================= Properties ======================//
 // Children

/*ValueSetterGenerator*/
public static T Children<T>(this T control, Avalonia.Media.GeometryCollection value) where T : Avalonia.Media.GeometryGroup 
=> control._set(() => control.Children = value);

/*BindFromExpressionSetterGenerator*/
public static T Children<T>(this T control, Func<Avalonia.Media.GeometryCollection> func, Action<Avalonia.Media.GeometryCollection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.ChildrenProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Children<T>(this T control, Func<ValueTask<Avalonia.Media.GeometryCollection>> getter, Func<Avalonia.Media.GeometryCollection>? fallbackGetter = null, Action<Avalonia.Media.GeometryCollection>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.ChildrenProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Children<T>(this T control, IBinding binding) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.ChildrenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Children<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.ChildrenProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // FillRule

/*ValueSetterGenerator*/
public static T FillRule<T>(this T control, Avalonia.Media.FillRule value) where T : Avalonia.Media.GeometryGroup 
=> control._set(() => control.FillRule = value);

/*BindFromExpressionSetterGenerator*/
public static T FillRule<T>(this T control, Func<Avalonia.Media.FillRule> func, Action<Avalonia.Media.FillRule>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.FillRuleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T FillRule<T>(this T control, Func<ValueTask<Avalonia.Media.FillRule>> getter, Func<Avalonia.Media.FillRule>? fallbackGetter = null, Action<Avalonia.Media.FillRule>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.FillRuleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T FillRule<T>(this T control, IBinding binding) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.FillRuleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FillRule<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.FillRuleProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
