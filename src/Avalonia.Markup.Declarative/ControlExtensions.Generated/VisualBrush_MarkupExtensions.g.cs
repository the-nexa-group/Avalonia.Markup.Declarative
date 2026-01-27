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
public static partial class VisualBrush_MarkupExtensions
{
//================= Properties ======================//
 // Visual

/*ValueSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, Avalonia.Visual? value)  
=> control._set(() => control.Visual = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, Func<Avalonia.Visual?> func, Action<Avalonia.Visual?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.VisualBrush.VisualProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, Func<ValueTask<Avalonia.Visual?>> getter, Func<Avalonia.Visual?>? fallbackGetter = null, Action<Avalonia.Visual?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.VisualBrush.VisualProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, IBinding binding)  
   => control._set(Avalonia.Media.VisualBrush.VisualProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.VisualBrush.VisualProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
