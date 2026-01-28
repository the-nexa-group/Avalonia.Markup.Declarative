using System.ComponentModel;
using Avalonia.Controls;

namespace Avalonia.Markup.Declarative.Tests;

public partial class TestObservableComponent : ComponentBase
{
    // Regular Observe attribute - subscribes once, doesn't handle reassignment
    [Observe]
    public TestViewModel? StaticViewModel { get; set; }

    // New Observable attribute - handles reassignment automatically  
    [Observable] 
    TestViewModel? _dynamicViewModel;
    
    [Observable]
    int _someNumber;
    
    [Observable]
    string? _someText = "Hello";

    protected override Control? Build()
    {
        return new TextBlock()
            .Text(() => SomeText, v => SomeText = v);
    }
}

public class TestViewModel : INotifyPropertyChanged
{
    private string _name = "";
    public string Name
    {
        get => _name;
        set
        {
            if (_name != value)
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}