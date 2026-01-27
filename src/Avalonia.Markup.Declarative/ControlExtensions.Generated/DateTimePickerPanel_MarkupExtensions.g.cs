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
public static partial class DateTimePickerPanel_MarkupExtensions
{
//================= Properties ======================//
 // ItemHeight

/*ValueSetterGenerator*/
public static T ItemHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> control._set(() => control.ItemHeight = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemHeight<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PanelType

/*ValueSetterGenerator*/
public static T PanelType<T>(this T control, Avalonia.Controls.Primitives.DateTimePickerPanelType value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> control._set(() => control.PanelType = value);

/*BindFromExpressionSetterGenerator*/
public static T PanelType<T>(this T control, Func<Avalonia.Controls.Primitives.DateTimePickerPanelType> func, Action<Avalonia.Controls.Primitives.DateTimePickerPanelType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PanelType<T>(this T control, Func<ValueTask<Avalonia.Controls.Primitives.DateTimePickerPanelType>> getter, Func<Avalonia.Controls.Primitives.DateTimePickerPanelType>? fallbackGetter = null, Action<Avalonia.Controls.Primitives.DateTimePickerPanelType>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PanelType<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PanelType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ItemFormat

/*ValueSetterGenerator*/
public static T ItemFormat<T>(this T control, System.String value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> control._set(() => control.ItemFormat = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemFormat<T>(this T control, Func<ValueTask<System.String>> getter, Func<System.String>? fallbackGetter = null, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ShouldLoop

/*ValueSetterGenerator*/
public static T ShouldLoop<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> control._set(() => control.ShouldLoop = value);

/*BindFromExpressionSetterGenerator*/
public static T ShouldLoop<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ShouldLoop<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ShouldLoop<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShouldLoop<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // ScrollInvalidated

/*ActionToEventGenerator*/
public static T OnScrollInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.DateTimePickerPanel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ScrollInvalidated += h);


 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.DateTimePickerPanel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.SelectionChanged += h);



//================= Styles ======================//
 // ItemHeight

/*ValueStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty, binding);


 // PanelType

/*ValueStyleSetterGenerator*/
public static Style<T> PanelType<T>(this Style<T> style, Avalonia.Controls.Primitives.DateTimePickerPanelType value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PanelType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty, binding);


 // ItemFormat

/*ValueStyleSetterGenerator*/
public static Style<T> ItemFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty, binding);


 // ShouldLoop

/*ValueStyleSetterGenerator*/
public static Style<T> ShouldLoop<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShouldLoop<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty, binding);



}
