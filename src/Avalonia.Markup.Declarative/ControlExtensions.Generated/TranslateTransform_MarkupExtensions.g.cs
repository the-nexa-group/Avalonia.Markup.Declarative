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
public static partial class TranslateTransform_MarkupExtensions
{
//================= Properties ======================//
 // X

/*ValueSetterGenerator*/
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, System.Double value)  
=> control._set(() => control.X = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.TranslateTransform.XProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.TranslateTransform.XProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, IBinding binding)  
   => control._set(Avalonia.Media.TranslateTransform.XProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.TranslateTransform.XProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Y

/*ValueSetterGenerator*/
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, System.Double value)  
=> control._set(() => control.Y = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.TranslateTransform.YProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.TranslateTransform.YProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, IBinding binding)  
   => control._set(Avalonia.Media.TranslateTransform.YProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.TranslateTransform.YProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
