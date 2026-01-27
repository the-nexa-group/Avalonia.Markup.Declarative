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
public static partial class ScaleTransform_MarkupExtensions
{
//================= Properties ======================//
 // ScaleX

/*ValueSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, System.Double value)  
=> control._set(() => control.ScaleX = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleXProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleXProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, IBinding binding)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleXProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ScaleY

/*ValueSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, System.Double value)  
=> control._set(() => control.ScaleY = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleYProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleYProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, IBinding binding)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleYProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
