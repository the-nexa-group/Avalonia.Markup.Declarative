namespace AvaloniaExtensionGenerator.Generators;

public static class TypeFormatExtensions
{
    public static string GetTypeDeclarationSourceCode(this Type valueType, bool isNullable = false)
    {
        var result = valueType.Name;
        if (valueType.IsGenericType)
        {
            result = result.Split('`')[0];
            var genericArguments = valueType
                .GetGenericArguments()
                .Select(innerType => GetTypeDeclarationSourceCode(innerType));

            var args = string.Join(",", genericArguments);
            result += $"<{args}>";
        }

        if (!string.IsNullOrWhiteSpace(valueType.Namespace))
        {
            result = valueType.Namespace + "." + result;
        }

        if (isNullable)
        {
            result += "?";
        }

        return result;
    }

}