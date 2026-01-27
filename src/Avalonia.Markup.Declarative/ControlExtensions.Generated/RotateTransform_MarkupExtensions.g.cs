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
public static partial class RotateTransform_MarkupExtensions
{
//================= Properties ======================//
 // Angle

/*ValueSetterGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, System.Double value)  
=> control._set(() => control.Angle = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.RotateTransform.AngleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.RotateTransform.AngleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, IBinding binding)  
   => control._set(Avalonia.Media.RotateTransform.AngleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.RotateTransform.AngleProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CenterX

/*ValueSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, System.Double value)  
=> control._set(() => control.CenterX = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.RotateTransform.CenterXProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.RotateTransform.CenterXProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, IBinding binding)  
   => control._set(Avalonia.Media.RotateTransform.CenterXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.RotateTransform.CenterXProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CenterY

/*ValueSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, System.Double value)  
=> control._set(() => control.CenterY = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.RotateTransform.CenterYProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.RotateTransform.CenterYProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, IBinding binding)  
   => control._set(Avalonia.Media.RotateTransform.CenterYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.RotateTransform.CenterYProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
