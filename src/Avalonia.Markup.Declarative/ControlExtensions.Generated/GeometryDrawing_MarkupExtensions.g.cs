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
public static partial class GeometryDrawing_MarkupExtensions
{
//================= Properties ======================//
 // Geometry

/*ValueSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing control, Avalonia.Media.Geometry? value)  
=> control._set(() => control.Geometry = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing control, Func<Avalonia.Media.Geometry?> func, Action<Avalonia.Media.Geometry?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.GeometryDrawing.GeometryProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing control, Func<ValueTask<Avalonia.Media.Geometry?>> getter, Func<Avalonia.Media.Geometry?>? fallbackGetter = null, Action<Avalonia.Media.Geometry?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.GeometryDrawing.GeometryProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing control, IBinding binding)  
   => control._set(Avalonia.Media.GeometryDrawing.GeometryProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.GeometryDrawing.GeometryProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Brush

/*ValueSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing control, Avalonia.Media.IBrush? value)  
=> control._set(() => control.Brush = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing control, Func<Avalonia.Media.IBrush?> func, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.GeometryDrawing.BrushProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing control, Func<ValueTask<Avalonia.Media.IBrush?>> getter, Func<Avalonia.Media.IBrush?>? fallbackGetter = null, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.GeometryDrawing.BrushProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing control, IBinding binding)  
   => control._set(Avalonia.Media.GeometryDrawing.BrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.GeometryDrawing.BrushProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Pen

/*ValueSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing control, Avalonia.Media.IPen? value)  
=> control._set(() => control.Pen = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing control, Func<Avalonia.Media.IPen?> func, Action<Avalonia.Media.IPen?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.GeometryDrawing.PenProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing control, Func<ValueTask<Avalonia.Media.IPen?>> getter, Func<Avalonia.Media.IPen?>? fallbackGetter = null, Action<Avalonia.Media.IPen?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.GeometryDrawing.PenProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing control, IBinding binding)  
   => control._set(Avalonia.Media.GeometryDrawing.PenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.GeometryDrawing.PenProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
