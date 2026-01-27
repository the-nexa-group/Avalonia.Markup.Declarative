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
public static partial class Flyout_MarkupExtensions
{
//================= Properties ======================//
 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object? value) where T : Avalonia.Controls.Flyout 
=> control._set(() => control.Content = value);

/*BindFromExpressionSetterGenerator*/
public static T Content<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Content<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Content<T>(this T control, IBinding binding) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Content<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.Flyout 
=> control._set(() => control.ContentTemplate = value);

/*BindFromExpressionSetterGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentTemplateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ContentTemplate<T>(this T control, Func<ValueTask<Avalonia.Controls.Templates.IDataTemplate?>> getter, Func<Avalonia.Controls.Templates.IDataTemplate?>? fallbackGetter = null, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentTemplateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ContentTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // FlyoutPresenterTheme

/*ValueSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Avalonia.Styling.ControlTheme? value) where T : Avalonia.Controls.Flyout 
=> control._set(() => control.FlyoutPresenterTheme = value);

/*BindFromExpressionSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme?> func, Action<Avalonia.Styling.ControlTheme?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Func<ValueTask<Avalonia.Styling.ControlTheme?>> getter, Func<Avalonia.Styling.ControlTheme?>? fallbackGetter = null, Action<Avalonia.Styling.ControlTheme?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, IBinding binding) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
