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
public static partial class CombinedGeometry_MarkupExtensions
{
//================= Properties ======================//
 // Geometry1

/*ValueSetterGenerator*/
public static T Geometry1<T>(this T control, Avalonia.Media.Geometry? value) where T : Avalonia.Media.CombinedGeometry 
=> control._set(() => control.Geometry1 = value);

/*BindFromExpressionSetterGenerator*/
public static T Geometry1<T>(this T control, Func<Avalonia.Media.Geometry?> func, Action<Avalonia.Media.Geometry?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry1Property!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Geometry1<T>(this T control, Func<ValueTask<Avalonia.Media.Geometry?>> getter, Func<Avalonia.Media.Geometry?>? fallbackGetter = null, Action<Avalonia.Media.Geometry?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry1Property!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Geometry1<T>(this T control, IBinding binding) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry1Property, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Geometry1<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry1Property, avaloniaProperty, bindingMode, converter, overrideView);


 // Geometry2

/*ValueSetterGenerator*/
public static T Geometry2<T>(this T control, Avalonia.Media.Geometry? value) where T : Avalonia.Media.CombinedGeometry 
=> control._set(() => control.Geometry2 = value);

/*BindFromExpressionSetterGenerator*/
public static T Geometry2<T>(this T control, Func<Avalonia.Media.Geometry?> func, Action<Avalonia.Media.Geometry?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry2Property!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Geometry2<T>(this T control, Func<ValueTask<Avalonia.Media.Geometry?>> getter, Func<Avalonia.Media.Geometry?>? fallbackGetter = null, Action<Avalonia.Media.Geometry?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry2Property!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Geometry2<T>(this T control, IBinding binding) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry2Property, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Geometry2<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry2Property, avaloniaProperty, bindingMode, converter, overrideView);


 // GeometryCombineMode

/*ValueSetterGenerator*/
public static T GeometryCombineMode<T>(this T control, Avalonia.Media.GeometryCombineMode value) where T : Avalonia.Media.CombinedGeometry 
=> control._set(() => control.GeometryCombineMode = value);

/*BindFromExpressionSetterGenerator*/
public static T GeometryCombineMode<T>(this T control, Func<Avalonia.Media.GeometryCombineMode> func, Action<Avalonia.Media.GeometryCombineMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T GeometryCombineMode<T>(this T control, Func<ValueTask<Avalonia.Media.GeometryCombineMode>> getter, Func<Avalonia.Media.GeometryCombineMode>? fallbackGetter = null, Action<Avalonia.Media.GeometryCombineMode>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T GeometryCombineMode<T>(this T control, IBinding binding) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T GeometryCombineMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
