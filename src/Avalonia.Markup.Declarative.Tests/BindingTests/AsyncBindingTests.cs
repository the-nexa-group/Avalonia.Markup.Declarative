using Avalonia.Controls;
using Avalonia.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FluentAssertions;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class AsyncBindingTests : AvaloniaTestBase
{
    // --- Test Data Structures ---

    public class AsyncViewModel : INotifyPropertyChanged
    {
        private string _name = "User";
        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(); }
        }

        private int _requestId = 0;
        public int RequestId
        {
            get => _requestId;
            set { _requestId = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? prop = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }

    public class AsyncTestView : ViewBase<AsyncViewModel>
    {
        // Test controls this to simulate network delay
        public TaskCompletionSource<string?> Tcs = new();

        public AsyncTestView(AsyncViewModel viewModel) : base(viewModel) { }

        public TextBlock TargetTextBlock = null!;

        protected override Control Build(AsyncViewModel? vm) =>
            new TextBlock()
                .Ref(out TargetTextBlock)
                .Text(async () =>
                {
                    // Capture dependency so binding system watches 'Name'
                    var n = ViewModel?.Name; 
                    // Await the test-controlled task
                    var result = await Tcs.Task;
                    return $"{n}: {result}";
                }, () => "Loading...");
    }

    // --- Tests ---

    [Fact]
    public void Text_Shows_Fallback_Immediately()
    {
        var vm = new AsyncViewModel();
        var view = new AsyncTestView(vm);
        
        // Attach to Window to ensure visual tree and bindings are active
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        // Tcs is not set, should show fallback
        view.TargetTextBlock.Text.Should().Be("Loading...");
    }

    [Fact]
    public void Text_Updates_When_Task_Completes()
    {
        var vm = new AsyncViewModel();
        var view = new AsyncTestView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        // Act: Finish the task
        view.Tcs.SetResult("Done");
        Dispatcher.UIThread.RunJobs();

        // Assert
        view.TargetTextBlock.Text.Should().Be("User: Done");
    }

    [Fact]
    public void Text_Retriggers_When_Dependency_Changes()
    {
        var vm = new AsyncViewModel();
        var view = new AsyncTestView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        // 1. Finish first request
        view.Tcs.SetResult("First");
        Dispatcher.UIThread.RunJobs();
        view.TargetTextBlock.Text.Should().Be("User: First");

        // 2. Reset TCS for next request
        view.Tcs = new TaskCompletionSource<string?>();

        // 3. Change Dependency (triggers re-evaluation)
        vm.Name = "Admin"; 
        
        // Run loop to process PropertyChanged event
        Dispatcher.UIThread.RunJobs();
        
        // Should revert to fallback while new task is pending
        view.TargetTextBlock.Text.Should().Be("Loading...");

        // 4. Finish second request
        view.Tcs.SetResult("Second");
        Dispatcher.UIThread.RunJobs();

        view.TargetTextBlock.Text.Should().Be("Admin: Second");
    }

    // Custom view for Race Condition test to handle multiple TCSs
    public class RaceConditionView : ViewBase<AsyncViewModel>
    {
        public TaskCompletionSource<string?> SlowTask = new();
        public TaskCompletionSource<string?> FastTask = new();

        public RaceConditionView(AsyncViewModel vm) : base(vm) { }
        public TextBlock TargetTextBlock = null!;

        protected override Control Build(AsyncViewModel? vm) =>
            new TextBlock()
                .Ref(out TargetTextBlock)
                .Text(async () =>
                {
                    // Depend on RequestId to trigger updates
                    var id = vm?.RequestId;
                    if (id == 1) return await SlowTask.Task;
                    return await FastTask.Task;
                }, () => "Waiting...");
    }

    [Fact]
    public void Text_Race_Condition_Slow_Old_Does_Not_Overwrite_Fast_New()
    {
        var vm = new AsyncViewModel();
        var view = new RaceConditionView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        // 1. Trigger Slow Request (RequestId = 1)
        vm.RequestId = 1; 
        Dispatcher.UIThread.RunJobs();
        view.TargetTextBlock.Text.Should().Be("Waiting...");

        // 2. Trigger Fast Request (RequestId = 2) immediately after
        vm.RequestId = 2;
        Dispatcher.UIThread.RunJobs();
        
        // 3. Complete Fast Request (Newer)
        view.FastTask.SetResult("Fast Result");
        Dispatcher.UIThread.RunJobs();
        view.TargetTextBlock.Text.Should().Be("Fast Result");

        // 4. Complete Slow Request (Older/Stale)
        view.SlowTask.SetResult("Slow Result");
        Dispatcher.UIThread.RunJobs();

        // Assert: Value should REMAIN "Fast Result" (Old result ignored)
        view.TargetTextBlock.Text.Should().Be("Fast Result");
    }

    // Custom view for Instant value test
    public class InstantView : Component
    {
        public TextBlock TargetTextBlock = null!;
        protected override Control Build() =>
            new TextBlock()
                .Ref(out TargetTextBlock)
                .Text(() => ValueTask.FromResult<string?>("Instant"), () => "Loading...");
    }

    [Fact]
    public void Text_Instant_Value_Bypasses_Fallback_Visuals()
    {
        var view = new InstantView();
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        // Should be "Instant" immediately, never showing "Loading..." logic
        view.TargetTextBlock.Text.Should().Be("Instant");
    }
    
    [Fact]
    public void Text_Retriggers_When_DataContext_Changes()
    {
        // Test that swapping the VM out entirely triggers a new async fetch
        var vm1 = new AsyncViewModel { Name = "FirstVM" };
        var vm2 = new AsyncViewModel { Name = "SecondVM" };
        var view = new AsyncTestView(vm1);
        var window = new Window { Content = view };
        window.Show();
        
        // Complete first VM task
        view.Tcs.SetResult("Data1");
        Dispatcher.UIThread.RunJobs();
        view.TargetTextBlock.Text.Should().Be("FirstVM: Data1");

        // Act: Swap DataContext
        view.Tcs = new TaskCompletionSource<string?>();
        view.DataContext = vm2;
        
        // Assert: Should go back to fallback for the new VM
        Dispatcher.UIThread.RunJobs();
        view.TargetTextBlock.Text.Should().Be("Loading...");

        // Complete second VM task
        view.Tcs.SetResult("Data2");
        Dispatcher.UIThread.RunJobs();
        view.TargetTextBlock.Text.Should().Be("SecondVM: Data2");
    }

    [Fact]
    public void Text_Handles_Task_Failure_Gracefully()
    {
        // Ensure that a faulted task doesn't crash the UI and ideally stays on fallback or last value
        var vm = new AsyncViewModel();
        var view = new AsyncTestView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        // Act: Fail the task
        view.Tcs.SetException(new System.Exception("Network Fail"));
        
        // We wrap in Record.Exception or just verify it doesn't throw on the UI thread
        var action = () => Dispatcher.UIThread.RunJobs();
        action.Should().NotThrow();

        // Assert: Depending on your logic, it should probably stay on "Loading..." 
        // or log the error. Most importantly, it shouldn't crash.
        view.TargetTextBlock.Text.Should().Be("Loading...");
    }
}