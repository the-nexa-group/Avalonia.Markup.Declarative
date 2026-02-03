using Avalonia.Input;
using Avalonia.Interactivity;

namespace Avalonia.Markup.Declarative;

public static class InputExtensions
{
    public delegate bool KeyEvent(KeyEventArgs keyEvent);

    extension<T>(T control) where T : InputElement
    {
        public T Cursor(StandardCursorType cursorType)
        {
            control.Cursor = new Cursor(cursorType);
            return control;
        }

        public T OnKeyDown(Key key, KeyModifiers keyModifiers, KeyEvent action, RoutingStrategies? routes = null)
        {
            control.KeyDown += (_, args) =>
            {
                if (args.Key == key && args.KeyModifiers == keyModifiers)
                    args.Handled = action.Invoke(args);
            };

            return control;
        }

        public T OnKeyDown(Key key, KeyEvent action, RoutingStrategies? routes = null) => 
            OnKeyDown(control, key, KeyModifiers.None, action, routes);

        public T OnKeyUp(Key key, KeyModifiers keyModifiers, KeyEvent action, RoutingStrategies? routes = null)
        {
            control.KeyUp += (_, args) =>
            {
                if (args.Key == key && args.KeyModifiers == keyModifiers)
                    args.Handled = action.Invoke(args);
            };

            return control;
        }

        public T OnKeyUp(Key key, KeyEvent action, RoutingStrategies? routes = null) => 
            OnKeyUp(control, key, KeyModifiers.None, action, routes);
    }
}