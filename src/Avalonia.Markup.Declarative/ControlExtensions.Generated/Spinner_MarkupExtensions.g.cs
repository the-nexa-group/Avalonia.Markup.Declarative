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
public static partial class Spinner_MarkupExtensions
{
//================= Properties ======================//
 // ValidSpinDirection

/*ValueSetterGenerator*/
public static T ValidSpinDirection<T>(this T control, Avalonia.Controls.ValidSpinDirections value) where T : Avalonia.Controls.Spinner 
=> control._set(() => control.ValidSpinDirection = value);

/*BindFromExpressionSetterGenerator*/
public static T ValidSpinDirection<T>(this T control, Func<Avalonia.Controls.ValidSpinDirections> func, Action<Avalonia.Controls.ValidSpinDirections>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Spinner 
   => control._set(Avalonia.Controls.Spinner.ValidSpinDirectionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ValidSpinDirection<T>(this T control, Func<ValueTask<Avalonia.Controls.ValidSpinDirections>> getter, Func<Avalonia.Controls.ValidSpinDirections>? fallbackGetter = null, Action<Avalonia.Controls.ValidSpinDirections>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Spinner 
   => control._set(Avalonia.Controls.Spinner.ValidSpinDirectionProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ValidSpinDirection<T>(this T control, IBinding binding) where T : Avalonia.Controls.Spinner 
   => control._set(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ValidSpinDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Spinner 
   => control._set(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // Spin

/*ActionToEventGenerator*/
public static T OnSpin<T>(this T control, Action<Avalonia.Controls.SpinEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Spinner 
{
  control.AddHandler(Avalonia.Controls.Spinner.SpinEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Spinner.SpinEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // ValidSpinDirection

/*ValueStyleSetterGenerator*/
public static Style<T> ValidSpinDirection<T>(this Style<T> style, Avalonia.Controls.ValidSpinDirections value) where T : Avalonia.Controls.Spinner 
=> style._addSetter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ValidSpinDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Spinner 
=> style._addSetter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, binding);



}
