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
public static partial class Geometry_MarkupExtensions
{
//================= Properties ======================//
 // Transform

/*ValueSetterGenerator*/
public static T Transform<T>(this T control, Avalonia.Media.Transform? value) where T : Avalonia.Media.Geometry 
=> control._set(() => control.Transform = value);

/*BindFromExpressionSetterGenerator*/
public static T Transform<T>(this T control, Func<Avalonia.Media.Transform?> func, Action<Avalonia.Media.Transform?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.Geometry 
   => control._set(Avalonia.Media.Geometry.TransformProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Transform<T>(this T control, Func<ValueTask<Avalonia.Media.Transform?>> getter, Func<Avalonia.Media.Transform?>? fallbackGetter = null, Action<Avalonia.Media.Transform?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Media.Geometry 
   => control._set(Avalonia.Media.Geometry.TransformProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Transform<T>(this T control, IBinding binding) where T : Avalonia.Media.Geometry 
   => control._set(Avalonia.Media.Geometry.TransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Transform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Geometry 
   => control._set(Avalonia.Media.Geometry.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Events ======================//
 // Changed

/*ActionToEventGenerator*/
public static T OnChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.Geometry  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Changed += h);



}
