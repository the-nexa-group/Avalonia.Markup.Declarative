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
public static partial class HeaderedSelectingItemsControl_MarkupExtensions
{
//================= Properties ======================//
 // Header

/*ValueSetterGenerator*/
public static T Header<T>(this T control, System.Object? value) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
=> control._set(() => control.Header = value);

/*BindFromExpressionSetterGenerator*/
public static T Header<T>(this T control, Func<System.Object?> func, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Header<T>(this T control, Func<ValueTask<System.Object?>> getter, Func<System.Object?>? fallbackGetter = null, Action<System.Object?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Header<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Header<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // HeaderTemplate

/*ValueSetterGenerator*/
public static T HeaderTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
=> control._set(() => control.HeaderTemplate = value);

/*BindFromExpressionSetterGenerator*/
public static T HeaderTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderTemplateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T HeaderTemplate<T>(this T control, Func<ValueTask<Avalonia.Controls.Templates.IDataTemplate?>> getter, Func<Avalonia.Controls.Templates.IDataTemplate?>? fallbackGetter = null, Action<Avalonia.Controls.Templates.IDataTemplate?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderTemplateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T HeaderTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HeaderTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Header

/*ValueStyleSetterGenerator*/
public static Style<T> Header<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Header<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, binding);


 // HeaderTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> HeaderTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HeaderTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderTemplateProperty, binding);



}
