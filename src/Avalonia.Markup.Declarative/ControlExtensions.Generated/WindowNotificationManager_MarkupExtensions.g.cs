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
public static partial class WindowNotificationManager_MarkupExtensions
{
//================= Properties ======================//
 // Position

/*ValueSetterGenerator*/
public static T Position<T>(this T control, Avalonia.Controls.Notifications.NotificationPosition value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> control._set(() => control.Position = value);

/*BindFromExpressionSetterGenerator*/
public static T Position<T>(this T control, Func<Avalonia.Controls.Notifications.NotificationPosition> func, Action<Avalonia.Controls.Notifications.NotificationPosition>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Position<T>(this T control, Func<ValueTask<Avalonia.Controls.Notifications.NotificationPosition>> getter, Func<Avalonia.Controls.Notifications.NotificationPosition>? fallbackGetter = null, Action<Avalonia.Controls.Notifications.NotificationPosition>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Position<T>(this T control, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Position<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // MaxItems

/*ValueSetterGenerator*/
public static T MaxItems<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> control._set(() => control.MaxItems = value);

/*BindFromExpressionSetterGenerator*/
public static T MaxItems<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T MaxItems<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T MaxItems<T>(this T control, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxItems<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Position

/*ValueStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, Avalonia.Controls.Notifications.NotificationPosition value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, binding);


 // MaxItems

/*ValueStyleSetterGenerator*/
public static Style<T> MaxItems<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxItems<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, binding);



}
