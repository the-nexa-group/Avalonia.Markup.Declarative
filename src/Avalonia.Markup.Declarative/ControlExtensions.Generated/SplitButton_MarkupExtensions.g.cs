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
public static partial class SplitButton_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand? value) where T : Avalonia.Controls.SplitButton 
=> control._set(() => control.Command = value);

/*BindFromExpressionSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand?> func, Action<System.Windows.Input.ICommand?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Command<T>(this T control, Func<ValueTask<System.Windows.Input.ICommand?>> getter, Func<System.Windows.Input.ICommand?>? fallbackGetter = null, Action<System.Windows.Input.ICommand?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object? value) where T : Avalonia.Controls.SplitButton 
=> control._set(() => control.CommandParameter = value);

/*BindFromExpressionSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandParameterProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandParameterProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Flyout

/*ValueSetterGenerator*/
public static T Flyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase? value) where T : Avalonia.Controls.SplitButton 
=> control._set(() => control.Flyout = value);

/*BindFromExpressionSetterGenerator*/
public static T Flyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase?> func, Action<Avalonia.Controls.Primitives.FlyoutBase?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.FlyoutProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Flyout<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.FlyoutBase?>> getter, Func<Avalonia.Controls.Primitives.FlyoutBase?>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.FlyoutBase?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.FlyoutProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Flyout<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.FlyoutProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Flyout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.FlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HotKey

/*ValueSetterGenerator*/
public static T HotKey<T>(this T control, Avalonia.Input.KeyGesture? value) where T : Avalonia.Controls.SplitButton 
=> control._set(() => control.HotKey = value);

/*BindFromExpressionSetterGenerator*/
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture?> func, Action<Avalonia.Input.KeyGesture?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.HotKeyProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HotKey<T>(this T control, Func<ValueTask<Avalonia.Input.KeyGesture?>> getter, Func<Avalonia.Input.KeyGesture?>? fallbackGetter = null, Action<Avalonia.Input.KeyGesture?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.HotKeyProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HotKey<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.HotKeyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HotKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitButton 
{
  control.AddHandler(Avalonia.Controls.SplitButton.ClickEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitButton.ClickEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand? value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandParameterProperty, binding);


 // Flyout

/*ValueStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase? value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.FlyoutProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.FlyoutProperty, binding);


 // HotKey

/*ValueStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture? value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.HotKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.HotKeyProperty, binding);



}
