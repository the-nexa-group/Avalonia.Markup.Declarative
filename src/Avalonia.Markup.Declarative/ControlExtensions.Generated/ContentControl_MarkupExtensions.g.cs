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
public static partial class ContentControl_MarkupExtensions
{
//================= Properties ======================//
 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object? value) where T : Avalonia.Controls.ContentControl 
=> control._set(() => control.Content = value);

/*BindFromExpressionSetterGenerator*/
public static T Content<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Content<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Content<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Content<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ContentControl 
=> control._set(() => control.ContentTemplate = value);

/*BindFromExpressionSetterGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentTemplateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ContentTemplate<T>(this T control, Func<ValueTask<Avalonia.Controls.Templates.IDataTemplate?>> getter, Func<Avalonia.Controls.Templates.IDataTemplate?>? fallbackGetter = null, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentTemplateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ContentTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ContentControl 
=> control._set(() => control.HorizontalContentAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<ValueTask<Avalonia.Layout.HorizontalAlignment>> getter, Func<Avalonia.Layout.HorizontalAlignment>? fallbackGetter = null, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ContentControl 
=> control._set(() => control.VerticalContentAlignment = value);

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<ValueTask<Avalonia.Layout.VerticalAlignment>> getter, Func<Avalonia.Layout.VerticalAlignment>? fallbackGetter = null, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.ContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.ContentProperty, binding);


 // ContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.ContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.ContentTemplateProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty, binding);



}
