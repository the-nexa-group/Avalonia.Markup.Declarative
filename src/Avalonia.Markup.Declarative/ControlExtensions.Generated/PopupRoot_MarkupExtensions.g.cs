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
public static partial class PopupRoot_MarkupExtensions
{
//================= Properties ======================//
 // Transform

/*ValueSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, Avalonia.Media.Transform? value)  
=> control._set(() => control.Transform = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, Func<Avalonia.Media.Transform?> func, Action<Avalonia.Media.Transform?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.TransformProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, Func<ValueTask<Avalonia.Media.Transform?>> getter, Func<Avalonia.Media.Transform?>? fallbackGetter = null, Action<Avalonia.Media.Transform?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.TransformProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, IBinding binding)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // WindowManagerAddShadowHint

/*ValueSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, System.Boolean value)  
=> control._set(() => control.WindowManagerAddShadowHint = value);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, Func<ValueTask<System.Boolean>> getter, Func<System.Boolean>? fallbackGetter = null, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, IBinding binding)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Transform

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> Transform(this Style<Avalonia.Controls.Primitives.PopupRoot> style, Avalonia.Media.Transform? value)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> Transform(this Style<Avalonia.Controls.Primitives.PopupRoot> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, binding);


 // WindowManagerAddShadowHint

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> WindowManagerAddShadowHint(this Style<Avalonia.Controls.Primitives.PopupRoot> style, System.Boolean value)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> WindowManagerAddShadowHint(this Style<Avalonia.Controls.Primitives.PopupRoot> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, binding);



}
