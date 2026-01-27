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
public static partial class TrayIcon_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand? value) where T : Avalonia.Controls.TrayIcon 
=> control._set(() => control.Command = value);

/*BindFromExpressionSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand?> func, Action<System.Windows.Input.ICommand?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Command<T>(this T control, Func<ValueTask<System.Windows.Input.ICommand?>> getter, Func<System.Windows.Input.ICommand?>? fallbackGetter = null, Action<System.Windows.Input.ICommand?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object? value) where T : Avalonia.Controls.TrayIcon 
=> control._set(() => control.CommandParameter = value);

/*BindFromExpressionSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandParameterProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandParameterProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Menu

/*ValueSetterGenerator*/
public static T Menu<T>(this T control, Avalonia.Controls.NativeMenu? value) where T : Avalonia.Controls.TrayIcon 
=> control._set(() => control.Menu = value);

/*BindFromExpressionSetterGenerator*/
public static T Menu<T>(this T control, Func<Avalonia.Controls.NativeMenu?> func, Action<Avalonia.Controls.NativeMenu?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.MenuProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Menu<T>(this T control, Func<ValueTask<Avalonia.Controls.NativeMenu?>> getter, Func<Avalonia.Controls.NativeMenu?>? fallbackGetter = null, Action<Avalonia.Controls.NativeMenu?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.MenuProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Menu<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.MenuProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Menu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.MenuProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, Avalonia.Controls.WindowIcon? value) where T : Avalonia.Controls.TrayIcon 
=> control._set(() => control.Icon = value);

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<Avalonia.Controls.WindowIcon?> func, Action<Avalonia.Controls.WindowIcon?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IconProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Icon<T>(this T control, Func<ValueTask<Avalonia.Controls.WindowIcon?>> getter, Func<Avalonia.Controls.WindowIcon?>? fallbackGetter = null, Action<Avalonia.Controls.WindowIcon?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IconProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ToolTipText

/*ValueSetterGenerator*/
public static T ToolTipText<T>(this T control, System.String? value) where T : Avalonia.Controls.TrayIcon 
=> control._set(() => control.ToolTipText = value);

/*BindFromExpressionSetterGenerator*/
public static T ToolTipText<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.ToolTipTextProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ToolTipText<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.ToolTipTextProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ToolTipText<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.ToolTipTextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ToolTipText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.ToolTipTextProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // IsVisible

/*ValueSetterGenerator*/
public static T IsVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TrayIcon 
=> control._set(() => control.IsVisible = value);

/*BindFromExpressionSetterGenerator*/
public static T IsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IsVisibleProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsVisible<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IsVisibleProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IsVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Attached Properties ======================//
 // Icons

/*AttachedPropertyMagicalSetterGenerator*/
public static T TrayIcon_Icons<T>(this T control, Avalonia.Controls.TrayIcons? value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Application
 => control._setEx(Avalonia.Controls.TrayIcon.IconsProperty, ps, () => Avalonia.Controls.TrayIcon.SetIcons(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TrayIcon_Icons<T>(this T control, Func<Avalonia.Controls.TrayIcons?> func, Action<Avalonia.Controls.TrayIcons?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Application 
   => control._set(Avalonia.Controls.TrayIcon.IconsProperty!, func, onChanged, expression);



//================= Events ======================//
 // Clicked

/*ActionToEventGenerator*/
public static T OnClicked<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TrayIcon  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Clicked += h);



}
