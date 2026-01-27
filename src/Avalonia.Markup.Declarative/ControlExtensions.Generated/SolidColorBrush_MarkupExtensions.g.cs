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
public static partial class SolidColorBrush_MarkupExtensions
{
//================= Properties ======================//
 // Color

/*ValueSetterGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, Avalonia.Media.Color value)  
=> control._set(() => control.Color = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.SolidColorBrush.ColorProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, Func<ValueTask<Avalonia.Media.Color>> getter, Func<Avalonia.Media.Color>? fallbackGetter = null, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.SolidColorBrush.ColorProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, IBinding binding)  
   => control._set(Avalonia.Media.SolidColorBrush.ColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.SolidColorBrush.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
