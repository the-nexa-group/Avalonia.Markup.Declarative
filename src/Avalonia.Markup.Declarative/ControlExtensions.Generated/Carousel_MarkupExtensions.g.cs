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
public static partial class Carousel_MarkupExtensions
{
//================= Properties ======================//
 // PageTransition

/*ValueSetterGenerator*/
public static T PageTransition<T>(this T control, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.Carousel 
=> control._set(() => control.PageTransition = value);

/*BindFromExpressionSetterGenerator*/
public static T PageTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition?> func, Action<Avalonia.Animation.IPageTransition?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Carousel 
   => control._set(Avalonia.Controls.Carousel.PageTransitionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PageTransition<T>(this T control, Func<ValueTask<Avalonia.Animation.IPageTransition?>> getter, Func<Avalonia.Animation.IPageTransition?>? fallbackGetter = null, Action<Avalonia.Animation.IPageTransition?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Carousel 
   => control._set(Avalonia.Controls.Carousel.PageTransitionProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PageTransition<T>(this T control, IBinding binding) where T : Avalonia.Controls.Carousel 
   => control._set(Avalonia.Controls.Carousel.PageTransitionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PageTransition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Carousel 
   => control._set(Avalonia.Controls.Carousel.PageTransitionProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // PageTransition

/*ValueStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.Carousel 
=> style._addSetter(Avalonia.Controls.Carousel.PageTransitionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Carousel 
=> style._addSetter(Avalonia.Controls.Carousel.PageTransitionProperty, binding);



}
