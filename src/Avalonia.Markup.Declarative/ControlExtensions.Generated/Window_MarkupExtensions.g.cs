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
public static partial class Window_MarkupExtensions
{
//================= Properties ======================//
 // SizeToContent

/*ValueSetterGenerator*/
public static T SizeToContent<T>(this T control, Avalonia.Controls.SizeToContent value) where T : Avalonia.Controls.Window 
=> control._set(() => control.SizeToContent = value);

/*BindFromExpressionSetterGenerator*/
public static T SizeToContent<T>(this T control, Func<Avalonia.Controls.SizeToContent> func, Action<Avalonia.Controls.SizeToContent>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SizeToContentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SizeToContent<T>(this T control, Func<ValueTask<Avalonia.Controls.SizeToContent>> getter, Func<Avalonia.Controls.SizeToContent>? fallbackGetter = null, Action<Avalonia.Controls.SizeToContent>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SizeToContentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SizeToContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SizeToContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SizeToContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SizeToContentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ExtendClientAreaToDecorationsHint

/*ValueSetterGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ExtendClientAreaToDecorationsHint = value);

/*BindFromExpressionSetterGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ExtendClientAreaChromeHints

/*ValueSetterGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, Avalonia.Platform.ExtendClientAreaChromeHints value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ExtendClientAreaChromeHints = value);

/*BindFromExpressionSetterGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, Func<Avalonia.Platform.ExtendClientAreaChromeHints> func, Action<Avalonia.Platform.ExtendClientAreaChromeHints>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, Func<ValueTask<Avalonia.Platform.ExtendClientAreaChromeHints>> getter, Func<Avalonia.Platform.ExtendClientAreaChromeHints>? fallbackGetter = null, Action<Avalonia.Platform.ExtendClientAreaChromeHints>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ExtendClientAreaTitleBarHeightHint

/*ValueSetterGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, System.Double value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ExtendClientAreaTitleBarHeightHint = value);

/*BindFromExpressionSetterGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SystemDecorations

/*ValueSetterGenerator*/
public static T SystemDecorations<T>(this T control, Avalonia.Controls.SystemDecorations value) where T : Avalonia.Controls.Window 
=> control._set(() => control.SystemDecorations = value);

/*BindFromExpressionSetterGenerator*/
public static T SystemDecorations<T>(this T control, Func<Avalonia.Controls.SystemDecorations> func, Action<Avalonia.Controls.SystemDecorations>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SystemDecorationsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SystemDecorations<T>(this T control, Func<ValueTask<Avalonia.Controls.SystemDecorations>> getter, Func<Avalonia.Controls.SystemDecorations>? fallbackGetter = null, Action<Avalonia.Controls.SystemDecorations>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SystemDecorationsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SystemDecorations<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SystemDecorationsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SystemDecorations<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SystemDecorationsProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ShowActivated

/*ValueSetterGenerator*/
public static T ShowActivated<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ShowActivated = value);

/*BindFromExpressionSetterGenerator*/
public static T ShowActivated<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowActivatedProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ShowActivated<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowActivatedProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ShowActivated<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowActivatedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowActivated<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowActivatedProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ShowInTaskbar

/*ValueSetterGenerator*/
public static T ShowInTaskbar<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ShowInTaskbar = value);

/*BindFromExpressionSetterGenerator*/
public static T ShowInTaskbar<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowInTaskbarProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ShowInTaskbar<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowInTaskbarProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ShowInTaskbar<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowInTaskbarProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowInTaskbar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowInTaskbarProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ClosingBehavior

/*ValueSetterGenerator*/
public static T ClosingBehavior<T>(this T control, Avalonia.Controls.WindowClosingBehavior value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ClosingBehavior = value);

/*BindFromExpressionSetterGenerator*/
public static T ClosingBehavior<T>(this T control, Func<Avalonia.Controls.WindowClosingBehavior> func, Action<Avalonia.Controls.WindowClosingBehavior>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ClosingBehaviorProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ClosingBehavior<T>(this T control, Func<ValueTask<Avalonia.Controls.WindowClosingBehavior>> getter, Func<Avalonia.Controls.WindowClosingBehavior>? fallbackGetter = null, Action<Avalonia.Controls.WindowClosingBehavior>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ClosingBehaviorProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ClosingBehavior<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ClosingBehaviorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClosingBehavior<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ClosingBehaviorProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // WindowState

/*ValueSetterGenerator*/
public static T WindowState<T>(this T control, Avalonia.Controls.WindowState value) where T : Avalonia.Controls.Window 
=> control._set(() => control.WindowState = value);

/*BindFromExpressionSetterGenerator*/
public static T WindowState<T>(this T control, Func<Avalonia.Controls.WindowState> func, Action<Avalonia.Controls.WindowState>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T WindowState<T>(this T control, Func<ValueTask<Avalonia.Controls.WindowState>> getter, Func<Avalonia.Controls.WindowState>? fallbackGetter = null, Action<Avalonia.Controls.WindowState>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T WindowState<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T WindowState<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStateProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Title

/*ValueSetterGenerator*/
public static T Title<T>(this T control, System.String? value) where T : Avalonia.Controls.Window 
=> control._set(() => control.Title = value);

/*BindFromExpressionSetterGenerator*/
public static T Title<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.TitleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Title<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.TitleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Title<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.TitleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, Avalonia.Controls.WindowIcon? value) where T : Avalonia.Controls.Window 
=> control._set(() => control.Icon = value);

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<Avalonia.Controls.WindowIcon?> func, Action<Avalonia.Controls.WindowIcon?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.IconProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Icon<T>(this T control, Func<ValueTask<Avalonia.Controls.WindowIcon?>> getter, Func<Avalonia.Controls.WindowIcon?>? fallbackGetter = null, Action<Avalonia.Controls.WindowIcon?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.IconProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // WindowStartupLocation

/*ValueSetterGenerator*/
public static T WindowStartupLocation<T>(this T control, Avalonia.Controls.WindowStartupLocation value) where T : Avalonia.Controls.Window 
=> control._set(() => control.WindowStartupLocation = value);

/*BindFromExpressionSetterGenerator*/
public static T WindowStartupLocation<T>(this T control, Func<Avalonia.Controls.WindowStartupLocation> func, Action<Avalonia.Controls.WindowStartupLocation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStartupLocationProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T WindowStartupLocation<T>(this T control, Func<ValueTask<Avalonia.Controls.WindowStartupLocation>> getter, Func<Avalonia.Controls.WindowStartupLocation>? fallbackGetter = null, Action<Avalonia.Controls.WindowStartupLocation>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStartupLocationProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T WindowStartupLocation<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStartupLocationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T WindowStartupLocation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStartupLocationProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CanResize

/*ValueSetterGenerator*/
public static T CanResize<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.CanResize = value);

/*BindFromExpressionSetterGenerator*/
public static T CanResize<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanResizeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CanResize<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanResizeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CanResize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanResizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanResize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanResizeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CanMinimize

/*ValueSetterGenerator*/
public static T CanMinimize<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.CanMinimize = value);

/*BindFromExpressionSetterGenerator*/
public static T CanMinimize<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMinimizeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CanMinimize<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMinimizeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CanMinimize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMinimizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanMinimize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMinimizeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CanMaximize

/*ValueSetterGenerator*/
public static T CanMaximize<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.CanMaximize = value);

/*BindFromExpressionSetterGenerator*/
public static T CanMaximize<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMaximizeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CanMaximize<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMaximizeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CanMaximize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMaximizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanMaximize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMaximizeProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // Closing

/*ActionToEventGenerator*/
public static T OnClosing<T>(this T control, Action<Avalonia.Controls.WindowClosingEventArgs> action) where T : Avalonia.Controls.Window  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.WindowClosingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closing += h);



//================= Styles ======================//
 // SizeToContent

/*ValueStyleSetterGenerator*/
public static Style<T> SizeToContent<T>(this Style<T> style, Avalonia.Controls.SizeToContent value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SizeToContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SizeToContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SizeToContentProperty, binding);


 // ExtendClientAreaToDecorationsHint

/*ValueStyleSetterGenerator*/
public static Style<T> ExtendClientAreaToDecorationsHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExtendClientAreaToDecorationsHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, binding);


 // ExtendClientAreaChromeHints

/*ValueStyleSetterGenerator*/
public static Style<T> ExtendClientAreaChromeHints<T>(this Style<T> style, Avalonia.Platform.ExtendClientAreaChromeHints value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExtendClientAreaChromeHints<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, binding);


 // ExtendClientAreaTitleBarHeightHint

/*ValueStyleSetterGenerator*/
public static Style<T> ExtendClientAreaTitleBarHeightHint<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExtendClientAreaTitleBarHeightHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, binding);


 // SystemDecorations

/*ValueStyleSetterGenerator*/
public static Style<T> SystemDecorations<T>(this Style<T> style, Avalonia.Controls.SystemDecorations value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SystemDecorationsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SystemDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SystemDecorationsProperty, binding);


 // ShowActivated

/*ValueStyleSetterGenerator*/
public static Style<T> ShowActivated<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowActivatedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowActivated<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowActivatedProperty, binding);


 // ShowInTaskbar

/*ValueStyleSetterGenerator*/
public static Style<T> ShowInTaskbar<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowInTaskbarProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowInTaskbar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowInTaskbarProperty, binding);


