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
public static partial class ContextMenu_MarkupExtensions
{
//================= Properties ======================//
 // HorizontalOffset

/*ValueSetterGenerator*/
public static T HorizontalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.HorizontalOffset = value);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HorizontalOffset<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HorizontalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // VerticalOffset

/*ValueSetterGenerator*/
public static T VerticalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.VerticalOffset = value);

/*BindFromExpressionSetterGenerator*/
public static T VerticalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T VerticalOffset<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T VerticalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlacementAnchor

/*ValueSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.PlacementAnchor = value);

/*BindFromExpressionSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>> getter, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PlacementAnchor<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementAnchor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlacementConstraintAdjustment

/*ValueSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.PlacementConstraintAdjustment = value);

/*BindFromExpressionSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>> getter, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlacementGravity

/*ValueSetterGenerator*/
public static T PlacementGravity<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.PlacementGravity = value);

/*BindFromExpressionSetterGenerator*/
public static T PlacementGravity<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PlacementGravity<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>> getter, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PlacementGravity<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementGravity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Placement

/*ValueSetterGenerator*/
public static T Placement<T>(this T control, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.Placement = value);

/*BindFromExpressionSetterGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Placement<T>(this T control, Func<ValueTask<Avalonia.Controls.PlacementMode>> getter, Func<Avalonia.Controls.PlacementMode>? fallbackGetter = null, Action<Avalonia.Controls.PlacementMode>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Placement<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlacementRect

/*ValueSetterGenerator*/
public static T PlacementRect<T>(this T control, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.PlacementRect = value);

/*BindFromExpressionSetterGenerator*/
public static T PlacementRect<T>(this T control, Func<System.Nullable<Avalonia.Rect>> func, Action<System.Nullable<Avalonia.Rect>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PlacementRect<T>(this T control, Func<ValueTask<System.Nullable<Avalonia.Rect>>> getter, Func<System.Nullable<Avalonia.Rect>>? fallbackGetter = null, Action<System.Nullable<Avalonia.Rect>>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PlacementRect<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // WindowManagerAddShadowHint

/*ValueSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.WindowManagerAddShadowHint = value);

/*BindFromExpressionSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlacementTarget

/*ValueSetterGenerator*/
public static T PlacementTarget<T>(this T control, Avalonia.Controls.Control? value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.PlacementTarget = value);

/*BindFromExpressionSetterGenerator*/
public static T PlacementTarget<T>(this T control, Func<Avalonia.Controls.Control?> func, Action<Avalonia.Controls.Control?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PlacementTarget<T>(this T control, Func<ValueTask<Avalonia.Controls.Control?>> getter, Func<Avalonia.Controls.Control?>? fallbackGetter = null, Action<Avalonia.Controls.Control?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PlacementTarget<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementTarget<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CustomPopupPlacementCallback

/*ValueSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback? value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.CustomPopupPlacementCallback = value);

/*BindFromExpressionSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback?> func, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback?>> getter, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback?>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // Opening

/*ActionToEventGenerator*/
public static T OnOpening<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.ContextMenu  => 
 control._setEvent((System.ComponentModel.CancelEventHandler) ((arg0, arg1) => action(arg1)), h => control.Opening += h);


 // Closing

/*ActionToEventGenerator*/
public static T OnClosing<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.ContextMenu  => 
 control._setEvent((System.ComponentModel.CancelEventHandler) ((arg0, arg1) => action(arg1)), h => control.Closing += h);



//================= Styles ======================//
 // HorizontalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, binding);


 // VerticalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.VerticalOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, binding);


 // PlacementAnchor

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementAnchorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, binding);


 // PlacementConstraintAdjustment

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, binding);


 // PlacementGravity

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementGravityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementGravityProperty, binding);


 // Placement

/*ValueStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementProperty, binding);


 // PlacementRect

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementRectProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementRectProperty, binding);


 // WindowManagerAddShadowHint

/*ValueStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, binding);


 // PlacementTarget

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, Avalonia.Controls.Control? value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementTargetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementTargetProperty, binding);


 // CustomPopupPlacementCallback

/*ValueStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback? value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty, binding);



}
