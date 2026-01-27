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
public static partial class DropShadowDirectionEffect_MarkupExtensions
{
//================= Properties ======================//
 // ShadowDepth

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, System.Double value)  
=> control._set(() => control.ShadowDepth = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, IBinding binding)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Direction

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, System.Double value)  
=> control._set(() => control.Direction = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.DirectionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.DirectionProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, IBinding binding)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.DirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.DirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
