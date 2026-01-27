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
public static partial class Popup_MarkupExtensions
{
//================= Properties ======================//
 // WindowManagerAddShadowHint

/*ValueSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.WindowManagerAddShadowHint = value);

/*BindFromExpressionSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Child

/*ValueSetterGenerator*/
public static T Child<T>(this T control, Avalonia.Controls.Control? value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.Child = value);

/*BindFromExpressionSetterGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control?> func, Action<Avalonia.Controls.Control?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ChildProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Child<T>(this T control, Func<ValueTask<Avalonia.Controls.Control?>> getter, Func<Avalonia.Controls.Control?>? fallbackGetter = null, Action<Avalonia.Controls.Control?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ChildProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Child<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ChildProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Child<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // InheritsTransform

/*ValueSetterGenerator*/
public static T InheritsTransform<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.InheritsTransform = value);

/*BindFromExpressionSetterGenerator*/
public static T InheritsTransform<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T InheritsTransform<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T InheritsTransform<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InheritsTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsOpen

/*ValueSetterGenerator*/
public static T IsOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.IsOpen = value);

/*BindFromExpressionSetterGenerator*/
public static T IsOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsOpenProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsOpen<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsOpenProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlacementAnchor

/*ValueSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.PlacementAnchor = value);

/*BindFromExpressionSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>> getter, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PlacementAnchor<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementAnchor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlacementConstraintAdjustment

/*ValueSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.PlacementConstraintAdjustment = value);

/*BindFromExpressionSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>> getter, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlacementGravity

/*ValueSetterGenerator*/
public static T PlacementGravity<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.PlacementGravity = value);

/*BindFromExpressionSetterGenerator*/
public static T PlacementGravity<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PlacementGravity<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>> getter, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PlacementGravity<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementGravity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Placement

/*ValueSetterGenerator*/
public static T Placement<T>(this T control, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.Placement = value);

/*BindFromExpressionSetterGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Placement<T>(this T control, Func<ValueTask<Avalonia.Controls.PlacementMode>> getter, Func<Avalonia.Controls.PlacementMode>? fallbackGetter = null, Action<Avalonia.Controls.PlacementMode>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Placement<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlacementRect

/*ValueSetterGenerator*/
public static T PlacementRect<T>(this T control, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.PlacementRect = value);

/*BindFromExpressionSetterGenerator*/
public static T PlacementRect<T>(this T control, Func<System.Nullable<Avalonia.Rect>> func, Action<System.Nullable<Avalonia.Rect>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementRectProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PlacementRect<T>(this T control, Func<ValueTask<System.Nullable<Avalonia.Rect>>> getter, Func<System.Nullable<Avalonia.Rect>>? fallbackGetter = null, Action<System.Nullable<Avalonia.Rect>>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementRectProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PlacementRect<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlacementTarget

/*ValueSetterGenerator*/
public static T PlacementTarget<T>(this T control, Avalonia.Controls.Control? value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.PlacementTarget = value);

/*BindFromExpressionSetterGenerator*/
public static T PlacementTarget<T>(this T control, Func<Avalonia.Controls.Control?> func, Action<Avalonia.Controls.Control?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PlacementTarget<T>(this T control, Func<ValueTask<Avalonia.Controls.Control?>> getter, Func<Avalonia.Controls.Control?>? fallbackGetter = null, Action<Avalonia.Controls.Control?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PlacementTarget<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementTarget<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CustomPopupPlacementCallback

/*ValueSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback? value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.CustomPopupPlacementCallback = value);

/*BindFromExpressionSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback?> func, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback?>> getter, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback?>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // OverlayDismissEventPassThrough

/*ValueSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.OverlayDismissEventPassThrough = value);

/*BindFromExpressionSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // OverlayInputPassThroughElement

/*ValueSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Avalonia.Input.IInputElement? value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.OverlayInputPassThroughElement = value);

/*BindFromExpressionSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Func<Avalonia.Input.IInputElement?> func, Action<Avalonia.Input.IInputElement?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Func<ValueTask<Avalonia.Input.IInputElement?>> getter, Func<Avalonia.Input.IInputElement?>? fallbackGetter = null, Action<Avalonia.Input.IInputElement?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HorizontalOffset

/*ValueSetterGenerator*/
public static T HorizontalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.HorizontalOffset = value);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HorizontalOffset<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HorizontalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsLightDismissEnabled

/*ValueSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.IsLightDismissEnabled = value);

/*BindFromExpressionSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // VerticalOffset

/*ValueSetterGenerator*/
public static T VerticalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.VerticalOffset = value);

/*BindFromExpressionSetterGenerator*/
public static T VerticalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T VerticalOffset<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T VerticalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Topmost

/*ValueSetterGenerator*/
public static T Topmost<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.Topmost = value);

/*BindFromExpressionSetterGenerator*/
public static T Topmost<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TopmostProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Topmost<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TopmostProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Topmost<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TopmostProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Topmost<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TopmostProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // TakesFocusFromNativeControl

/*ValueSetterGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.TakesFocusFromNativeControl = value);

/*BindFromExpressionSetterGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ShouldUseOverlayLayer

/*ValueSetterGenerator*/
public static T ShouldUseOverlayLayer<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.ShouldUseOverlayLayer = value);

/*BindFromExpressionSetterGenerator*/
public static T ShouldUseOverlayLayer<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ShouldUseOverlayLayer<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ShouldUseOverlayLayer<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShouldUseOverlayLayer<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Attached Properties ======================//
 // TakesFocusFromNativeControl

/*AttachedPropertyMagicalSetterGenerator*/
public static T Popup_TakesFocusFromNativeControl<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, ps, () => Avalonia.Controls.Primitives.Popup.SetTakesFocusFromNativeControl(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Popup_TakesFocusFromNativeControl<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, func, onChanged, expression);



//================= Events ======================//
 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.Popup  => 
 control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closed += h);


 // Opened

/*ActionToEventGenerator*/
public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.Popup  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);



//================= Styles ======================//
 // WindowManagerAddShadowHint

/*ValueStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, binding);


 // Child

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control? value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ChildProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ChildProperty, binding);


 // InheritsTransform

/*ValueStyleSetterGenerator*/
public static Style<T> InheritsTransform<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InheritsTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, binding);


 // IsOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsOpenProperty, binding);


 // PlacementAnchor

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, binding);


 // PlacementConstraintAdjustment

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, binding);


 // PlacementGravity

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, binding);


 // Placement

/*ValueStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementProperty, binding);


 // PlacementRect

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementRectProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, binding);


 // PlacementTarget

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, Avalonia.Controls.Control? value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, binding);


 // CustomPopupPlacementCallback

/*ValueStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback? value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, binding);


 // OverlayDismissEventPassThrough

/*ValueStyleSetterGenerator*/
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, binding);


 // OverlayInputPassThroughElement

/*ValueStyleSetterGenerator*/
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, Avalonia.Input.IInputElement? value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, binding);


 // HorizontalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, binding);


 // IsLightDismissEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, binding);


 // VerticalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, binding);


 // Topmost

/*ValueStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TopmostProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TopmostProperty, binding);


 // TakesFocusFromNativeControl

/*ValueStyleSetterGenerator*/
public static Style<T> TakesFocusFromNativeControl<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TakesFocusFromNativeControl<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, binding);


 // ShouldUseOverlayLayer

/*ValueStyleSetterGenerator*/
public static Style<T> ShouldUseOverlayLayer<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShouldUseOverlayLayer<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty, binding);



}
