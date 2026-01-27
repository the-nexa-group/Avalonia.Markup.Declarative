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
public static partial class MenuFlyout_MarkupExtensions
{
//================= Properties ======================//
 // ItemsSource

/*ValueSetterGenerator*/
public static T ItemsSource<T>(this T control, System.Collections.IEnumerable? value) where T : Avalonia.Controls.MenuFlyout 
=> control._set(() => control.ItemsSource = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable?> func, Action<System.Collections.IEnumerable?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemsSourceProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemsSource<T>(this T control, Func<ValueTask<System.Collections.IEnumerable?>> getter, Func<System.Collections.IEnumerable?>? fallbackGetter = null, Action<System.Collections.IEnumerable?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemsSourceProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemsSource<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemsSourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemsSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemsSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ItemTemplate

/*ValueSetterGenerator*/
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.MenuFlyout 
=> control._set(() => control.ItemTemplate = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemTemplateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemTemplate<T>(this T control, Func<ValueTask<Avalonia.Controls.Templates.IDataTemplate?>> getter, Func<Avalonia.Controls.Templates.IDataTemplate?>? fallbackGetter = null, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemTemplateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ItemContainerTheme

/*ValueSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Avalonia.Styling.ControlTheme? value) where T : Avalonia.Controls.MenuFlyout 
=> control._set(() => control.ItemContainerTheme = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme?> func, Action<Avalonia.Styling.ControlTheme?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Func<ValueTask<Avalonia.Styling.ControlTheme?>> getter, Func<Avalonia.Styling.ControlTheme?>? fallbackGetter = null, Action<Avalonia.Styling.ControlTheme?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // FlyoutPresenterTheme

/*ValueSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Avalonia.Styling.ControlTheme? value) where T : Avalonia.Controls.MenuFlyout 
=> control._set(() => control.FlyoutPresenterTheme = value);

/*BindFromExpressionSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme?> func, Action<Avalonia.Styling.ControlTheme?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Func<ValueTask<Avalonia.Styling.ControlTheme?>> getter, Func<Avalonia.Styling.ControlTheme?>? fallbackGetter = null, Action<Avalonia.Styling.ControlTheme?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
