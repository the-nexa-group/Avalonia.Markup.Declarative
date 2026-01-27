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
public static partial class RefreshVisualizer_MarkupExtensions
{
//================= Properties ======================//
 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Controls.RefreshVisualizerOrientation value) where T : Avalonia.Controls.RefreshVisualizer 
=> control._set(() => control.Orientation = value);

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Controls.RefreshVisualizerOrientation> func, Action<Avalonia.Controls.RefreshVisualizerOrientation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.RefreshVisualizer 
   => control._set(Avalonia.Controls.RefreshVisualizer.OrientationProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Orientation<T>(this T control, Func<ValueTask<Avalonia.Controls.RefreshVisualizerOrientation>> getter, Func<Avalonia.Controls.RefreshVisualizerOrientation>? fallbackGetter = null, Action<Avalonia.Controls.RefreshVisualizerOrientation>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.RefreshVisualizer 
   => control._set(Avalonia.Controls.RefreshVisualizer.OrientationProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.RefreshVisualizer 
   => control._set(Avalonia.Controls.RefreshVisualizer.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RefreshVisualizer 
   => control._set(Avalonia.Controls.RefreshVisualizer.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // RefreshRequested

/*ActionToEventGenerator*/
public static T OnRefreshRequested<T>(this T control, Action<Avalonia.Controls.RefreshRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.RefreshVisualizer 
{
  control.AddHandler(Avalonia.Controls.RefreshVisualizer.RefreshRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.RefreshVisualizer.RefreshRequestedEvent.RoutingStrategies);
  return control;
}




}
