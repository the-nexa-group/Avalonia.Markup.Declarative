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
public static partial class NativeMenuItem_MarkupExtensions
{
//================= Properties ======================//
 // Menu

/*ValueSetterGenerator*/
public static T Menu<T>(this T control, Avalonia.Controls.NativeMenu? value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Menu = value);

/*BindFromExpressionSetterGenerator*/
public static T Menu<T>(this T control, Func<Avalonia.Controls.NativeMenu?> func, Action<Avalonia.Controls.NativeMenu?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.MenuProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Menu<T>(this T control, Func<ValueTask<Avalonia.Controls.NativeMenu?>> getter, Func<Avalonia.Controls.NativeMenu?>? fallbackGetter = null, Action<Avalonia.Controls.NativeMenu?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.MenuProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Menu<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.MenuProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Menu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.MenuProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, Avalonia.Media.Imaging.Bitmap? value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Icon = value);

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<Avalonia.Media.Imaging.Bitmap?> func, Action<Avalonia.Media.Imaging.Bitmap?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IconProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Icon<T>(this T control, Func<ValueTask<Avalonia.Media.Imaging.Bitmap?>> getter, Func<Avalonia.Media.Imaging.Bitmap?>? fallbackGetter = null, Action<Avalonia.Media.Imaging.Bitmap?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IconProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Header

/*ValueSetterGenerator*/
public static T Header<T>(this T control, System.String? value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Header = value);

/*BindFromExpressionSetterGenerator*/
public static T Header<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.HeaderProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Header<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.HeaderProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Header<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.HeaderProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Header<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ToolTip

/*ValueSetterGenerator*/
public static T ToolTip<T>(this T control, System.String? value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.ToolTip = value);

/*BindFromExpressionSetterGenerator*/
public static T ToolTip<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToolTipProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ToolTip<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToolTipProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ToolTip<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToolTipProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ToolTip<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToolTipProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Gesture

/*ValueSetterGenerator*/
public static T Gesture<T>(this T control, Avalonia.Input.KeyGesture? value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Gesture = value);

/*BindFromExpressionSetterGenerator*/
public static T Gesture<T>(this T control, Func<Avalonia.Input.KeyGesture?> func, Action<Avalonia.Input.KeyGesture?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.GestureProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Gesture<T>(this T control, Func<ValueTask<Avalonia.Input.KeyGesture?>> getter, Func<Avalonia.Input.KeyGesture?>? fallbackGetter = null, Action<Avalonia.Input.KeyGesture?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.GestureProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Gesture<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.GestureProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Gesture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.GestureProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsChecked

/*ValueSetterGenerator*/
public static T IsChecked<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.IsChecked = value);

/*BindFromExpressionSetterGenerator*/
public static T IsChecked<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsCheckedProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsChecked<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsCheckedProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsChecked<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsCheckedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsChecked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ToggleType

/*ValueSetterGenerator*/
public static T ToggleType<T>(this T control, Avalonia.Controls.NativeMenuItemToggleType value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.ToggleType = value);

/*BindFromExpressionSetterGenerator*/
public static T ToggleType<T>(this T control, Func<Avalonia.Controls.NativeMenuItemToggleType> func, Action<Avalonia.Controls.NativeMenuItemToggleType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ToggleType<T>(this T control, Func<ValueTask<Avalonia.Controls.NativeMenuItemToggleType>> getter, Func<Avalonia.Controls.NativeMenuItemToggleType>? fallbackGetter = null, Action<Avalonia.Controls.NativeMenuItemToggleType>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ToggleType<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ToggleType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand? value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Command = value);

/*BindFromExpressionSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand?> func, Action<System.Windows.Input.ICommand?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Command<T>(this T control, Func<ValueTask<System.Windows.Input.ICommand?>> getter, Func<System.Windows.Input.ICommand?>? fallbackGetter = null, Action<System.Windows.Input.ICommand?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object? value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.CommandParameter = value);

/*BindFromExpressionSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandParameterProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandParameterProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsEnabled

/*ValueSetterGenerator*/
public static T IsEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.IsEnabled = value);

/*BindFromExpressionSetterGenerator*/
public static T IsEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsEnabledProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsEnabled<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsEnabledProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsVisible

/*ValueSetterGenerator*/
public static T IsVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.IsVisible = value);

/*BindFromExpressionSetterGenerator*/
public static T IsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsVisibleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsVisible<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsVisibleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenuItem  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Click += h);



}
