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
public static partial class ExperimentalAcrylicMaterial_MarkupExtensions
{
//================= Properties ======================//
 // TintColor

/*ValueSetterGenerator*/
public static T TintColor<T>(this T control, Avalonia.Media.Color value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
=> control._set(() => control.TintColor = value);

/*BindFromExpressionSetterGenerator*/
public static T TintColor<T>(this T control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintColorProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T TintColor<T>(this T control, Func<ValueTask<Avalonia.Media.Color>> getter, Func<Avalonia.Media.Color>? fallbackGetter = null, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintColorProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T TintColor<T>(this T control, IBinding binding) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TintColor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintColorProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // BackgroundSource

/*ValueSetterGenerator*/
public static T BackgroundSource<T>(this T control, Avalonia.Media.AcrylicBackgroundSource value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
=> control._set(() => control.BackgroundSource = value);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundSource<T>(this T control, Func<Avalonia.Media.AcrylicBackgroundSource> func, Action<Avalonia.Media.AcrylicBackgroundSource>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.BackgroundSourceProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T BackgroundSource<T>(this T control, Func<ValueTask<Avalonia.Media.AcrylicBackgroundSource>> getter, Func<Avalonia.Media.AcrylicBackgroundSource>? fallbackGetter = null, Action<Avalonia.Media.AcrylicBackgroundSource>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.BackgroundSourceProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T BackgroundSource<T>(this T control, IBinding binding) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.BackgroundSourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.BackgroundSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // TintOpacity

/*ValueSetterGenerator*/
public static T TintOpacity<T>(this T control, System.Double value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
=> control._set(() => control.TintOpacity = value);

/*BindFromExpressionSetterGenerator*/
public static T TintOpacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintOpacityProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T TintOpacity<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintOpacityProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T TintOpacity<T>(this T control, IBinding binding) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintOpacityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TintOpacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintOpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MaterialOpacity

/*ValueSetterGenerator*/
public static T MaterialOpacity<T>(this T control, System.Double value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
=> control._set(() => control.MaterialOpacity = value);

/*BindFromExpressionSetterGenerator*/
public static T MaterialOpacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.MaterialOpacityProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MaterialOpacity<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.MaterialOpacityProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MaterialOpacity<T>(this T control, IBinding binding) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.MaterialOpacityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaterialOpacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.MaterialOpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlatformTransparencyCompensationLevel

/*ValueSetterGenerator*/
public static T PlatformTransparencyCompensationLevel<T>(this T control, System.Double value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
=> control._set(() => control.PlatformTransparencyCompensationLevel = value);

/*BindFromExpressionSetterGenerator*/
public static T PlatformTransparencyCompensationLevel<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PlatformTransparencyCompensationLevel<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PlatformTransparencyCompensationLevel<T>(this T control, IBinding binding) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlatformTransparencyCompensationLevel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // FallbackColor

/*ValueSetterGenerator*/
public static T FallbackColor<T>(this T control, Avalonia.Media.Color value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
=> control._set(() => control.FallbackColor = value);

/*BindFromExpressionSetterGenerator*/
public static T FallbackColor<T>(this T control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.FallbackColorProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T FallbackColor<T>(this T control, Func<ValueTask<Avalonia.Media.Color>> getter, Func<Avalonia.Media.Color>? fallbackGetter = null, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.FallbackColorProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T FallbackColor<T>(this T control, IBinding binding) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.FallbackColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FallbackColor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.FallbackColorProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // Invalidated

/*ActionToEventGenerator*/
public static T OnInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.ExperimentalAcrylicMaterial  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Invalidated += h);



}
