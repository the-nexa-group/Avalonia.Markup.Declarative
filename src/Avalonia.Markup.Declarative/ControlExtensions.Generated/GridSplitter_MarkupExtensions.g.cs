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
public static partial class GridSplitter_MarkupExtensions
{
//================= Properties ======================//
 // ResizeDirection

/*ValueSetterGenerator*/
public static T ResizeDirection<T>(this T control, Avalonia.Controls.GridResizeDirection value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.ResizeDirection = value);

/*BindFromExpressionSetterGenerator*/
public static T ResizeDirection<T>(this T control, Func<Avalonia.Controls.GridResizeDirection> func, Action<Avalonia.Controls.GridResizeDirection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeDirectionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ResizeDirection<T>(this T control, Func<ValueTask<Avalonia.Controls.GridResizeDirection>> getter, Func<Avalonia.Controls.GridResizeDirection>? fallbackGetter = null, Action<Avalonia.Controls.GridResizeDirection>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeDirectionProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ResizeDirection<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ResizeDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ResizeBehavior

/*ValueSetterGenerator*/
public static T ResizeBehavior<T>(this T control, Avalonia.Controls.GridResizeBehavior value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.ResizeBehavior = value);

/*BindFromExpressionSetterGenerator*/
public static T ResizeBehavior<T>(this T control, Func<Avalonia.Controls.GridResizeBehavior> func, Action<Avalonia.Controls.GridResizeBehavior>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ResizeBehavior<T>(this T control, Func<ValueTask<Avalonia.Controls.GridResizeBehavior>> getter, Func<Avalonia.Controls.GridResizeBehavior>? fallbackGetter = null, Action<Avalonia.Controls.GridResizeBehavior>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ResizeBehavior<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ResizeBehavior<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ShowsPreview

/*ValueSetterGenerator*/
public static T ShowsPreview<T>(this T control, System.Boolean value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.ShowsPreview = value);

/*BindFromExpressionSetterGenerator*/
public static T ShowsPreview<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ShowsPreviewProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ShowsPreview<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ShowsPreviewProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ShowsPreview<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowsPreview<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // KeyboardIncrement

/*ValueSetterGenerator*/
public static T KeyboardIncrement<T>(this T control, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.KeyboardIncrement = value);

/*BindFromExpressionSetterGenerator*/
public static T KeyboardIncrement<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T KeyboardIncrement<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T KeyboardIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T KeyboardIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // DragIncrement

/*ValueSetterGenerator*/
public static T DragIncrement<T>(this T control, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.DragIncrement = value);

/*BindFromExpressionSetterGenerator*/
public static T DragIncrement<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.DragIncrementProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DragIncrement<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.DragIncrementProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T DragIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.DragIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DragIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.DragIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PreviewContent

/*ValueSetterGenerator*/
public static T PreviewContent<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.PreviewContent = value);

/*BindFromExpressionSetterGenerator*/
public static T PreviewContent<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.PreviewContentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PreviewContent<T>(this T control, Func<ValueTask<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>> getter, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? fallbackGetter = null, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.PreviewContentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PreviewContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.PreviewContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PreviewContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.PreviewContentProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // ResizeDirection

/*ValueStyleSetterGenerator*/
public static Style<T> ResizeDirection<T>(this Style<T> style, Avalonia.Controls.GridResizeDirection value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResizeDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, binding);


 // ResizeBehavior

/*ValueStyleSetterGenerator*/
public static Style<T> ResizeBehavior<T>(this Style<T> style, Avalonia.Controls.GridResizeBehavior value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResizeBehavior<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, binding);


 // ShowsPreview

/*ValueStyleSetterGenerator*/
public static Style<T> ShowsPreview<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ShowsPreviewProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowsPreview<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, binding);


 // KeyboardIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> KeyboardIncrement<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> KeyboardIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, binding);


 // DragIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> DragIncrement<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.DragIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DragIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.DragIncrementProperty, binding);


 // PreviewContent

/*ValueStyleSetterGenerator*/
public static Style<T> PreviewContent<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.PreviewContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PreviewContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.PreviewContentProperty, binding);



}
