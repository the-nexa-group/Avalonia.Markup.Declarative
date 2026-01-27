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
public static partial class UniformGrid_MarkupExtensions
{
//================= Properties ======================//
 // Rows

/*ValueSetterGenerator*/
public static T Rows<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._set(() => control.Rows = value);

/*BindFromExpressionSetterGenerator*/
public static T Rows<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Rows<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Rows<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Rows<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowsProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // Columns

/*ValueSetterGenerator*/
public static T Columns<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._set(() => control.Columns = value);

/*BindFromExpressionSetterGenerator*/
public static T Columns<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T Columns<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T Columns<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Columns<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // FirstColumn

/*ValueSetterGenerator*/
public static T FirstColumn<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._set(() => control.FirstColumn = value);

/*BindFromExpressionSetterGenerator*/
public static T FirstColumn<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T FirstColumn<T>(this T control, Func<ValueTask<System.Int32>> getter, Func<System.Int32>? fallbackGetter = null, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T FirstColumn<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FirstColumn<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // RowSpacing

/*ValueSetterGenerator*/
public static T RowSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._set(() => control.RowSpacing = value);

/*BindFromExpressionSetterGenerator*/
public static T RowSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T RowSpacing<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T RowSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RowSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);


 // ColumnSpacing

/*ValueSetterGenerator*/
public static T ColumnSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._set(() => control.ColumnSpacing = value);

/*BindFromExpressionSetterGenerator*/
public static T ColumnSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ColumnSpacing<T>(this T control, Func<ValueTask<System.Double>> getter, Func<System.Double>? fallbackGetter = null, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ColumnSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ColumnSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // Rows

/*ValueStyleSetterGenerator*/
public static Style<T> Rows<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Rows<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowsProperty, binding);


 // Columns

/*ValueStyleSetterGenerator*/
public static Style<T> Columns<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Columns<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty, binding);


 // FirstColumn

/*ValueStyleSetterGenerator*/
public static Style<T> FirstColumn<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FirstColumn<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty, binding);


 // RowSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> RowSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RowSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty, binding);


 // ColumnSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> ColumnSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ColumnSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty, binding);



}
