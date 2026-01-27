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
public static partial class ThemeVariantScope_MarkupExtensions
{
//================= Properties ======================//
 // RequestedThemeVariant

/*ValueSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Avalonia.Styling.ThemeVariant? value) where T : Avalonia.Controls.ThemeVariantScope 
=> control._set(() => control.RequestedThemeVariant = value);

/*BindFromExpressionSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant?> func, Action<Avalonia.Styling.ThemeVariant?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ThemeVariantScope 
   => control._set(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<ValueTask<Avalonia.Styling.ThemeVariant?>> getter, Func<Avalonia.Styling.ThemeVariant?>? fallbackGetter = null, Action<Avalonia.Styling.ThemeVariant?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ThemeVariantScope 
   => control._set(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, IBinding binding) where T : Avalonia.Controls.ThemeVariantScope 
   => control._set(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ThemeVariantScope 
   => control._set(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // RequestedThemeVariant

/*ValueStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, Avalonia.Styling.ThemeVariant? value) where T : Avalonia.Controls.ThemeVariantScope 
=> style._addSetter(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ThemeVariantScope 
=> style._addSetter(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty, binding);



}
