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
public static partial class RadioButton_MarkupExtensions
{
//================= Properties ======================//
 // GroupName

/*ValueSetterGenerator*/
public static T GroupName<T>(this T control, System.String? value) where T : Avalonia.Controls.RadioButton 
=> control._set(() => control.GroupName = value);

/*BindFromExpressionSetterGenerator*/
public static T GroupName<T>(this T control, Func<System.String?> func, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.RadioButton 
   => control._set(Avalonia.Controls.RadioButton.GroupNameProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T GroupName<T>(this T control, Func<ValueTask<System.String?>> getter, Func<System.String?>? fallbackGetter = null, Action<System.String?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.RadioButton 
   => control._set(Avalonia.Controls.RadioButton.GroupNameProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T GroupName<T>(this T control, IBinding binding) where T : Avalonia.Controls.RadioButton 
   => control._set(Avalonia.Controls.RadioButton.GroupNameProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T GroupName<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RadioButton 
   => control._set(Avalonia.Controls.RadioButton.GroupNameProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // GroupName

/*ValueStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.RadioButton 
=> style._addSetter(Avalonia.Controls.RadioButton.GroupNameProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RadioButton 
=> style._addSetter(Avalonia.Controls.RadioButton.GroupNameProperty, binding);



}
