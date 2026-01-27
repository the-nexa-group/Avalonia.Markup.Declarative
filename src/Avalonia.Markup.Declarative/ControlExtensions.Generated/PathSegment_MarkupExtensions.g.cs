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
public static partial class PathSegment_MarkupExtensions
{
//================= Properties ======================//
 // IsStroked

/*ValueSetterGenerator*/
public static T IsStroked<T>(this T control, System.Boolean value) where T : Avalonia.Media.PathSegment 
=> control._set(() => control.IsStroked = value);

/*BindFromExpressionSetterGenerator*/
public static T IsStroked<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.PathSegment 
   => control._set(Avalonia.Media.PathSegment.IsStrokedProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T IsStroked<T>(this T control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.PathSegment 
   => control._set(Avalonia.Media.PathSegment.IsStrokedProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T IsStroked<T>(this T control, IBinding binding) where T : Avalonia.Media.PathSegment 
   => control._set(Avalonia.Media.PathSegment.IsStrokedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsStroked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.PathSegment 
   => control._set(Avalonia.Media.PathSegment.IsStrokedProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
