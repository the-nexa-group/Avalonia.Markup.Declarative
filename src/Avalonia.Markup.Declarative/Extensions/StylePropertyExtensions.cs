using Avalonia.Styling;
using System;
using Avalonia.Controls;

namespace Avalonia.Markup.Declarative;

public static class StylePropertyExtensions
{
    extension(Style style)
    {
        public Style Selector(Func<Selector?, Selector> selector)
        {
            style.Selector = selector(null);
            return style;
        }

        public Style Setter(AvaloniaProperty avaloniaProperty, object value)
        {
            style.Setters.Add(new Setter(avaloniaProperty, value));
            return style;
        }
    }

    /// <param name="style">Style</param>
    /// <typeparam name="TElement">Type of the control that style will be applied</typeparam>
    extension<TElement>(Style<TElement> style) where TElement : StyledElement
    {
        public Style<TElement> _addSetter(AvaloniaProperty avaloniaProperty, object? value)
        {
            style.Setters.Add(new Setter(avaloniaProperty, value));
            return style;
        }

        public Style<TElement> Setter(AvaloniaProperty avaloniaProperty, object? value) => 
            style._addSetter(avaloniaProperty, value);

        /// <summary>
        /// Creates selector and applies .OfTypeTElement() to it
        /// </summary>
        /// <param name="selector">Selector modifier function</param>
        /// <returns>style with applied selector</returns>
        public Style<TElement> Selector(Func<Selector, Selector> selector)
        {
            Selector TypeSelector(Selector? s) => s.OfType<TElement>();
            style.Selector = selector(TypeSelector(null));
            return style;
        }
    }
    
    extension<TElement>(Style<TElement> style) where TElement : Control
    {
        public Style<TElement> Col(int value)
        {
            style.Add(new Setter(Grid.ColumnProperty, value));
            return style;
        }

        public Style<TElement> Row(int value)
        {
            style.Add(new Setter(Grid.RowProperty, value));
            return style;
        }

        public Style<TElement> ColSpan(int value)
        {
            style.Add(new Setter(Grid.ColumnSpanProperty, value));
            return style;
        }

        public Style<TElement> RowSpan(int value)
        {
            style.Add(new Setter(Grid.RowSpanProperty, value));
            return style;
        }
    }

    extension(Selector selector)
    {
        public Selector PointerOver() => selector.Class(":pointerover");
        public Selector Focus() => selector.Class(":focus");
    }
}