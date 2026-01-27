using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Markup.Declarative;
using Avalonia.Threading;

internal class ViewPropertyAsyncComputedState<TValue> : ExpressionBindingBase, IObservable<TValue>, INotifyPropertyChanged
{
    private Func<ValueTask<TValue>> GetterFunc { get; }
    private Func<TValue>? FallbackGetter { get; }
    private TValue? _currentValue;
    private long _activeVersion = 0;

    public ViewPropertyAsyncComputedState(string? expressionString, Func<ValueTask<TValue>> getterFunc, Func<TValue>? fallbackGetter)
    {
        GetterFunc = getterFunc;
        FallbackGetter = fallbackGetter;
        ExpressionString = expressionString;
        
        _currentValue = fallbackGetter is null ? default : fallbackGetter();
        _ = TriggerUpdate();
    }

    public TValue? Value => _currentValue;
    public event PropertyChangedEventHandler? PropertyChanged;

    public override void OnPropertyChanged() => _ = TriggerUpdate();

    private async Task TriggerUpdate()
    {
        var version = Interlocked.Increment(ref _activeVersion);
        var task = GetterFunc();

        if (task.IsCompleted)
        {
            ApplyResult(task.GetAwaiter().GetResult(), version);
            return;
        }

        // Immediately show current fallback while waiting
        ApplyResult(FallbackGetter(), version);

        try
        {
            TValue result = await task;
            if (!Dispatcher.UIThread.CheckAccess())
                await Dispatcher.UIThread.InvokeAsync(() => ApplyResult(result, version));
            else
                ApplyResult(result, version);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Async update failed: {ex.Message}");
        }
    }

    private void ApplyResult(TValue? result, long version)
    {
        if (Interlocked.Read(ref _activeVersion) == version)
        {
            _currentValue = result;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
            NotifyObservers(result!);
        }
    }

    private readonly List<IObserver<TValue>> _observers = [];
    public IDisposable Subscribe(IObserver<TValue> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
            observer.OnNext(_currentValue!);
        }
        return new Unsubscriber(_observers, observer);
    }

    private void NotifyObservers(TValue value)
    {
        foreach (var observer in _observers) observer.OnNext(value);
    }

    private class Unsubscriber(ICollection<IObserver<TValue>> observers, IObserver<TValue> observer) : IDisposable
    {
        public void Dispose() => observers.Remove(observer);
    }
}

internal class ViewPropertyAsyncComputedState<TControl, TValue> : ExpressionBindingBase, IObservable<TValue>, IObserver<TValue>
    where TControl : AvaloniaObject
{
    private readonly TControl? _control;
    private readonly AvaloniaProperty<TValue>? _avaloniaProperty;
    private readonly ViewBase? _parentView;
    private readonly Action<TValue>? _setter;
    private readonly Action<TValue>? _setChangedHandler;
    
    private TValue? _lastValue;
    private long _activeVersion = 0;
    private bool _isUpdating;

    public Func<ValueTask<TValue>> GetterFunc { get; }
    public Func<TValue>? FallbackGetter { get; }

    internal ViewPropertyAsyncComputedState(
        string? expressionString,
        Func<ValueTask<TValue>> getterFunc,
        Func<TValue>? fallbackGetter,
        Action<TValue>? setChangedHandler,
        TControl? control,
        AvaloniaProperty<TValue>? avaloniaProperty,
        Action<TValue>? setter = null)
    {
        _control = control;
        _avaloniaProperty = avaloniaProperty;
        _setter = setter;
        _setChangedHandler = setChangedHandler;
        ExpressionString = expressionString;
        GetterFunc = getterFunc;
        FallbackGetter = fallbackGetter;
        _lastValue = fallbackGetter is null ? default : fallbackGetter();
        _parentView = ViewBuildContext.CurrentView;

        if (control != null)
        {
            ApplyValueToTarget(_lastValue);

            if (_avaloniaProperty != null)
            {
                control.Bind(_avaloniaProperty, this);
                if (setChangedHandler != null)
                    control.GetObservable(_avaloniaProperty).Subscribe(this);
            }
        }

        _ = TriggerUpdate();
    }

    public override void OnPropertyChanged() => _ = TriggerUpdate();

    private async Task TriggerUpdate()
    {
        var version = Interlocked.Increment(ref _activeVersion);
        var task = GetterFunc();

        if (task.IsCompleted)
        {
            ApplyResult(task.GetAwaiter().GetResult(), version);
            return;
        }

        // Revert UI to fallback (loading state) immediately
        if (FallbackGetter is not null)
        {
            var fallback = FallbackGetter();
            if (Dispatcher.UIThread.CheckAccess())
                ApplyValueToTarget(fallback);
            else
                await Dispatcher.UIThread.InvokeAsync(() => ApplyValueToTarget(fallback));
        }
        
        try
        {
            var newValue = await task;
            if (!Dispatcher.UIThread.CheckAccess())
                await Dispatcher.UIThread.InvokeAsync(() => ApplyResult(newValue, version));
            else
                ApplyResult(newValue, version);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Async control update failed: {ex.Message}");
        }
    }
    
    private void ApplyResult(TValue newValue, long version)
    {
        if (Interlocked.Read(ref _activeVersion) == version)
        {
            _isUpdating = true;
            try
            {
                ApplyValueToTarget(newValue);
                _lastValue = newValue;
                NotifyObservers(newValue);
            }
            finally { _isUpdating = false; }
        }
    }

    private void ApplyValueToTarget(TValue? value)
    {
        if (_control == null) return;
        if (_avaloniaProperty != null)
            _control.SetValue(_avaloniaProperty, value);
        else
            _setter?.Invoke(value!);
    }
    
    public void OnNext(TValue value)
    {
        if (_isUpdating || Equals(value, _lastValue)) return;
        _lastValue = value;
        _setChangedHandler?.Invoke(value);
        if (!string.IsNullOrEmpty(ExpressionString) && _parentView is ComponentBase pc)
            pc.NotifyExternalPropertyChanged(ExpressionString, value);
    }

    public void OnCompleted() { }
    public void OnError(Exception error) { }

    private readonly List<IObserver<TValue>> _observers = [];
    public IDisposable Subscribe(IObserver<TValue> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
            observer.OnNext(_lastValue!);
        }
        return new Unsubscriber(_observers, observer);
    }

    public void NotifyObservers(TValue value)
    {
        foreach (var observer in _observers)
            observer.OnNext(value);
    }

    private class Unsubscriber(ICollection<IObserver<TValue>> observers, IObserver<TValue> observer) : IDisposable
    {
        public void Dispose() => observers.Remove(observer);
    }
}