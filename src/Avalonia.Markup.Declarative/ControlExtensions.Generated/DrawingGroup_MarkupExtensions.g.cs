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
public static partial class DrawingGroup_MarkupExtensions
{
//================= Properties ======================//
 // Opacity

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, System.Double value)  
=> control._set(() => control.Opacity = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, IBinding binding)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Transform

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, Avalonia.Media.Transform? value)  
=> control._set(() => control.Transform = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.Transform?> func, Action<Avalonia.Media.Transform?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DrawingGroup.TransformProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, Func<ValueTask<Avalonia.Media.Transform?>> getter, Func<Avalonia.Media.Transform?>? fallbackGetter = null, Action<Avalonia.Media.Transform?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.DrawingGroup.TransformProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, IBinding binding)  
   => control._set(Avalonia.Media.DrawingGroup.TransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DrawingGroup.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ClipGeometry

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, Avalonia.Media.Geometry? value)  
=> control._set(() => control.ClipGeometry = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.Geometry?> func, Action<Avalonia.Media.Geometry?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DrawingGroup.ClipGeometryProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, Func<ValueTask<Avalonia.Media.Geometry?>> getter, Func<Avalonia.Media.Geometry?>? fallbackGetter = null, Action<Avalonia.Media.Geometry?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.DrawingGroup.ClipGeometryProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, IBinding binding)  
   => control._set(Avalonia.Media.DrawingGroup.ClipGeometryProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DrawingGroup.ClipGeometryProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // OpacityMask

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, Avalonia.Media.IBrush? value)  
=> control._set(() => control.OpacityMask = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.IBrush?> func, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityMaskProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, Func<ValueTask<Avalonia.Media.IBrush?>> getter, Func<Avalonia.Media.IBrush?>? fallbackGetter = null, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityMaskProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, IBinding binding)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityMaskProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityMaskProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Children

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, Avalonia.Media.DrawingCollection value)  
=> control._set(() => control.Children = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.DrawingCollection> func, Action<Avalonia.Media.DrawingCollection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DrawingGroup.ChildrenProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, Func<ValueTask<Avalonia.Media.DrawingCollection>> getter, Func<Avalonia.Media.DrawingCollection>? fallbackGetter = null, Action<Avalonia.Media.DrawingCollection>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Media.DrawingGroup.ChildrenProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, IBinding binding)  
   => control._set(Avalonia.Media.DrawingGroup.ChildrenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DrawingGroup.ChildrenProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
