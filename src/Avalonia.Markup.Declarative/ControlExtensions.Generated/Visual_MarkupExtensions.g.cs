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
public static partial class Visual_MarkupExtensions
{
//================= Properties ======================//
 // ClipToBounds

/*ValueSetterGenerator*/
public static T ClipToBounds<T>(this T control, System.Boolean value) where T : Avalonia.Visual 
=> control._set(() => control.ClipToBounds = value);

/*BindFromExpressionSetterGenerator*/
public static T ClipToBounds<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipToBoundsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ClipToBounds<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipToBoundsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ClipToBounds<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipToBoundsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClipToBounds<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipToBoundsProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Clip

/*ValueSetterGenerator*/
public static T Clip<T>(this T control, Avalonia.Media.Geometry? value) where T : Avalonia.Visual 
=> control._set(() => control.Clip = value);

/*BindFromExpressionSetterGenerator*/
public static T Clip<T>(this T control, Func<Avalonia.Media.Geometry?> func, Action<Avalonia.Media.Geometry?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Clip<T>(this T control, Func<ValueTask<Avalonia.Media.Geometry?>> getter, Func<Avalonia.Media.Geometry?>? fallbackGetter = null, Action<Avalonia.Media.Geometry?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Clip<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Clip<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsVisible

/*ValueSetterGenerator*/
public static T IsVisible<T>(this T control, System.Boolean value) where T : Avalonia.Visual 
=> control._set(() => control.IsVisible = value);

/*BindFromExpressionSetterGenerator*/
public static T IsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.IsVisibleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsVisible<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.IsVisibleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsVisible<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.IsVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Opacity

/*ValueSetterGenerator*/
public static T Opacity<T>(this T control, System.Double value) where T : Avalonia.Visual 
=> control._set(() => control.Opacity = value);

/*BindFromExpressionSetterGenerator*/
public static T Opacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Opacity<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Opacity<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Opacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // OpacityMask

/*ValueSetterGenerator*/
public static T OpacityMask<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Visual 
=> control._set(() => control.OpacityMask = value);

/*BindFromExpressionSetterGenerator*/
public static T OpacityMask<T>(this T control, Func<Avalonia.Media.IBrush?> func, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityMaskProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T OpacityMask<T>(this T control, Func<ValueTask<Avalonia.Media.IBrush?>> getter, Func<Avalonia.Media.IBrush?>? fallbackGetter = null, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityMaskProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T OpacityMask<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityMaskProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OpacityMask<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityMaskProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Effect

/*ValueSetterGenerator*/
public static T Effect<T>(this T control, Avalonia.Media.IEffect? value) where T : Avalonia.Visual 
=> control._set(() => control.Effect = value);

/*BindFromExpressionSetterGenerator*/
public static T Effect<T>(this T control, Func<Avalonia.Media.IEffect?> func, Action<Avalonia.Media.IEffect?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.EffectProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Effect<T>(this T control, Func<ValueTask<Avalonia.Media.IEffect?>> getter, Func<Avalonia.Media.IEffect?>? fallbackGetter = null, Action<Avalonia.Media.IEffect?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.EffectProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Effect<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.EffectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Effect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.EffectProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // RenderTransform

/*ValueSetterGenerator*/
public static T RenderTransform<T>(this T control, Avalonia.Media.ITransform? value) where T : Avalonia.Visual 
=> control._set(() => control.RenderTransform = value);

/*BindFromExpressionSetterGenerator*/
public static T RenderTransform<T>(this T control, Func<Avalonia.Media.ITransform?> func, Action<Avalonia.Media.ITransform?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T RenderTransform<T>(this T control, Func<ValueTask<Avalonia.Media.ITransform?>> getter, Func<Avalonia.Media.ITransform?>? fallbackGetter = null, Action<Avalonia.Media.ITransform?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T RenderTransform<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RenderTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // RenderTransformOrigin

/*ValueSetterGenerator*/
public static T RenderTransformOrigin<T>(this T control, Avalonia.RelativePoint value) where T : Avalonia.Visual 
=> control._set(() => control.RenderTransformOrigin = value);

/*BindFromExpressionSetterGenerator*/
public static T RenderTransformOrigin<T>(this T control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformOriginProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T RenderTransformOrigin<T>(this T control, Func<ValueTask<Avalonia.RelativePoint>> getter, Func<Avalonia.RelativePoint>? fallbackGetter = null, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformOriginProperty!, getter, fallbackGetter, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T RenderTransformOrigin<T>(this T control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Visual 
   => control._set(() => control.RenderTransformOrigin = new Avalonia.RelativePoint(x, y, unit));
public static T RenderTransformOrigin<T>(this T control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Visual 
   => control._set(() => control.RenderTransformOrigin = new Avalonia.RelativePoint(point, unit));

/*BindSetterGenerator*/
public static T RenderTransformOrigin<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformOriginProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RenderTransformOrigin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformOriginProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // FlowDirection

/*ValueSetterGenerator*/
public static T FlowDirection<T>(this T control, Avalonia.Media.FlowDirection value) where T : Avalonia.Visual 
=> control._set(() => control.FlowDirection = value);

/*BindFromExpressionSetterGenerator*/
public static T FlowDirection<T>(this T control, Func<Avalonia.Media.FlowDirection> func, Action<Avalonia.Media.FlowDirection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T FlowDirection<T>(this T control, Func<ValueTask<Avalonia.Media.FlowDirection>> getter, Func<Avalonia.Media.FlowDirection>? fallbackGetter = null, Action<Avalonia.Media.FlowDirection>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T FlowDirection<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FlowDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ZIndex

/*ValueSetterGenerator*/
public static T ZIndex<T>(this T control, System.Int32 value) where T : Avalonia.Visual 
=> control._set(() => control.ZIndex = value);

/*BindFromExpressionSetterGenerator*/
public static T ZIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ZIndexProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ZIndex<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ZIndexProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ZIndex<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ZIndexProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ZIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ZIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Attached Properties ======================//
 // FlowDirection

/*AttachedPropertyMagicalSetterGenerator*/
public static T Visual_FlowDirection<T>(this T control, Avalonia.Media.FlowDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Visual
 => control._setEx(Avalonia.Visual.FlowDirectionProperty, ps, () => Avalonia.Visual.SetFlowDirection(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Visual_FlowDirection<T>(this T control, Func<Avalonia.Media.FlowDirection> func, Action<Avalonia.Media.FlowDirection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty!, func, onChanged, expression);



//================= Events ======================//
 // AttachedToVisualTree

/*ActionToEventGenerator*/
public static T OnAttachedToVisualTree<T>(this T control, Action<Avalonia.VisualTreeAttachmentEventArgs> action) where T : Avalonia.Visual  => 
 control._setEvent((System.EventHandler<Avalonia.VisualTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.AttachedToVisualTree += h);


 // DetachedFromVisualTree

/*ActionToEventGenerator*/
public static T OnDetachedFromVisualTree<T>(this T control, Action<Avalonia.VisualTreeAttachmentEventArgs> action) where T : Avalonia.Visual  => 
 control._setEvent((System.EventHandler<Avalonia.VisualTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DetachedFromVisualTree += h);



//================= Styles ======================//
 // ClipToBounds

/*ValueStyleSetterGenerator*/
public static Style<T> ClipToBounds<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipToBoundsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClipToBounds<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipToBoundsProperty, binding);


 // Clip

/*ValueStyleSetterGenerator*/
public static Style<T> Clip<T>(this Style<T> style, Avalonia.Media.Geometry? value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Clip<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipProperty, binding);


 // IsVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.IsVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.IsVisibleProperty, binding);


 // Opacity

/*ValueStyleSetterGenerator*/
public static Style<T> Opacity<T>(this Style<T> style, System.Double value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Opacity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityProperty, binding);


 // OpacityMask

/*ValueStyleSetterGenerator*/
public static Style<T> OpacityMask<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityMaskProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OpacityMask<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityMaskProperty, binding);


 // Effect

/*ValueStyleSetterGenerator*/
public static Style<T> Effect<T>(this Style<T> style, Avalonia.Media.IEffect? value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.EffectProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Effect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.EffectProperty, binding);


 // RenderTransform

/*ValueStyleSetterGenerator*/
public static Style<T> RenderTransform<T>(this Style<T> style, Avalonia.Media.ITransform? value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RenderTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformProperty, binding);


 // RenderTransformOrigin

/*ValueStyleSetterGenerator*/
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, Avalonia.RelativePoint value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformOriginProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, System.Double x, System.Double y, Avalonia.RelativeUnit unit) where T : Avalonia.Visual 
   => style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, new Avalonia.RelativePoint(x, y, unit));public static Style<T> RenderTransformOrigin<T>(this Style<T> style, Avalonia.Point point, Avalonia.RelativeUnit unit) where T : Avalonia.Visual 
   => style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, new Avalonia.RelativePoint(point, unit));


 // FlowDirection

/*ValueStyleSetterGenerator*/
public static Style<T> FlowDirection<T>(this Style<T> style, Avalonia.Media.FlowDirection value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.FlowDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FlowDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.FlowDirectionProperty, binding);


 // ZIndex

/*ValueStyleSetterGenerator*/
public static Style<T> ZIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ZIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ZIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ZIndexProperty, binding);



}
