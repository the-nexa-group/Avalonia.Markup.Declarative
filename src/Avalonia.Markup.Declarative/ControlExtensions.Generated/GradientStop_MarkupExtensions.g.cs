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
public static partial class GradientStop_MarkupExtensions
{
//================= Properties ======================//
 // Offset

/*ValueSetterGenerator*/
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, System.Double value)  
=> control._set(() => control.Offset = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.GradientStop.OffsetProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.GradientStop.OffsetProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, IBinding binding)  
   => control._set(Avalonia.Media.GradientStop.OffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.GradientStop.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Color

/*ValueSetterGenerator*/
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, Avalonia.Media.Color value)  
=> control._set(() => control.Color = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.GradientStop.ColorProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, Func<ValueTask<Avalonia.Media.Color>> getter, Func<Avalonia.Media.Color>? fallbackGetter = null, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.GradientStop.ColorProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, IBinding binding)  
   => control._set(Avalonia.Media.GradientStop.ColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.GradientStop.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
