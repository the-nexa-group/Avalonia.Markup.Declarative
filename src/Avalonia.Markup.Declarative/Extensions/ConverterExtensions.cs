using Avalonia.Data.Converters;
using System.Globalization;
using Avalonia.Input;
using Avalonia.Media;

namespace Avalonia.Markup.Declarative;

public static class ConverterExtensions
{
    public static TOut TryConvert<TIn, TOut>(this FuncValueConverter<TIn, TOut> converter, TIn value)
    {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8603 // Possible null reference return.
        return (TOut)converter.Convert(value, typeof(TOut), null, CultureInfo.InvariantCulture);
#pragma warning restore CS8603 // Possible null reference return.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    }
    
    public static Brush ToBrush(this Color color) => new SolidColorBrush(color);
    public static Cursor ToCursor(this StandardCursorType cursor) => new(cursor);
}