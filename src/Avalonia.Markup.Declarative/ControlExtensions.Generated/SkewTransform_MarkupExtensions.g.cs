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
public static partial class SkewTransform_MarkupExtensions
{
//================= Properties ======================//
 // AngleX

/*ValueSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, System.Double value)  
=> control._set(() => control.AngleX = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.SkewTransform.AngleXProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.SkewTransform.AngleXProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, IBinding binding)  
   => control._set(Avalonia.Media.SkewTransform.AngleXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.SkewTransform.AngleXProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // AngleY

/*ValueSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, System.Double value)  
=> control._set(() => control.AngleY = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.SkewTransform.AngleYProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.SkewTransform.AngleYProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, IBinding binding)  
   => control._set(Avalonia.Media.SkewTransform.AngleYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.SkewTransform.AngleYProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
