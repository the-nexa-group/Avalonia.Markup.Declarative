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
public static partial class ItemsPresenter_MarkupExtensions
{
//================= Properties ======================//
 // ItemsPanel

/*ValueSetterGenerator*/
public static T ItemsPanel<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>? value) where T : Avalonia.Controls.Presenters.ItemsPresenter 
=> control._set(() => control.ItemsPanel = value);

/*BindFromExpressionSetterGenerator*/
public static T ItemsPanel<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>?> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>?>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.ItemsPresenter 
   => control._set(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T ItemsPanel<T>(this T control, Func<ValueTask<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>?>> getter, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>?>? fallbackGetter = null, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>?>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Controls.Presenters.ItemsPresenter 
   => control._set(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T ItemsPanel<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ItemsPresenter 
   => control._set(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemsPanel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ItemsPresenter 
   => control._set(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, avaloniaProperty, bindingMode, converter, overrideView);



//================= Styles ======================//
 // ItemsPanel

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>? value) where T : Avalonia.Controls.Presenters.ItemsPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ItemsPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, binding);



}
