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
public static partial class PullGestureRecognizer_MarkupExtensions
{
//================= Properties ======================//
 // PullDirection

/*ValueSetterGenerator*/
public static T PullDirection<T>(this T control, Avalonia.Input.PullDirection value) where T : Avalonia.Input.PullGestureRecognizer 
=> control._set(() => control.PullDirection = value);

/*BindFromExpressionSetterGenerator*/
public static T PullDirection<T>(this T control, Func<Avalonia.Input.PullDirection> func, Action<Avalonia.Input.PullDirection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.PullGestureRecognizer 
   => control._set(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T PullDirection<T>(this T control, Func<ValueTask<Avalonia.Input.PullDirection>> getter, Func<Avalonia.Input.PullDirection>? fallbackGetter = null, Action<Avalonia.Input.PullDirection>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Input.PullGestureRecognizer 
   => control._set(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T PullDirection<T>(this T control, IBinding binding) where T : Avalonia.Input.PullGestureRecognizer 
   => control._set(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PullDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.PullGestureRecognizer 
   => control._set(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // PullDirection

/*ValueStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, Avalonia.Input.PullDirection value) where T : Avalonia.Input.PullGestureRecognizer 
=> style._addSetter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.PullGestureRecognizer 
=> style._addSetter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, binding);



}
