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
public static partial class CroppedBitmap_MarkupExtensions
{
//================= Properties ======================//
 // Source

/*ValueSetterGenerator*/
public static T Source<T>(this T control, Avalonia.Media.IImage? value) where T : Avalonia.Media.Imaging.CroppedBitmap 
=> control._set(() => control.Source = value);

/*BindFromExpressionSetterGenerator*/
public static T Source<T>(this T control, Func<Avalonia.Media.IImage?> func, Action<Avalonia.Media.IImage?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Source<T>(this T control, Func<ValueTask<Avalonia.Media.IImage?>> getter, Func<Avalonia.Media.IImage?>? fallbackGetter = null, Action<Avalonia.Media.IImage?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Source<T>(this T control, IBinding binding) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Source<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SourceRect

/*ValueSetterGenerator*/
public static T SourceRect<T>(this T control, Avalonia.PixelRect value) where T : Avalonia.Media.Imaging.CroppedBitmap 
=> control._set(() => control.SourceRect = value);

/*BindFromExpressionSetterGenerator*/
public static T SourceRect<T>(this T control, Func<Avalonia.PixelRect> func, Action<Avalonia.PixelRect>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SourceRect<T>(this T control, Func<ValueTask<Avalonia.PixelRect>> getter, Func<Avalonia.PixelRect>? fallbackGetter = null, Action<Avalonia.PixelRect>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty!, getter, fallbackGetter, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T SourceRect<T>(this T control, System.Int32 x = default!, System.Int32 y = default!, System.Int32 width = default!, System.Int32 height = default!) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(x, y, width, height));
public static T SourceRect<T>(this T control, Avalonia.PixelSize size = default!) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(size));
public static T SourceRect<T>(this T control, Avalonia.PixelPoint position = default!, Avalonia.PixelSize size = default!) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(position, size));
public static T SourceRect<T>(this T control, Avalonia.PixelPoint topLeft = default!, Avalonia.PixelPoint bottomRight = default!) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(topLeft, bottomRight));

/*BindSetterGenerator*/
public static T SourceRect<T>(this T control, IBinding binding) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SourceRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // Invalidated

/*ActionToEventGenerator*/
public static T OnInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.Imaging.CroppedBitmap  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Invalidated += h);



}
