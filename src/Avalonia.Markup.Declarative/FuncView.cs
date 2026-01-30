using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;

namespace Avalonia.Markup.Declarative;

public class FuncView<TViewModel>(TViewModel model, Func<TViewModel, Control?> build) : ViewBase<TViewModel>(model)
{
    protected override Control? Build(TViewModel? vm) => build.Invoke(vm!);
}

/// <summary>
/// Effectively combines FuncDataTemplate and FuncView into a single command; reducing boilerplate.
/// Useful for when you want to use special bindings for a control generated within an Item Template.
/// </summary>
public class FuncViewDataTemplate<TViewModel>(Func<TViewModel, Control> build)
    : FuncDataTemplate<TViewModel>((model, _) => new FuncView<TViewModel>((TViewModel?)model!, build));
    