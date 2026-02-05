using System.Linq;
using Avalonia.Data;
using Avalonia.Data.Converters;

namespace Avalonia.Markup.Declarative;

public static class MultiBindingHelper
{
    /// <summary>
    /// Converts up to 4 double bindings into a single thickness binding
    /// </summary>
    public static IBinding DoubleBindingsToThicknessBinding(
        IBinding? left = null,
        IBinding? top = null,
        IBinding? right = null,
        IBinding? bottom = null)
    {
        MultiBinding multiBinding = new()
        {
            // Define a converter that takes the 4 inputs and returns a Thickness
            Converter = new FuncMultiValueConverter<object, Thickness>(values =>
            {
                // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
                if (values is null)
                    return new Thickness(0);
            
                var args = values.ToList();
                double GetVal(int index) => 
                    index < args.Count && args[index] is double d ? d : 0.0;

                // Order must match the order we add bindings below
                return new Thickness(GetVal(0), GetVal(1), GetVal(2), GetVal(3));
            })
        };

        // Add bindings to the list. 
        // If a specific side is null (not provided), we bind it to a static 0.0 
        // to ensure the converter always receives exactly 4 arguments in the correct order.
        multiBinding.Bindings.Add(left ?? new Binding { Source = 0.0 });
        multiBinding.Bindings.Add(top ?? new Binding { Source = 0.0 });
        multiBinding.Bindings.Add(right ?? new Binding { Source = 0.0 });
        multiBinding.Bindings.Add(bottom ?? new Binding { Source = 0.0 });
        
        return multiBinding;
    }

    /// <summary>
    /// Converts a single double binding into a uniform thickness binding
    /// </summary>
    public static IBinding DoubleBindingToUniformThickness(IBinding doubleBinding)
    {
        MultiBinding binding = new()
        {
            Converter = new FuncMultiValueConverter<object, Thickness>(values =>
            {
                double safeValue = values.FirstOrDefault() is double d ? d : 0;
                return new Thickness(safeValue);
            }),
            FallbackValue = 0d
        };
        
        binding.Bindings.Add(doubleBinding);
        return binding;
    }
}