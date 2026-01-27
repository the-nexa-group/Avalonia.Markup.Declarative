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
public static partial class DropShadowEffectBase_MarkupExtensions
{
//================= Properties ======================//
 // BlurRadius

/*ValueSetterGenerator*/
public static T BlurRadius<T>(this T control, System.Double value) where T : Avalonia.Media.DropShadowEffectBase 
=> control._set(() => control.BlurRadius = value);

/*BindFromExpressionSetterGenerator*/
public static T BlurRadius<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T BlurRadius<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T BlurRadius<T>(this T control, IBinding binding) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BlurRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Color

/*ValueSetterGenerator*/
public static T Color<T>(this T control, Avalonia.Media.Color value) where T : Avalonia.Media.DropShadowEffectBase 
=> control._set(() => control.Color = value);

/*BindFromExpressionSetterGenerator*/
public static T Color<T>(this T control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.ColorProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Color<T>(this T control, Func<ValueTask<Avalonia.Media.Color>> getter, Func<Avalonia.Media.Color>? fallbackGetter = null, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.ColorProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Color<T>(this T control, IBinding binding) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.ColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Color<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Opacity

/*ValueSetterGenerator*/
public static T Opacity<T>(this T control, System.Double value) where T : Avalonia.Media.DropShadowEffectBase 
=> control._set(() => control.Opacity = value);

/*BindFromExpressionSetterGenerator*/
public static T Opacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.OpacityProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Opacity<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.OpacityProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Opacity<T>(this T control, IBinding binding) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.OpacityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Opacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
