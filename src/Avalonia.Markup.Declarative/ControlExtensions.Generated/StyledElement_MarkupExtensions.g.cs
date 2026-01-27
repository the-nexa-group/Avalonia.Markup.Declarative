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
public static partial class StyledElement_MarkupExtensions
{
//================= Properties ======================//
 // DataContext

/*ValueSetterGenerator*/
public static T DataContext<T>(this T control, System.Object? value) where T : Avalonia.StyledElement 
=> control._set(() => control.DataContext = value);

/*BindFromExpressionSetterGenerator*/
public static T DataContext<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.DataContextProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T DataContext<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.DataContextProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T DataContext<T>(this T control, IBinding binding) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.DataContextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DataContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.DataContextProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Name

/*ValueSetterGenerator*/
public static T Name<T>(this T control, System.String? value) where T : Avalonia.StyledElement 
=> control._set(() => control.Name = value);

/*BindFromExpressionSetterGenerator*/
public static T Name<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.NameProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Name<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.NameProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Name<T>(this T control, IBinding binding) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.NameProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Name<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.NameProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Theme

/*ValueSetterGenerator*/
public static T Theme<T>(this T control, Avalonia.Styling.ControlTheme? value) where T : Avalonia.StyledElement 
=> control._set(() => control.Theme = value);

/*BindFromExpressionSetterGenerator*/
public static T Theme<T>(this T control, Func<Avalonia.Styling.ControlTheme?> func, Action<Avalonia.Styling.ControlTheme?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.ThemeProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Theme<T>(this T control, Func<ValueTask<Avalonia.Styling.ControlTheme?>> getter, Func<Avalonia.Styling.ControlTheme?>? fallbackGetter = null, Action<Avalonia.Styling.ControlTheme?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.ThemeProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Theme<T>(this T control, IBinding binding) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.ThemeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Theme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.ThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // AttachedToLogicalTree

/*ActionToEventGenerator*/
public static T OnAttachedToLogicalTree<T>(this T control, Action<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.AttachedToLogicalTree += h);


 // DetachedFromLogicalTree

/*ActionToEventGenerator*/
public static T OnDetachedFromLogicalTree<T>(this T control, Action<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DetachedFromLogicalTree += h);


 // DataContextChanged

/*ActionToEventGenerator*/
public static T OnDataContextChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DataContextChanged += h);


 // Initialized

/*ActionToEventGenerator*/
public static T OnInitialized<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Initialized += h);


 // ResourcesChanged

/*ActionToEventGenerator*/
public static T OnResourcesChanged<T>(this T control, Action<Avalonia.Controls.ResourcesChangedEventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ResourcesChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ResourcesChanged += h);


 // ActualThemeVariantChanged

/*ActionToEventGenerator*/
public static T OnActualThemeVariantChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ActualThemeVariantChanged += h);



//================= Styles ======================//
 // DataContext

/*ValueStyleSetterGenerator*/
public static Style<T> DataContext<T>(this Style<T> style, System.Object? value) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.DataContextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DataContext<T>(this Style<T> style, IBinding binding) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.DataContextProperty, binding);


 // Theme

/*ValueStyleSetterGenerator*/
public static Style<T> Theme<T>(this Style<T> style, Avalonia.Styling.ControlTheme? value) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.ThemeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Theme<T>(this Style<T> style, IBinding binding) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.ThemeProperty, binding);



}
