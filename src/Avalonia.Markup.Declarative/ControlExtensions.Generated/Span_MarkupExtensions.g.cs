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
public static partial class Span_MarkupExtensions
{
//================= Properties ======================//
 // Inlines

/*ValueSetterGenerator*/
public static T Inlines<T>(this T control, Avalonia.Controls.Documents.InlineCollection value) where T : Avalonia.Controls.Documents.Span 
=> control._set(() => control.Inlines = value);

/*BindFromExpressionSetterGenerator*/
public static T Inlines<T>(this T control, Func<Avalonia.Controls.Documents.InlineCollection> func, Action<Avalonia.Controls.Documents.InlineCollection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Documents.Span 
   => control._set(Avalonia.Controls.Documents.Span.InlinesProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Inlines<T>(this T control, Func<ValueTask<Avalonia.Controls.Documents.InlineCollection>> getter, Func<Avalonia.Controls.Documents.InlineCollection>? fallbackGetter = null, Action<Avalonia.Controls.Documents.InlineCollection>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Documents.Span 
   => control._set(Avalonia.Controls.Documents.Span.InlinesProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Inlines<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.Span 
   => control._set(Avalonia.Controls.Documents.Span.InlinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Inlines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.Span 
   => control._set(Avalonia.Controls.Documents.Span.InlinesProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Inlines

/*ValueStyleSetterGenerator*/
public static Style<T> Inlines<T>(this Style<T> style, Avalonia.Controls.Documents.InlineCollection value) where T : Avalonia.Controls.Documents.Span 
=> style._addSetter(Avalonia.Controls.Documents.Span.InlinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Inlines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Span 
=> style._addSetter(Avalonia.Controls.Documents.Span.InlinesProperty, binding);



}
