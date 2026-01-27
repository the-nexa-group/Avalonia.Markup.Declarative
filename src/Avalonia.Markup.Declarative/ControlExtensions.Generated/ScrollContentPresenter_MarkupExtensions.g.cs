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
public static partial class ScrollContentPresenter_MarkupExtensions
{
//================= Properties ======================//
 // CanHorizontallyScroll

/*ValueSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.CanHorizontallyScroll = value);

/*BindFromExpressionSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CanVerticallyScroll

/*ValueSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.CanVerticallyScroll = value);

/*BindFromExpressionSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Offset

/*ValueSetterGenerator*/
public static T Offset<T>(this T control, Avalonia.Vector value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.Offset = value);

/*BindFromExpressionSetterGenerator*/
public static T Offset<T>(this T control, Func<Avalonia.Vector> func, Action<Avalonia.Vector>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Offset<T>(this T control, Func<ValueTask<Avalonia.Vector>> getter, Func<Avalonia.Vector>? fallbackGetter = null, Action<Avalonia.Vector>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Offset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Offset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HorizontalSnapPointsType

/*ValueSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.HorizontalSnapPointsType = value);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.SnapPointsType>> getter, Func<Avalonia.Controls.Primitives.SnapPointsType>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // VerticalSnapPointsType

/*ValueSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.VerticalSnapPointsType = value);

/*BindFromExpressionSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.SnapPointsType>> getter, Func<Avalonia.Controls.Primitives.SnapPointsType>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HorizontalSnapPointsAlignment

/*ValueSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.HorizontalSnapPointsAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.SnapPointsAlignment>> getter, Func<Avalonia.Controls.Primitives.SnapPointsAlignment>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // VerticalSnapPointsAlignment

/*ValueSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.VerticalSnapPointsAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.SnapPointsAlignment>> getter, Func<Avalonia.Controls.Primitives.SnapPointsAlignment>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsScrollChainingEnabled

/*ValueSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.IsScrollChainingEnabled = value);

/*BindFromExpressionSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // CanHorizontallyScroll

/*ValueStyleSetterGenerator*/
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, binding);


 // CanVerticallyScroll

/*ValueStyleSetterGenerator*/
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, binding);


 // Offset

/*ValueStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, Avalonia.Vector value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, binding);


 // HorizontalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, binding);


 // VerticalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, binding);


 // HorizontalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, binding);


 // VerticalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, binding);


 // IsScrollChainingEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, binding);



}
