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
public static partial class ItemsControl_MarkupExtensions
{
//================= Properties ======================//
 // ItemContainerTheme

/*ValueSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Avalonia.Styling.ControlTheme? value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.ItemContainerTheme = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme?> func, Action<Avalonia.Styling.ControlTheme?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Func<ValueTask<Avalonia.Styling.ControlTheme?>> getter, Func<Avalonia.Styling.ControlTheme?>? fallbackGetter = null, Action<Avalonia.Styling.ControlTheme?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, IBinding binding) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ItemsPanel

/*ValueSetterGenerator*/
public static T ItemsPanel<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>? value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.ItemsPanel = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemsPanel<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>?> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsPanelProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemsPanel<T>(this T control, Func<ValueTask<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>?>> getter, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>?>? fallbackGetter = null, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsPanelProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemsPanel<T>(this T control, IBinding binding) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsPanelProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemsPanel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsPanelProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ItemsSource

/*ValueSetterGenerator*/
public static T ItemsSource<T>(this T control, System.Collections.IEnumerable? value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.ItemsSource = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable?> func, Action<System.Collections.IEnumerable?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsSourceProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemsSource<T>(this T control, Func<ValueTask<System.Collections.IEnumerable?>> getter, Func<System.Collections.IEnumerable?>? fallbackGetter = null, Action<System.Collections.IEnumerable?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsSourceProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemsSource<T>(this T control, IBinding binding) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsSourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemsSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ItemTemplate

/*ValueSetterGenerator*/
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.ItemTemplate = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemTemplateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemTemplate<T>(this T control, Func<ValueTask<Avalonia.Controls.Templates.IDataTemplate?>> getter, Func<Avalonia.Controls.Templates.IDataTemplate?>? fallbackGetter = null, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemTemplateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // DisplayMemberBinding

/*ValueSetterGenerator*/
public static T DisplayMemberBinding<T>(this T control, Avalonia.Data.IBinding? value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.DisplayMemberBinding = value);

/*BindFromExpressionSetterGenerator*/
public static T DisplayMemberBinding<T>(this T control, Func<Avalonia.Data.IBinding?> func, Action<Avalonia.Data.IBinding?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DisplayMemberBinding<T>(this T control, Func<ValueTask<Avalonia.Data.IBinding?>> getter, Func<Avalonia.Data.IBinding?>? fallbackGetter = null, Action<Avalonia.Data.IBinding?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty!, getter, fallbackGetter, onChanged, expression);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayMemberBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // PreparingContainer

/*ActionToEventGenerator*/
public static T OnPreparingContainer<T>(this T control, Action<Avalonia.Controls.ContainerPreparedEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerPreparedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PreparingContainer += h);


 // ContainerPrepared

/*ActionToEventGenerator*/
public static T OnContainerPrepared<T>(this T control, Action<Avalonia.Controls.ContainerPreparedEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerPreparedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ContainerPrepared += h);


 // ContainerIndexChanged

/*ActionToEventGenerator*/
public static T OnContainerIndexChanged<T>(this T control, Action<Avalonia.Controls.ContainerIndexChangedEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerIndexChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ContainerIndexChanged += h);


 // ContainerClearing

/*ActionToEventGenerator*/
public static T OnContainerClearing<T>(this T control, Action<Avalonia.Controls.ContainerClearingEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerClearingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ContainerClearing += h);



//================= Styles ======================//
 // ItemContainerTheme

/*ValueStyleSetterGenerator*/
public static Style<T> ItemContainerTheme<T>(this Style<T> style, Avalonia.Styling.ControlTheme? value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemContainerTheme<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, binding);


 // ItemsPanel

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>? value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsPanelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsPanelProperty, binding);


 // ItemsSource

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, System.Collections.IEnumerable? value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsSourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsSourceProperty, binding);


 // ItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemTemplateProperty, binding);


 // DisplayMemberBinding

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayMemberBinding<T>(this Style<T> style, Avalonia.Data.IBinding? value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped DisplayMemberBinding because already exist in value setters



}
