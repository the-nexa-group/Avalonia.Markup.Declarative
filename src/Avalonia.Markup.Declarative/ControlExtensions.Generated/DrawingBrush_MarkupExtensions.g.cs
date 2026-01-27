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
public static partial class DrawingBrush_MarkupExtensions
{
//================= Properties ======================//
 // Drawing

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, Avalonia.Media.Drawing? value)  
=> control._set(() => control.Drawing = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, Func<Avalonia.Media.Drawing?> func, Action<Avalonia.Media.Drawing?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DrawingBrush.DrawingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, Func<ValueTask<Avalonia.Media.Drawing?>> getter, Func<Avalonia.Media.Drawing?>? fallbackGetter = null, Action<Avalonia.Media.Drawing?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.DrawingBrush.DrawingProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, IBinding binding)  
   => control._set(Avalonia.Media.DrawingBrush.DrawingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DrawingBrush.DrawingProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
