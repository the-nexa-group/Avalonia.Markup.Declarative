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
public static partial class ComboBox_MarkupExtensions
{
//================= Properties ======================//
 // IsDropDownOpen

/*ValueSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.IsDropDownOpen = value);

/*BindFromExpressionSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsDropDownOpenProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsDropDownOpenProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsEditable

/*ValueSetterGenerator*/
public static T IsEditable<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.IsEditable = value);

/*BindFromExpressionSetterGenerator*/
public static T IsEditable<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsEditableProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsEditable<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsEditableProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsEditable<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsEditableProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsEditable<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsEditableProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MaxDropDownHeight

/*ValueSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.MaxDropDownHeight = value);

/*BindFromExpressionSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlaceholderText

/*ValueSetterGenerator*/
public static T PlaceholderText<T>(this T control, System.String? value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.PlaceholderText = value);

/*BindFromExpressionSetterGenerator*/
public static T PlaceholderText<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderTextProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PlaceholderText<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderTextProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PlaceholderText<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderTextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlaceholderText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderTextProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // PlaceholderForeground

/*ValueSetterGenerator*/
public static T PlaceholderForeground<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.PlaceholderForeground = value);

/*BindFromExpressionSetterGenerator*/
public static T PlaceholderForeground<T>(this T control, Func<Avalonia.Media.IBrush?> func, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PlaceholderForeground<T>(this T control, Func<ValueTask<Avalonia.Media.IBrush?>> getter, Func<Avalonia.Media.IBrush?>? fallbackGetter = null, Action<Avalonia.Media.IBrush?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PlaceholderForeground<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlaceholderForeground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.HorizontalContentAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<ValueTask<Avalonia.Layout.HorizontalAlignment>> getter, Func<Avalonia.Layout.HorizontalAlignment>? fallbackGetter = null, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.VerticalContentAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<ValueTask<Avalonia.Layout.VerticalAlignment>> getter, Func<Avalonia.Layout.VerticalAlignment>? fallbackGetter = null, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String? value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.Text = value);

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.TextProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Text<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.TextProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // SelectionBoxItemTemplate

/*ValueSetterGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.SelectionBoxItemTemplate = value);

/*BindFromExpressionSetterGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, Func<ValueTask<Avalonia.Controls.Templates.IDataTemplate?>> getter, Func<Avalonia.Controls.Templates.IDataTemplate?>? fallbackGetter = null, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // DropDownClosed

/*ActionToEventGenerator*/
public static T OnDropDownClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.ComboBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownClosed += h);


 // DropDownOpened

/*ActionToEventGenerator*/
public static T OnDropDownOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.ComboBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownOpened += h);



//================= Styles ======================//
 // IsDropDownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsDropDownOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, binding);


 // IsEditable

/*ValueStyleSetterGenerator*/
public static Style<T> IsEditable<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsEditableProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsEditable<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsEditableProperty, binding);


 // MaxDropDownHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, binding);


 // PlaceholderText

/*ValueStyleSetterGenerator*/
public static Style<T> PlaceholderText<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderTextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlaceholderText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderTextProperty, binding);


 // PlaceholderForeground

/*ValueStyleSetterGenerator*/
public static Style<T> PlaceholderForeground<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlaceholderForeground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.TextProperty, binding);


 // SelectionBoxItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBoxItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBoxItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, binding);



}
