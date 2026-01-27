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
public static partial class DropShadowEffect_MarkupExtensions
{
//================= Properties ======================//
 // OffsetX

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, System.Double value)  
=> control._set(() => control.OffsetX = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetXProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetXProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, IBinding binding)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetXProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // OffsetY

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, System.Double value)  
=> control._set(() => control.OffsetY = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetYProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetYProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, IBinding binding)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetYProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
