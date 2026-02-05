using System;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;

public static class ControlMiscExtensions
{
    extension<TAvObject>(TAvObject control)
        where TAvObject : AvaloniaObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TAvObject Execute(Action func)
        {
            func();
            return control;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TAvObject Execute(Action<TAvObject> func)
        {
            func(control);
            return control;
        }
        
        /// <summary>
        /// Sets control instance reference to field so it can be accessed later in Markup
        /// </summary>
        /// <param name="field">field that will accept reference to control</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TAvObject Ref(out TAvObject field)
        {
            field = control;
            return control;
        }  
    }
}