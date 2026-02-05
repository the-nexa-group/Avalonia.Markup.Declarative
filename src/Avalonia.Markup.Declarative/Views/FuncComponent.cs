using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;

namespace Avalonia.Markup.Declarative;

public class FuncComponent<TViewModel>(TViewModel model, Func<TViewModel, Control?> build) : ComponentBase
{
    protected override Control? Build() => build.Invoke(model);
}

/// <summary>
/// Effectively combines FuncDataTemplate and FuncComponent into a single command; reducing boilerplate.
/// Useful for when you want to use special bindings for a control generated within an Item Template.
/// </summary>
public class FuncCompDataTemplate<TViewModel>(Func<TViewModel, Control> build)
    : FuncDataTemplate<TViewModel>((model, _) => new FuncComponent<TViewModel>((TViewModel?)model!, build));
