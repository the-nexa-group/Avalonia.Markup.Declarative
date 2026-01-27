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
public static partial class Control_MarkupExtensions
{
//================= Properties ======================//
 // FocusAdorner

/*ValueSetterGenerator*/
public static T FocusAdorner<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control>? value) where T : Avalonia.Controls.Control 
=> control._set(() => control.FocusAdorner = value);

/*BindFromExpressionSetterGenerator*/
public static T FocusAdorner<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>?> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.FocusAdornerProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T FocusAdorner<T>(this T control, Func<ValueTask<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>?>> getter, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>?>? fallbackGetter = null, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.FocusAdornerProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T FocusAdorner<T>(this T control, IBinding binding) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.FocusAdornerProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FocusAdorner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.FocusAdornerProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Tag

/*ValueSetterGenerator*/
public static T Tag<T>(this T control, System.Object? value) where T : Avalonia.Controls.Control 
=> control._set(() => control.Tag = value);

/*BindFromExpressionSetterGenerator*/
public static T Tag<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.TagProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Tag<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.TagProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Tag<T>(this T control, IBinding binding) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.TagProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Tag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.TagProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ContextMenu

/*ValueSetterGenerator*/
public static T ContextMenu<T>(this T control, Avalonia.Controls.ContextMenu? value) where T : Avalonia.Controls.Control 
=> control._set(() => control.ContextMenu = value);

/*BindFromExpressionSetterGenerator*/
public static T ContextMenu<T>(this T control, Func<Avalonia.Controls.ContextMenu?> func, Action<Avalonia.Controls.ContextMenu?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextMenuProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ContextMenu<T>(this T control, Func<ValueTask<Avalonia.Controls.ContextMenu?>> getter, Func<Avalonia.Controls.ContextMenu?>? fallbackGetter = null, Action<Avalonia.Controls.ContextMenu?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextMenuProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ContextMenu<T>(this T control, IBinding binding) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextMenuProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContextMenu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextMenuProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ContextFlyout

/*ValueSetterGenerator*/
public static T ContextFlyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase? value) where T : Avalonia.Controls.Control 
=> control._set(() => control.ContextFlyout = value);

/*BindFromExpressionSetterGenerator*/
public static T ContextFlyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase?> func, Action<Avalonia.Controls.Primitives.FlyoutBase?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextFlyoutProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ContextFlyout<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.FlyoutBase?>> getter, Func<Avalonia.Controls.Primitives.FlyoutBase?>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.FlyoutBase?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextFlyoutProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ContextFlyout<T>(this T control, IBinding binding) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextFlyoutProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContextFlyout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextFlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // ContextRequested

/*ActionToEventGenerator*/
public static T OnContextRequested<T>(this T control, Action<Avalonia.Controls.ContextRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.ContextRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Control.ContextRequestedEvent.RoutingStrategies);
  return control;
}



 // Loaded

/*ActionToEventGenerator*/
public static T OnLoaded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.LoadedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Control.LoadedEvent.RoutingStrategies);
  return control;
}



 // Unloaded

/*ActionToEventGenerator*/
public static T OnUnloaded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.UnloadedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Control.UnloadedEvent.RoutingStrategies);
  return control;
}



 // SizeChanged

/*ActionToEventGenerator*/
public static T OnSizeChanged<T>(this T control, Action<Avalonia.Controls.SizeChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.SizeChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Control.SizeChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // FocusAdorner

/*ValueStyleSetterGenerator*/
public static Style<T> FocusAdorner<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control>? value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.FocusAdornerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FocusAdorner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.FocusAdornerProperty, binding);


 // Tag

/*ValueStyleSetterGenerator*/
public static Style<T> Tag<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.TagProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Tag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.TagProperty, binding);


 // ContextMenu

/*ValueStyleSetterGenerator*/
public static Style<T> ContextMenu<T>(this Style<T> style, Avalonia.Controls.ContextMenu? value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextMenuProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContextMenu<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextMenuProperty, binding);


 // ContextFlyout

/*ValueStyleSetterGenerator*/
public static Style<T> ContextFlyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase? value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextFlyoutProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContextFlyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextFlyoutProperty, binding);



}
