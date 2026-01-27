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
public static partial class ProgressBar_MarkupExtensions
{
//================= Properties ======================//
 // IsIndeterminate

/*ValueSetterGenerator*/
public static T IsIndeterminate<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ProgressBar 
=> control._set(() => control.IsIndeterminate = value);

/*BindFromExpressionSetterGenerator*/
public static T IsIndeterminate<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.IsIndeterminateProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsIndeterminate<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.IsIndeterminateProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsIndeterminate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsIndeterminate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ShowProgressText

/*ValueSetterGenerator*/
public static T ShowProgressText<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ProgressBar 
=> control._set(() => control.ShowProgressText = value);

/*BindFromExpressionSetterGenerator*/
public static T ShowProgressText<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ShowProgressTextProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ShowProgressText<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ShowProgressTextProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ShowProgressText<T>(this T control, IBinding binding) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowProgressText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ProgressTextFormat

/*ValueSetterGenerator*/
public static T ProgressTextFormat<T>(this T control, System.String value) where T : Avalonia.Controls.ProgressBar 
=> control._set(() => control.ProgressTextFormat = value);

/*BindFromExpressionSetterGenerator*/
public static T ProgressTextFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ProgressTextFormat<T>(this T control, Func<ValueTask<System.String>> getter, Func<System.String>? fallbackGetter = null, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ProgressTextFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ProgressTextFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.ProgressBar 
=> control._set(() => control.Orientation = value);

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.OrientationProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Orientation<T>(this T control, Func<ValueTask<Avalonia.Layout.Orientation>> getter, Func<Avalonia.Layout.Orientation>? fallbackGetter = null, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.OrientationProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // IsIndeterminate

/*ValueStyleSetterGenerator*/
public static Style<T> IsIndeterminate<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.IsIndeterminateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsIndeterminate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, binding);


 // ShowProgressText

/*ValueStyleSetterGenerator*/
public static Style<T> ShowProgressText<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.ShowProgressTextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowProgressText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, binding);


 // ProgressTextFormat

/*ValueStyleSetterGenerator*/
public static Style<T> ProgressTextFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ProgressTextFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.OrientationProperty, binding);



}
