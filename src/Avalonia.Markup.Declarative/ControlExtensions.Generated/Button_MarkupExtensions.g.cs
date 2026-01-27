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
public static partial class Button_MarkupExtensions
{
//================= Properties ======================//
 // ClickMode

/*ValueSetterGenerator*/
public static T ClickMode<T>(this T control, Avalonia.Controls.ClickMode value) where T : Avalonia.Controls.Button 
=> control._set(() => control.ClickMode = value);

/*BindFromExpressionSetterGenerator*/
public static T ClickMode<T>(this T control, Func<Avalonia.Controls.ClickMode> func, Action<Avalonia.Controls.ClickMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.ClickModeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ClickMode<T>(this T control, Func<ValueTask<Avalonia.Controls.ClickMode>> getter, Func<Avalonia.Controls.ClickMode>? fallbackGetter = null, Action<Avalonia.Controls.ClickMode>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.ClickModeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ClickMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.ClickModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClickMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.ClickModeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand? value) where T : Avalonia.Controls.Button 
=> control._set(() => control.Command = value);

/*BindFromExpressionSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand?> func, Action<System.Windows.Input.ICommand?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Command<T>(this T control, Func<ValueTask<System.Windows.Input.ICommand?>> getter, Func<System.Windows.Input.ICommand?>? fallbackGetter = null, Action<System.Windows.Input.ICommand?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HotKey

/*ValueSetterGenerator*/
public static T HotKey<T>(this T control, Avalonia.Input.KeyGesture? value) where T : Avalonia.Controls.Button 
=> control._set(() => control.HotKey = value);

/*BindFromExpressionSetterGenerator*/
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture?> func, Action<Avalonia.Input.KeyGesture?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.HotKeyProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HotKey<T>(this T control, Func<ValueTask<Avalonia.Input.KeyGesture?>> getter, Func<Avalonia.Input.KeyGesture?>? fallbackGetter = null, Action<Avalonia.Input.KeyGesture?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.HotKeyProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HotKey<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.HotKeyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HotKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object? value) where T : Avalonia.Controls.Button 
=> control._set(() => control.CommandParameter = value);

/*BindFromExpressionSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandParameterProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandParameterProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsDefault

/*ValueSetterGenerator*/
public static T IsDefault<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Button 
=> control._set(() => control.IsDefault = value);

/*BindFromExpressionSetterGenerator*/
public static T IsDefault<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsDefaultProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsDefault<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsDefaultProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsDefault<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsDefaultProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDefault<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsDefaultProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsCancel

/*ValueSetterGenerator*/
public static T IsCancel<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Button 
=> control._set(() => control.IsCancel = value);

/*BindFromExpressionSetterGenerator*/
public static T IsCancel<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsCancelProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsCancel<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsCancelProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsCancel<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsCancelProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsCancel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsCancelProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Flyout

/*ValueSetterGenerator*/
public static T Flyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase? value) where T : Avalonia.Controls.Button 
=> control._set(() => control.Flyout = value);

/*BindFromExpressionSetterGenerator*/
public static T Flyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase?> func, Action<Avalonia.Controls.Primitives.FlyoutBase?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.FlyoutProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Flyout<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.FlyoutBase?>> getter, Func<Avalonia.Controls.Primitives.FlyoutBase?>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.FlyoutBase?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.FlyoutProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Flyout<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.FlyoutProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Flyout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.FlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Button 
{
  control.AddHandler(Avalonia.Controls.Button.ClickEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Button.ClickEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // ClickMode

/*ValueStyleSetterGenerator*/
public static Style<T> ClickMode<T>(this Style<T> style, Avalonia.Controls.ClickMode value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.ClickModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClickMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.ClickModeProperty, binding);


 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand? value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandProperty, binding);


 // HotKey

/*ValueStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture? value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.HotKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.HotKeyProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandParameterProperty, binding);


 // IsDefault

/*ValueStyleSetterGenerator*/
public static Style<T> IsDefault<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsDefaultProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDefault<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsDefaultProperty, binding);


 // IsCancel

/*ValueStyleSetterGenerator*/
public static Style<T> IsCancel<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsCancelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsCancel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsCancelProperty, binding);


 // Flyout

/*ValueStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase? value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.FlyoutProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.FlyoutProperty, binding);



}
