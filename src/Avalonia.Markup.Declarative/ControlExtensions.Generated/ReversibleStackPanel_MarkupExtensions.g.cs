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
public static partial class ReversibleStackPanel_MarkupExtensions
{
//================= Properties ======================//
 // ReverseOrder

/*ValueSetterGenerator*/
public static T ReverseOrder<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ReversibleStackPanel 
=> control._set(() => control.ReverseOrder = value);

/*BindFromExpressionSetterGenerator*/
public static T ReverseOrder<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ReversibleStackPanel 
   => control._set(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ReverseOrder<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.ReversibleStackPanel 
   => control._set(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ReverseOrder<T>(this T control, IBinding binding) where T : Avalonia.Controls.ReversibleStackPanel 
   => control._set(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ReverseOrder<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ReversibleStackPanel 
   => control._set(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // ReverseOrder

/*ValueStyleSetterGenerator*/
public static Style<T> ReverseOrder<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ReversibleStackPanel 
=> style._addSetter(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ReverseOrder<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ReversibleStackPanel 
=> style._addSetter(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, binding);



}
