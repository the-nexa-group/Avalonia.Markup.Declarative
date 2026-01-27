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
public static partial class ImageBrush_MarkupExtensions
{
//================= Properties ======================//
 // Source

/*ValueSetterGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, Avalonia.Media.IImageBrushSource? value)  
=> control._set(() => control.Source = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, Func<Avalonia.Media.IImageBrushSource?> func, Action<Avalonia.Media.IImageBrushSource?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.ImageBrush.SourceProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, Func<ValueTask<Avalonia.Media.IImageBrushSource?>> getter, Func<Avalonia.Media.IImageBrushSource?>? fallbackGetter = null, Action<Avalonia.Media.IImageBrushSource?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.ImageBrush.SourceProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, IBinding binding)  
   => control._set(Avalonia.Media.ImageBrush.SourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ImageBrush.SourceProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
