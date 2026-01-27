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
public static partial class DefinitionBase_MarkupExtensions
{
//================= Properties ======================//
 // SharedSizeGroup

/*ValueSetterGenerator*/
public static T SharedSizeGroup<T>(this T control, System.String? value) where T : Avalonia.Controls.DefinitionBase 
=> control._set(() => control.SharedSizeGroup = value);

/*BindFromExpressionSetterGenerator*/
public static T SharedSizeGroup<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DefinitionBase 
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T SharedSizeGroup<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.DefinitionBase 
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T SharedSizeGroup<T>(this T control, IBinding binding) where T : Avalonia.Controls.DefinitionBase 
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SharedSizeGroup<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DefinitionBase 
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
