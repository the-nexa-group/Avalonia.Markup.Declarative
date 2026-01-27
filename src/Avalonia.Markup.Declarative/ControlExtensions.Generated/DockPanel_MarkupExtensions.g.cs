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
public static partial class DockPanel_MarkupExtensions
{
//================= Properties ======================//
 // LastChildFill

/*ValueSetterGenerator*/
public static T LastChildFill<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DockPanel 
=> control._set(() => control.LastChildFill = value);

/*BindFromExpressionSetterGenerator*/
public static T LastChildFill<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.LastChildFillProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T LastChildFill<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.LastChildFillProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T LastChildFill<T>(this T control, IBinding binding) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.LastChildFillProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LastChildFill<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.LastChildFillProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HorizontalSpacing

/*ValueSetterGenerator*/
public static T HorizontalSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.DockPanel 
=> control._set(() => control.HorizontalSpacing = value);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.HorizontalSpacingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HorizontalSpacing<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.HorizontalSpacingProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HorizontalSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.HorizontalSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.HorizontalSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // VerticalSpacing

/*ValueSetterGenerator*/
public static T VerticalSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.DockPanel 
=> control._set(() => control.VerticalSpacing = value);

/*BindFromExpressionSetterGenerator*/
public static T VerticalSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.VerticalSpacingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T VerticalSpacing<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.VerticalSpacingProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T VerticalSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.VerticalSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.VerticalSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Attached Properties ======================//
 // Dock

/*AttachedPropertyMagicalSetterGenerator*/
public static T DockPanel_Dock<T>(this T control, Avalonia.Controls.Dock value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.DockPanel.DockProperty, ps, () => Avalonia.Controls.DockPanel.SetDock(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T DockPanel_Dock<T>(this T control, Func<Avalonia.Controls.Dock> func, Action<Avalonia.Controls.Dock>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.DockPanel.DockProperty!, func, onChanged, expression);



//================= Styles ======================//
 // LastChildFill

/*ValueStyleSetterGenerator*/
public static Style<T> LastChildFill<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.LastChildFillProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LastChildFill<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.LastChildFillProperty, binding);


 // HorizontalSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.HorizontalSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.HorizontalSpacingProperty, binding);


 // VerticalSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.VerticalSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.VerticalSpacingProperty, binding);



}