 // ClosingBehavior

/*ValueStyleSetterGenerator*/
public static Style<T> ClosingBehavior<T>(this Style<T> style, Avalonia.Controls.WindowClosingBehavior value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ClosingBehaviorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClosingBehavior<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ClosingBehaviorProperty, binding);


 // WindowState

/*ValueStyleSetterGenerator*/
public static Style<T> WindowState<T>(this Style<T> style, Avalonia.Controls.WindowState value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowState<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStateProperty, binding);


 // Title

/*ValueStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.TitleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.TitleProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, Avalonia.Controls.WindowIcon? value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.IconProperty, binding);


 // WindowStartupLocation

/*ValueStyleSetterGenerator*/
public static Style<T> WindowStartupLocation<T>(this Style<T> style, Avalonia.Controls.WindowStartupLocation value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStartupLocationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowStartupLocation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStartupLocationProperty, binding);


 // CanResize

/*ValueStyleSetterGenerator*/
public static Style<T> CanResize<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanResizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanResize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanResizeProperty, binding);


 // CanMinimize

/*ValueStyleSetterGenerator*/
public static Style<T> CanMinimize<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanMinimizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanMinimize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanMinimizeProperty, binding);


 // CanMaximize

/*ValueStyleSetterGenerator*/
public static Style<T> CanMaximize<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanMaximizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanMaximize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanMaximizeProperty, binding);



}
