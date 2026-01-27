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
public static partial class TabControl_MarkupExtensions
{
//================= Properties ======================//
 // TabStripPlacement

/*ValueSetterGenerator*/
public static T TabStripPlacement<T>(this T control, Avalonia.Controls.Dock value) where T : Avalonia.Controls.TabControl 
=> control._set(() => control.TabStripPlacement = value);

/*BindFromExpressionSetterGenerator*/
public static T TabStripPlacement<T>(this T control, Func<Avalonia.Controls.Dock> func, Action<Avalonia.Controls.Dock>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.TabStripPlacementProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T TabStripPlacement<T>(this T control, Func<ValueTask<Avalonia.Controls.Dock>> getter, Func<Avalonia.Controls.Dock>? fallbackGetter = null, Action<Avalonia.Controls.Dock>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.TabStripPlacementProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T TabStripPlacement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.TabStripPlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TabStripPlacement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.TabStripPlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TabControl 
=> control._set(() => control.HorizontalContentAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<ValueTask<Avalonia.Layout.HorizontalAlignment>> getter, Func<Avalonia.Layout.HorizontalAlignment>? fallbackGetter = null, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TabControl 
=> control._set(() => control.VerticalContentAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<ValueTask<Avalonia.Layout.VerticalAlignment>> getter, Func<Avalonia.Layout.VerticalAlignment>? fallbackGetter = null, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.TabControl 
=> control._set(() => control.ContentTemplate = value);

/*BindFromExpressionSetterGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.ContentTemplateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ContentTemplate<T>(this T control, Func<ValueTask<Avalonia.Controls.Templates.IDataTemplate?>> getter, Func<Avalonia.Controls.Templates.IDataTemplate?>? fallbackGetter = null, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.ContentTemplateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ContentTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.ContentTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.ContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // TabStripPlacement

/*ValueStyleSetterGenerator*/
public static Style<T> TabStripPlacement<T>(this Style<T> style, Avalonia.Controls.Dock value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.TabStripPlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TabStripPlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.TabStripPlacementProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty, binding);


 // ContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.ContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.ContentTemplateProperty, binding);



}
