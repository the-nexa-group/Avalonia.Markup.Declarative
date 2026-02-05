using System;
using Avalonia.Interactivity;

namespace Avalonia.Markup.Declarative;

public static class ControlEventExtensions
{
    public static TControl _setEvent<TControl, THandler>(
        this TControl control, 
        THandler handler, 
        Action<THandler> subscribe)
        where TControl : AvaloniaObject
    {
        subscribe.Invoke(handler);
        return control;
    }
    
    extension<T>(T interactive) where T : Interactive
    {
        /// <summary>
        /// Binds a delegate to an Avalonia Routed Event.
        /// Useful for when Declarative Bindings don't already exist for a particular control.
        /// </summary>
        public T Handle<TEvent>(
            RoutedEvent<TEvent> routedEvent,
            Action<TEvent> action,
            RoutingStrategies? routes = null) where TEvent : RoutedEventArgs
        {
            interactive.AddHandler(
                routedEvent, 
                (EventHandler<TEvent>) ((_, args) => action(args)), routes ??  routedEvent.RoutingStrategies);
            
            return interactive;
        }
    }
}