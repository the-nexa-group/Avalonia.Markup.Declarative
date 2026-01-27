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
public static partial class ScrollGestureRecognizer_MarkupExtensions
{
//================= Properties ======================//
 // CanHorizontallyScroll

/*ValueSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._set(() => control.CanHorizontallyScroll = value);

/*BindFromExpressionSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, IBinding binding) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CanVerticallyScroll

/*ValueSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._set(() => control.CanVerticallyScroll = value);

/*BindFromExpressionSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, IBinding binding) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsScrollInertiaEnabled

/*ValueSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._set(() => control.IsScrollInertiaEnabled = value);

/*BindFromExpressionSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, IBinding binding) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ScrollStartDistance

/*ValueSetterGenerator*/
public static T ScrollStartDistance<T>(this T control, System.Int32 value) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._set(() => control.ScrollStartDistance = value);

/*BindFromExpressionSetterGenerator*/
public static T ScrollStartDistance<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ScrollStartDistance<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ScrollStartDistance<T>(this T control, IBinding binding) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ScrollStartDistance<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
