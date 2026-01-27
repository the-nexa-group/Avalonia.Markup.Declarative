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
public static partial class Path_MarkupExtensions
{
//================= Properties ======================//
 // Data

/*ValueSetterGenerator*/
public static T Data<T>(this T control, Avalonia.Media.Geometry? value) where T : Avalonia.Controls.Shapes.Path 
=> control._set(() => control.Data = value);

/*BindFromExpressionSetterGenerator*/
public static T Data<T>(this T control, Func<Avalonia.Media.Geometry?> func, Action<Avalonia.Media.Geometry?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Path 
   => control._set(Avalonia.Controls.Shapes.Path.DataProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Data<T>(this T control, Func<ValueTask<Avalonia.Media.Geometry?>> getter, Func<Avalonia.Media.Geometry?>? fallbackGetter = null, Action<Avalonia.Media.Geometry?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Shapes.Path 
   => control._set(Avalonia.Controls.Shapes.Path.DataProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Data<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Path 
   => control._set(Avalonia.Controls.Shapes.Path.DataProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Data<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Path 
   => control._set(Avalonia.Controls.Shapes.Path.DataProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Data

/*ValueStyleSetterGenerator*/
public static Style<T> Data<T>(this Style<T> style, Avalonia.Media.Geometry? value) where T : Avalonia.Controls.Shapes.Path 
=> style._addSetter(Avalonia.Controls.Shapes.Path.DataProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Data<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Path 
=> style._addSetter(Avalonia.Controls.Shapes.Path.DataProperty, binding);



}
