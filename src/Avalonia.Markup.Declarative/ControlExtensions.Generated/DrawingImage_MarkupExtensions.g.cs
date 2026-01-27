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
public static partial class DrawingImage_MarkupExtensions
{
//================= Properties ======================//
 // Drawing

/*ValueSetterGenerator*/
public static T Drawing<T>(this T control, Avalonia.Media.Drawing? value) where T : Avalonia.Media.DrawingImage 
=> control._set(() => control.Drawing = value);

/*BindFromExpressionSetterGenerator*/
public static T Drawing<T>(this T control, Func<Avalonia.Media.Drawing?> func, Action<Avalonia.Media.Drawing?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.DrawingImage 
   => control._set(Avalonia.Media.DrawingImage.DrawingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Drawing<T>(this T control, Func<ValueTask<Avalonia.Media.Drawing?>> getter, Func<Avalonia.Media.Drawing?>? fallbackGetter = null, Action<Avalonia.Media.Drawing?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.DrawingImage 
   => control._set(Avalonia.Media.DrawingImage.DrawingProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Drawing<T>(this T control, IBinding binding) where T : Avalonia.Media.DrawingImage 
   => control._set(Avalonia.Media.DrawingImage.DrawingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Drawing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.DrawingImage 
   => control._set(Avalonia.Media.DrawingImage.DrawingProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // Invalidated

/*ActionToEventGenerator*/
public static T OnInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.DrawingImage  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Invalidated += h);



}
