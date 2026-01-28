using System;
using Avalonia.Controls;

namespace Avalonia.Markup.Declarative;

public class FuncComponent<TViewModel>(TViewModel model, Func<TViewModel, Control?> build) : Component
{
    protected override Control? Build() => build.Invoke(model);
}