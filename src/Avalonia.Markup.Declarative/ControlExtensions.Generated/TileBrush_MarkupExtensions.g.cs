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
public static partial class TileBrush_MarkupExtensions
{
//================= Properties ======================//
 // AlignmentX

/*ValueSetterGenerator*/
public static T AlignmentX<T>(this T control, Avalonia.Media.AlignmentX value) where T : Avalonia.Media.TileBrush 
=> control._set(() => control.AlignmentX = value);

/*BindFromExpressionSetterGenerator*/
public static T AlignmentX<T>(this T control, Func<Avalonia.Media.AlignmentX> func, Action<Avalonia.Media.AlignmentX>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentXProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T AlignmentX<T>(this T control, Func<ValueTask<Avalonia.Media.AlignmentX>> getter, Func<Avalonia.Media.AlignmentX>? fallbackGetter = null, Action<Avalonia.Media.AlignmentX>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentXProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T AlignmentX<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AlignmentX<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentXProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // AlignmentY

/*ValueSetterGenerator*/
public static T AlignmentY<T>(this T control, Avalonia.Media.AlignmentY value) where T : Avalonia.Media.TileBrush 
=> control._set(() => control.AlignmentY = value);

/*BindFromExpressionSetterGenerator*/
public static T AlignmentY<T>(this T control, Func<Avalonia.Media.AlignmentY> func, Action<Avalonia.Media.AlignmentY>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentYProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T AlignmentY<T>(this T control, Func<ValueTask<Avalonia.Media.AlignmentY>> getter, Func<Avalonia.Media.AlignmentY>? fallbackGetter = null, Action<Avalonia.Media.AlignmentY>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentYProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T AlignmentY<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AlignmentY<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentYProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // DestinationRect

/*ValueSetterGenerator*/
public static T DestinationRect<T>(this T control, Avalonia.RelativeRect value) where T : Avalonia.Media.TileBrush 
=> control._set(() => control.DestinationRect = value);

/*BindFromExpressionSetterGenerator*/
public static T DestinationRect<T>(this T control, Func<Avalonia.RelativeRect> func, Action<Avalonia.RelativeRect>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.DestinationRectProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DestinationRect<T>(this T control, Func<ValueTask<Avalonia.RelativeRect>> getter, Func<Avalonia.RelativeRect>? fallbackGetter = null, Action<Avalonia.RelativeRect>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.DestinationRectProperty!, getter, fallbackGetter, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T DestinationRect<T>(this T control, System.Double x = default!, System.Double y = default!, System.Double width = default!, System.Double height = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(x, y, width, height, unit));
public static T DestinationRect<T>(this T control, Avalonia.Rect rect = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(rect, unit));
public static T DestinationRect<T>(this T control, Avalonia.Size size = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(size, unit));
public static T DestinationRect<T>(this T control, Avalonia.Point position = default!, Avalonia.Size size = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(position, size, unit));
public static T DestinationRect<T>(this T control, Avalonia.Point topLeft = default!, Avalonia.Point bottomRight = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(topLeft, bottomRight, unit));

/*BindSetterGenerator*/
public static T DestinationRect<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.DestinationRectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DestinationRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.DestinationRectProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SourceRect

/*ValueSetterGenerator*/
public static T SourceRect<T>(this T control, Avalonia.RelativeRect value) where T : Avalonia.Media.TileBrush 
=> control._set(() => control.SourceRect = value);

/*BindFromExpressionSetterGenerator*/
public static T SourceRect<T>(this T control, Func<Avalonia.RelativeRect> func, Action<Avalonia.RelativeRect>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.SourceRectProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SourceRect<T>(this T control, Func<ValueTask<Avalonia.RelativeRect>> getter, Func<Avalonia.RelativeRect>? fallbackGetter = null, Action<Avalonia.RelativeRect>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.SourceRectProperty!, getter, fallbackGetter, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T SourceRect<T>(this T control, System.Double x = default!, System.Double y = default!, System.Double width = default!, System.Double height = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(x, y, width, height, unit));
public static T SourceRect<T>(this T control, Avalonia.Rect rect = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(rect, unit));
public static T SourceRect<T>(this T control, Avalonia.Size size = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(size, unit));
public static T SourceRect<T>(this T control, Avalonia.Point position = default!, Avalonia.Size size = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(position, size, unit));
public static T SourceRect<T>(this T control, Avalonia.Point topLeft = default!, Avalonia.Point bottomRight = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(topLeft, bottomRight, unit));

/*BindSetterGenerator*/
public static T SourceRect<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.SourceRectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SourceRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.SourceRectProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Stretch

/*ValueSetterGenerator*/
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value) where T : Avalonia.Media.TileBrush 
=> control._set(() => control.Stretch = value);

/*BindFromExpressionSetterGenerator*/
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func, Action<Avalonia.Media.Stretch>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.StretchProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Stretch<T>(this T control, Func<ValueTask<Avalonia.Media.Stretch>> getter, Func<Avalonia.Media.Stretch>? fallbackGetter = null, Action<Avalonia.Media.Stretch>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.StretchProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Stretch<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.StretchProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Stretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.StretchProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // TileMode

/*ValueSetterGenerator*/
public static T TileMode<T>(this T control, Avalonia.Media.TileMode value) where T : Avalonia.Media.TileBrush 
=> control._set(() => control.TileMode = value);

/*BindFromExpressionSetterGenerator*/
public static T TileMode<T>(this T control, Func<Avalonia.Media.TileMode> func, Action<Avalonia.Media.TileMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.TileModeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T TileMode<T>(this T control, Func<ValueTask<Avalonia.Media.TileMode>> getter, Func<Avalonia.Media.TileMode>? fallbackGetter = null, Action<Avalonia.Media.TileMode>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.TileModeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T TileMode<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.TileModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TileMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.TileModeProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
