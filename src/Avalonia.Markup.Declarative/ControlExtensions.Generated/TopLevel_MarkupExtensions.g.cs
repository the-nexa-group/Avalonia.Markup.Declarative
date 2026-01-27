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
public static partial class TopLevel_MarkupExtensions
{
//================= Properties ======================//
 // TransparencyLevelHint

/*ValueSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel> value) where T : Avalonia.Controls.TopLevel 
=> control._set(() => control.TransparencyLevelHint = value);

/*BindFromExpressionSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, Func<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>> func, Action<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, Func<ValueTask<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>>> getter, Func<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>>? fallbackGetter = null, Action<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // TransparencyBackgroundFallback

/*ValueSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TopLevel 
=> control._set(() => control.TransparencyBackgroundFallback = value);

/*BindFromExpressionSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, Func<ValueTask<Avalonia.Media.IBrush>> getter, Func<Avalonia.Media.IBrush>? fallbackGetter = null, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, IBinding binding) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // RequestedThemeVariant

/*ValueSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Avalonia.Styling.ThemeVariant? value) where T : Avalonia.Controls.TopLevel 
=> control._set(() => control.RequestedThemeVariant = value);

/*BindFromExpressionSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant?> func, Action<Avalonia.Styling.ThemeVariant?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<ValueTask<Avalonia.Styling.ThemeVariant?>> getter, Func<Avalonia.Styling.ThemeVariant?>? fallbackGetter = null, Action<Avalonia.Styling.ThemeVariant?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, IBinding binding) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Attached Properties ======================//
 // SystemBarColor

/*AttachedPropertyMagicalSetterGenerator*/
public static T TopLevel_SystemBarColor<T>(this T control, Avalonia.Media.SolidColorBrush? value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TopLevel.SystemBarColorProperty, ps, () => Avalonia.Controls.TopLevel.SetSystemBarColor(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TopLevel_SystemBarColor<T>(this T control, Func<Avalonia.Media.SolidColorBrush?> func, Action<Avalonia.Media.SolidColorBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TopLevel.SystemBarColorProperty!, func, onChanged, expression);


 // AutoSafeAreaPadding

/*AttachedPropertyMagicalSetterGenerator*/
public static T TopLevel_AutoSafeAreaPadding<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TopLevel.AutoSafeAreaPaddingProperty, ps, () => Avalonia.Controls.TopLevel.SetAutoSafeAreaPadding(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TopLevel_AutoSafeAreaPadding<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TopLevel.AutoSafeAreaPaddingProperty!, func, onChanged, expression);



//================= Events ======================//
 // Opened

/*ActionToEventGenerator*/
public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);


 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Closed += h);


 // ScalingChanged

/*ActionToEventGenerator*/
public static T OnScalingChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ScalingChanged += h);


 // BackRequested

/*ActionToEventGenerator*/
public static T OnBackRequested<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TopLevel 
{
  control.AddHandler(Avalonia.Controls.TopLevel.BackRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TopLevel.BackRequestedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // TransparencyLevelHint

/*ValueStyleSetterGenerator*/
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel> value) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, binding);


 // TransparencyBackgroundFallback

/*ValueStyleSetterGenerator*/
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, binding);


 // RequestedThemeVariant

/*ValueStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, Avalonia.Styling.ThemeVariant? value) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, binding);



}
