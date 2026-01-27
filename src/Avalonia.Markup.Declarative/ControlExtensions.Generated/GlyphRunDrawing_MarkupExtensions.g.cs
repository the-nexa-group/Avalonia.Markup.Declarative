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
public static partial class GlyphRunDrawing_MarkupExtensions
{
//================= Properties ======================//
 // Foreground

/*ValueSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, Avalonia.Media.IBrush? value)  
=> control._set(() => control.Foreground = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, Func<Avalonia.Media.IBrush?> func, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.GlyphRunDrawing.ForegroundProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, Func<ValueTask<Avalonia.Media.IBrush?>> getter, Func<Avalonia.Media.IBrush?>? fallbackGetter = null, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.GlyphRunDrawing.ForegroundProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, IBinding binding)  
   => control._set(Avalonia.Media.GlyphRunDrawing.ForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.GlyphRunDrawing.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // GlyphRun

/*ValueSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, Avalonia.Media.GlyphRun? value)  
=> control._set(() => control.GlyphRun = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, Func<Avalonia.Media.GlyphRun?> func, Action<Avalonia.Media.GlyphRun?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, Func<ValueTask<Avalonia.Media.GlyphRun?>> getter, Func<Avalonia.Media.GlyphRun?>? fallbackGetter = null, Action<Avalonia.Media.GlyphRun?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, IBinding binding)  
   => control._set(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
