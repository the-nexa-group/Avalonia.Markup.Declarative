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
public static partial class SplitView_MarkupExtensions
{
//================= Properties ======================//
 // CompactPaneLength

/*ValueSetterGenerator*/
public static T CompactPaneLength<T>(this T control, System.Double value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.CompactPaneLength = value);

/*BindFromExpressionSetterGenerator*/
public static T CompactPaneLength<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.CompactPaneLengthProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CompactPaneLength<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.CompactPaneLengthProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CompactPaneLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.CompactPaneLengthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CompactPaneLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.CompactPaneLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // DisplayMode

/*ValueSetterGenerator*/
public static T DisplayMode<T>(this T control, Avalonia.Controls.SplitViewDisplayMode value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.DisplayMode = value);

/*BindFromExpressionSetterGenerator*/
public static T DisplayMode<T>(this T control, Func<Avalonia.Controls.SplitViewDisplayMode> func, Action<Avalonia.Controls.SplitViewDisplayMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.DisplayModeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DisplayMode<T>(this T control, Func<ValueTask<Avalonia.Controls.SplitViewDisplayMode>> getter, Func<Avalonia.Controls.SplitViewDisplayMode>? fallbackGetter = null, Action<Avalonia.Controls.SplitViewDisplayMode>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.DisplayModeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T DisplayMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.DisplayModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.DisplayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsPaneOpen

/*ValueSetterGenerator*/
public static T IsPaneOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.IsPaneOpen = value);

/*BindFromExpressionSetterGenerator*/
public static T IsPaneOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.IsPaneOpenProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsPaneOpen<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.IsPaneOpenProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsPaneOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.IsPaneOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsPaneOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.IsPaneOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // OpenPaneLength

/*ValueSetterGenerator*/
public static T OpenPaneLength<T>(this T control, System.Double value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.OpenPaneLength = value);

/*BindFromExpressionSetterGenerator*/
public static T OpenPaneLength<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.OpenPaneLengthProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T OpenPaneLength<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.OpenPaneLengthProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T OpenPaneLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.OpenPaneLengthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OpenPaneLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.OpenPaneLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PaneBackground

/*ValueSetterGenerator*/
public static T PaneBackground<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.PaneBackground = value);

/*BindFromExpressionSetterGenerator*/
public static T PaneBackground<T>(this T control, Func<Avalonia.Media.IBrush?> func, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneBackgroundProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PaneBackground<T>(this T control, Func<ValueTask<Avalonia.Media.IBrush?>> getter, Func<Avalonia.Media.IBrush?>? fallbackGetter = null, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneBackgroundProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PaneBackground<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneBackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PaneBackground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PanePlacement

/*ValueSetterGenerator*/
public static T PanePlacement<T>(this T control, Avalonia.Controls.SplitViewPanePlacement value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.PanePlacement = value);

/*BindFromExpressionSetterGenerator*/
public static T PanePlacement<T>(this T control, Func<Avalonia.Controls.SplitViewPanePlacement> func, Action<Avalonia.Controls.SplitViewPanePlacement>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PanePlacementProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PanePlacement<T>(this T control, Func<ValueTask<Avalonia.Controls.SplitViewPanePlacement>> getter, Func<Avalonia.Controls.SplitViewPanePlacement>? fallbackGetter = null, Action<Avalonia.Controls.SplitViewPanePlacement>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PanePlacementProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PanePlacement<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PanePlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PanePlacement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PanePlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Pane

/*ValueSetterGenerator*/
public static T Pane<T>(this T control, System.Object? value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.Pane = value);

/*BindFromExpressionSetterGenerator*/
public static T Pane<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Pane<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Pane<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Pane<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PaneTemplate

/*ValueSetterGenerator*/
public static T PaneTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.PaneTemplate = value);

/*BindFromExpressionSetterGenerator*/
public static T PaneTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneTemplateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PaneTemplate<T>(this T control, Func<ValueTask<Avalonia.Controls.Templates.IDataTemplate>> getter, Func<Avalonia.Controls.Templates.IDataTemplate>? fallbackGetter = null, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneTemplateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PaneTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PaneTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // UseLightDismissOverlayMode

/*ValueSetterGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, System.Boolean value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.UseLightDismissOverlayMode = value);

/*BindFromExpressionSetterGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // PaneClosed

/*ActionToEventGenerator*/
public static T OnPaneClosed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitView 
{
  control.AddHandler(Avalonia.Controls.SplitView.PaneClosedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitView.PaneClosedEvent.RoutingStrategies);
  return control;
}



 // PaneClosing

/*ActionToEventGenerator*/
public static T OnPaneClosing<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitView 
{
  control.AddHandler(Avalonia.Controls.SplitView.PaneClosingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitView.PaneClosingEvent.RoutingStrategies);
  return control;
}



 // PaneOpened

/*ActionToEventGenerator*/
public static T OnPaneOpened<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitView 
{
  control.AddHandler(Avalonia.Controls.SplitView.PaneOpenedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitView.PaneOpenedEvent.RoutingStrategies);
  return control;
}



 // PaneOpening

/*ActionToEventGenerator*/
public static T OnPaneOpening<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitView 
{
  control.AddHandler(Avalonia.Controls.SplitView.PaneOpeningEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitView.PaneOpeningEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // CompactPaneLength

/*ValueStyleSetterGenerator*/
public static Style<T> CompactPaneLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.CompactPaneLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CompactPaneLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.CompactPaneLengthProperty, binding);


 // DisplayMode

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, Avalonia.Controls.SplitViewDisplayMode value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.DisplayModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.DisplayModeProperty, binding);


 // IsPaneOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsPaneOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.IsPaneOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsPaneOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.IsPaneOpenProperty, binding);


 // OpenPaneLength

/*ValueStyleSetterGenerator*/
public static Style<T> OpenPaneLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.OpenPaneLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OpenPaneLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.OpenPaneLengthProperty, binding);


 // PaneBackground

/*ValueStyleSetterGenerator*/
public static Style<T> PaneBackground<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PaneBackground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneBackgroundProperty, binding);


 // PanePlacement

/*ValueStyleSetterGenerator*/
public static Style<T> PanePlacement<T>(this Style<T> style, Avalonia.Controls.SplitViewPanePlacement value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PanePlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PanePlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PanePlacementProperty, binding);


 // Pane

/*ValueStyleSetterGenerator*/
public static Style<T> Pane<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Pane<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneProperty, binding);


 // PaneTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> PaneTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PaneTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneTemplateProperty, binding);


 // UseLightDismissOverlayMode

/*ValueStyleSetterGenerator*/
public static Style<T> UseLightDismissOverlayMode<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseLightDismissOverlayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, binding);



}
