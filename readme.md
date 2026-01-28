# Avalonia.Markup.Declarative

**A C# markup framework for Avalonia UI**

## Features

- **C#-Only UI** - Write Avalonia applications without any XAML
- **Hot Reload Support** - .NET 6.0+ hot reload for C# markup
- **MVU & MVVM Patterns** - Flexible component architecture supporting both patterns
- **Reactive Attributes** - New `[Observe]` and `[Observable]` attributes for automatic property change handling
- **Source Generation** - Compile-time extensions for custom controls
- **Dependency Injection** - Compile-time dependency injection
- **No Reflection** - Keep performance high by avoiding reflection
- **External Library Support** - Generate extensions for third-party controls

## Quick Start

### MVU Pattern 

```csharp
public partial class CounterComponent : ComponentBase
{
    [Inject] DataService DataService { get; set; } = null!;
    
    public int Counter { get; set; }

    protected override Control Build() => new StackPanel()
        .Children(
            new TextBlock()
                .Text("Hello World"),
            new TextBlock()
                .Text(() => $"Count: {Counter}"),
            new Button()
                .Content("Click me")
                .OnClick(OnButtonClick)
        );

    private void OnButtonClick(RoutedEventArgs e)
    {
        Counter++;
        StateHasChanged();
    }
}
```

### Extended MVU Pattern (recommended)

```csharp
public partial class CounterComponent : ComponentBase
{
    [Inject] DataService DataService { get; set; } = null!;
    
    [Observable] int _counter;

    protected override Control Build() => new StackPanel()
        .Children(
            new TextBlock()
                .Text("Hello World"),
            new TextBlock()
                .Text(() => $"Count: {Counter}"),
            new Button()
                .Content("Click me")
                .OnClick(() => Counter++;)
        );
}
```

### MVVM Pattern

```csharp
public class MainView : ViewBase<MainViewModel>
{
    protected override Control Build(MainViewModel vm) => new Grid()
        .Cols("Auto, *")
        .Children(
            new TextBlock()
                .Text(() => vm.Title),
            new Button()
                .Col(1)
                .Content("Click me")
                .OnClick(() => vm.OnClick())
        );
}
```

## New Features

### `[Observe]` Attribute

Automatically subscribes to `INotifyPropertyChanged` changes on properties or fields and updates the UI:

```csharp
public partial class MyComponent : ComponentBase
{
    [Observe]
    public StatusModel Status { get; init; };
}
```

### `[Observable]` Attribute

Marks a field as an Observable Property. Generates a public property and an Avalonia Property, which automatically triggers UI updates on changes.
Fields with `INotifyPropertyChanged` types are automatically subscribed and unsubscribed to and act similar to the `[Observe]` attribute:
```csharp
public partial class DataComponent : ComponentBase
{
    [Observable]
    private INotifyPropertyChanged _dataSource;
    
    // Generates
    public static readonly AvaloniaDirectProperty<DataComponent, INotifyPropertyChanged> DataSourceProperty;
    
    public INotifyPropertyChanged DataSource { get; set; }
}
```

## Advanced Features

### Custom Controls with Source Generation

```xml
<ItemGroup>
    <ProjectReference Include="..\..\Avalonia.Markup.Declarative.SourceGenerator\Avalonia.Markup.Declarative.SourceGenerator.csproj" 
                      OutputItemType="Analyzer" ReferenceOutputAssembly="false" />
</ItemGroup>
```

### Styling

```csharp
protected override StyleGroup? BuildStyles() =>
[
    new Style<Button>()
        .Margin(6)
        .Background(Brushes.DarkSalmon),
    new Style<Button>(s => s.Class(":pointerover").Child())
        .Background(Brushes.Red)
];
```

### Hot Reload

```csharp
AppBuilder.Configure<Application>()
    .UseRiderHotReload() // For JetBrains Rider
    .SetupWithLifetime(lifetime);
```

## Project Structure

- `src/Avalonia.Markup.Declarative/` - Core framework
- `src/Avalonia.Markup.Declarative.SourceGenerator/` - Source generators
- `src/AvaloniaExtensionGenerator/` - External library tool
- `Samples/` - Example applications and patterns

## About This Fork

This is a community-driven fork of AvaloniaUI/Avalonia.Markup.Declarative. The original repository serves as a proof-of-concept for writing Avalonia UI in pure C#. 
This fork builds upon that foundation with the goal of extending its capabilities and exploring the potential of C# markup as a more developed alternative to XAML.

## License

MIT

---

**Note:** This is a community-driven project and not officially supported by the Avalonia team. For official Avalonia support, use their supported XAML approach.
