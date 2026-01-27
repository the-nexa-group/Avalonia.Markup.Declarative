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
public static partial class OverlayPopupHost_MarkupExtensions
{
//================= Properties ======================//
 // Transform

/*ValueSetterGenerator*/
public static T Transform<T>(this T control, Avalonia.Media.Transform? value) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
=> control._set(() => control.Transform = value);

/*BindFromExpressionSetterGenerator*/
public static T Transform<T>(this T control, Func<Avalonia.Media.Transform?> func, Action<Avalonia.Media.Transform?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
   => control._set(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Transform<T>(this T control, Func<ValueTask<Avalonia.Media.Transform?>> getter, Func<Avalonia.Media.Transform?>? fallbackGetter = null, Action<Avalonia.Media.Transform?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
   => control._set(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Transform<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
   => control._set(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Transform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
   => control._set(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Transform

/*ValueStyleSetterGenerator*/
public static Style<T> Transform<T>(this Style<T> style, Avalonia.Media.Transform? value) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
=> style._addSetter(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Transform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
=> style._addSetter(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, binding);



}
