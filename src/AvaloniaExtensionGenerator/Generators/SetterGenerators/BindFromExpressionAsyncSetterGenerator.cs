using AvaloniaExtensionGenerator.ExtensionInfos;

namespace AvaloniaExtensionGenerator.Generators.SetterGenerators;

public class BindFromExpressionAsyncSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, Func<ValueTask<{info.ValueTypeSource}>> getter, Func<{info.ValueTypeSource}>? fallbackGetter = null, Action<{info.ValueTypeSource}>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null) {info.GenericConstraint} {Environment.NewLine}" +
        $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}!, getter, fallbackGetter, onChanged, expression);";
}