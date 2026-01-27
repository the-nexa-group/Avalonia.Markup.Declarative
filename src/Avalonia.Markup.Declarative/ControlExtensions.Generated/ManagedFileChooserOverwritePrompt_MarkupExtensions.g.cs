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
public static partial class ManagedFileChooserOverwritePrompt_MarkupExtensions
{
//================= Properties ======================//
 // FileName

/*ValueSetterGenerator*/
public static T FileName<T>(this T control, System.String value) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt 
=> control._set(() => control.FileName = value);

/*BindFromExpressionSetterGenerator*/
public static T FileName<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt 
   => control._set(Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty!, func, onChanged, expression);

/*BindFromExpressionAsyncSetterGenerator*/
public static T FileName<T>(this T control, Func<ValueTask<System.String>> getter, Func<System.String>? fallbackGetter = null, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt 
   => control._set(Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty!, getter, fallbackGetter, onChanged, expression);

/*BindSetterGenerator*/
public static T FileName<T>(this T control, IBinding binding) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt 
   => control._set(Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FileName<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt 
   => control._set(Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty, avaloniaProperty, bindingMode, converter, overrideView);



}
