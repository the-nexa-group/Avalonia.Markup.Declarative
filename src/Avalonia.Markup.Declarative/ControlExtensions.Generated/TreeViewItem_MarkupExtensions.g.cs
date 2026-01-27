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
public static partial class TreeViewItem_MarkupExtensions
{
//================= Properties ======================//
 // IsExpanded

/*ValueSetterGenerator*/
public static T IsExpanded<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> control._set(() => control.IsExpanded = value);

/*BindFromExpressionSetterGenerator*/
public static T IsExpanded<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsExpandedProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsExpanded<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsExpandedProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsExpanded<T>(this T control, IBinding binding) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsExpandedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsExpanded<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsExpandedProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsSelected

/*ValueSetterGenerator*/
public static T IsSelected<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> control._set(() => control.IsSelected = value);

/*BindFromExpressionSetterGenerator*/
public static T IsSelected<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsSelectedProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsSelected<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsSelectedProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsSelected<T>(this T control, IBinding binding) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsSelectedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsSelected<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsSelectedProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // Expanded

/*ActionToEventGenerator*/
public static T OnExpanded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TreeViewItem 
{
  control.AddHandler(Avalonia.Controls.TreeViewItem.ExpandedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TreeViewItem.ExpandedEvent.RoutingStrategies);
  return control;
}



 // Collapsed

/*ActionToEventGenerator*/
public static T OnCollapsed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TreeViewItem 
{
  control.AddHandler(Avalonia.Controls.TreeViewItem.CollapsedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TreeViewItem.CollapsedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsExpanded

/*ValueStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsExpandedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsExpandedProperty, binding);


 // IsSelected

/*ValueStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsSelectedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsSelectedProperty, binding);



}
