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
public static partial class MenuItem_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand? value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.Command = value);

/*BindFromExpressionSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand?> func, Action<System.Windows.Input.ICommand?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Command<T>(this T control, Func<ValueTask<System.Windows.Input.ICommand?>> getter, Func<System.Windows.Input.ICommand?>? fallbackGetter = null, Action<System.Windows.Input.ICommand?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HotKey

/*ValueSetterGenerator*/
public static T HotKey<T>(this T control, Avalonia.Input.KeyGesture? value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.HotKey = value);

/*BindFromExpressionSetterGenerator*/
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture?> func, Action<Avalonia.Input.KeyGesture?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.HotKeyProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HotKey<T>(this T control, Func<ValueTask<Avalonia.Input.KeyGesture?>> getter, Func<Avalonia.Input.KeyGesture?>? fallbackGetter = null, Action<Avalonia.Input.KeyGesture?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.HotKeyProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HotKey<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.HotKeyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HotKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object? value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.CommandParameter = value);

/*BindFromExpressionSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandParameterProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandParameterProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, System.Object? value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.Icon = value);

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IconProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Icon<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IconProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // InputGesture

/*ValueSetterGenerator*/
public static T InputGesture<T>(this T control, Avalonia.Input.KeyGesture? value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.InputGesture = value);

/*BindFromExpressionSetterGenerator*/
public static T InputGesture<T>(this T control, Func<Avalonia.Input.KeyGesture?> func, Action<Avalonia.Input.KeyGesture?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.InputGestureProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T InputGesture<T>(this T control, Func<ValueTask<Avalonia.Input.KeyGesture?>> getter, Func<Avalonia.Input.KeyGesture?>? fallbackGetter = null, Action<Avalonia.Input.KeyGesture?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.InputGestureProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T InputGesture<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.InputGestureProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InputGesture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.InputGestureProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsSubMenuOpen

/*ValueSetterGenerator*/
public static T IsSubMenuOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.IsSubMenuOpen = value);

/*BindFromExpressionSetterGenerator*/
public static T IsSubMenuOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsSubMenuOpen<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsSubMenuOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsSubMenuOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // StaysOpenOnClick

/*ValueSetterGenerator*/
public static T StaysOpenOnClick<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.StaysOpenOnClick = value);

/*BindFromExpressionSetterGenerator*/
public static T StaysOpenOnClick<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T StaysOpenOnClick<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T StaysOpenOnClick<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StaysOpenOnClick<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ToggleType

/*ValueSetterGenerator*/
public static T ToggleType<T>(this T control, Avalonia.Controls.MenuItemToggleType value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.ToggleType = value);

/*BindFromExpressionSetterGenerator*/
public static T ToggleType<T>(this T control, Func<Avalonia.Controls.MenuItemToggleType> func, Action<Avalonia.Controls.MenuItemToggleType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.ToggleTypeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ToggleType<T>(this T control, Func<ValueTask<Avalonia.Controls.MenuItemToggleType>> getter, Func<Avalonia.Controls.MenuItemToggleType>? fallbackGetter = null, Action<Avalonia.Controls.MenuItemToggleType>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.ToggleTypeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ToggleType<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.ToggleTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ToggleType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.ToggleTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsChecked

/*ValueSetterGenerator*/
public static T IsChecked<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.IsChecked = value);

/*BindFromExpressionSetterGenerator*/
public static T IsChecked<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsCheckedProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsChecked<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsCheckedProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsChecked<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsCheckedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsChecked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // GroupName

/*ValueSetterGenerator*/
public static T GroupName<T>(this T control, System.String? value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.GroupName = value);

/*BindFromExpressionSetterGenerator*/
public static T GroupName<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.GroupNameProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T GroupName<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.GroupNameProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T GroupName<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.GroupNameProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T GroupName<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.GroupNameProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.MenuItem 
{
  control.AddHandler(Avalonia.Controls.MenuItem.ClickEvent, (_, args) => action(args), routes ?? Avalonia.Controls.MenuItem.ClickEvent.RoutingStrategies);
  return control;
}



 // PointerEnteredItem

/*ActionToEventGenerator*/
public static T OnPointerEnteredItem<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.MenuItem 
{
  control.AddHandler(Avalonia.Controls.MenuItem.PointerEnteredItemEvent, (_, args) => action(args), routes ?? Avalonia.Controls.MenuItem.PointerEnteredItemEvent.RoutingStrategies);
  return control;
}



 // PointerExitedItem

/*ActionToEventGenerator*/
public static T OnPointerExitedItem<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.MenuItem 
{
  control.AddHandler(Avalonia.Controls.MenuItem.PointerExitedItemEvent, (_, args) => action(args), routes ?? Avalonia.Controls.MenuItem.PointerExitedItemEvent.RoutingStrategies);
  return control;
}



 // SubmenuOpened

/*ActionToEventGenerator*/
public static T OnSubmenuOpened<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.MenuItem 
{
  control.AddHandler(Avalonia.Controls.MenuItem.SubmenuOpenedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.MenuItem.SubmenuOpenedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand? value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandProperty, binding);


 // HotKey

/*ValueStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture? value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.HotKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.HotKeyProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandParameterProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IconProperty, binding);


 // InputGesture

/*ValueStyleSetterGenerator*/
public static Style<T> InputGesture<T>(this Style<T> style, Avalonia.Input.KeyGesture? value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.InputGestureProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InputGesture<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.InputGestureProperty, binding);


 // IsSubMenuOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsSubMenuOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSubMenuOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, binding);


 // StaysOpenOnClick

/*ValueStyleSetterGenerator*/
public static Style<T> StaysOpenOnClick<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StaysOpenOnClick<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, binding);


 // ToggleType

/*ValueStyleSetterGenerator*/
public static Style<T> ToggleType<T>(this Style<T> style, Avalonia.Controls.MenuItemToggleType value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.ToggleTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ToggleType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.ToggleTypeProperty, binding);


 // IsChecked

/*ValueStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsCheckedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsCheckedProperty, binding);


 // GroupName

/*ValueStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.GroupNameProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.GroupNameProperty, binding);



}
