using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#nullable enable
namespace Avalonia.Markup.Declarative.SourceGenerator;

[Generator]
public class AvaloniaControlExtensionsGenerator : IIncrementalGenerator
{
    private static readonly string[] InitialNamespaces = 
    [
        "Avalonia.Data",
        "Avalonia.Data.Converters", 
        "System",
        "System.Diagnostics.CodeAnalysis",
        "System.Numerics",
        "System.Linq.Expressions",
        "System.Runtime.CompilerServices",
        "System.Threading.Tasks"
    ];
    
    private static readonly DiagnosticDescriptor GeneratorError = new(
        id: "AVGEN001",
        title: "Source Generation Failed",
        messageFormat: "Failed to generate extensions for {0}. Reason: {1}.",
        category: "AvaloniaGenerator",
        defaultSeverity: DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var compilationProvider = context.CompilationProvider;
        
        context.RegisterSourceOutput(compilationProvider, (spc, compilation) =>
        {
            var avaloniaObjectSymbol = compilation.GetTypeByMetadataName("Avalonia.AvaloniaObject");
            if (avaloniaObjectSymbol == null)
                return;

            var styledElementSymbol = compilation.GetTypeByMetadataName("Avalonia.StyledElement");
            
            var controlTypes = GetAllControlTypes(compilation, avaloniaObjectSymbol);
            var generatedTypeNames = new HashSet<string>();
            
            foreach (var controlType in controlTypes)
            {
                if (ShouldSkipType(controlType))
                    continue;

                var fullName = controlType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
                var fileName = $"{fullName.Replace(".", "_").Replace("global::", "")}_MarkupExtensions.g.cs";
                
                // Skip if we've already generated extensions for this type name
                if (!generatedTypeNames.Add(fileName))
                    continue;
                
                // Additional check: Skip if this type comes from an external assembly that's not the current assembly
                // or if the extension class already exists in the compilation
                if (ExtensionClassAlreadyExists(compilation, controlType))
                    continue;
                
                try
                {
                    var extensions = GenerateExtensionsForType(compilation, controlType, styledElementSymbol);
                    if (!string.IsNullOrEmpty(extensions))
                    {
                        spc.AddSource(fileName, SourceText.From(extensions, Encoding.UTF8));
                    }
                }
                catch (Exception e)
                {
                    // Get the location of the class to point the error at the right line
                    Location location = controlType.Locations.FirstOrDefault() ?? Location.None;
                    
                    spc.AddSource($"Generator_Error_Log_{fullName}.g.cs", SourceText.From($"Failed to source gen control '{fullName}' because {e}"));

                    spc.ReportDiagnostic(Diagnostic.Create(
                        GeneratorError,
                        location, 
                        controlType.Name, 
                        e.ToString()));
                }
            }
        });
    }

    private static IEnumerable<INamedTypeSymbol> GetAllControlTypes(Compilation compilation, INamedTypeSymbol baseType)
    {
        var controlTypes = new List<INamedTypeSymbol>();
        var processedTypeNames = new HashSet<string>();
        
        // Look through all accessible types in the compilation
        foreach (var assembly in compilation.References)
        {
            if (compilation.GetAssemblyOrModuleSymbol(assembly) is IAssemblySymbol assemblySymbol)
            {
                var types = GetTypesFromNamespace(assemblySymbol.GlobalNamespace);
                foreach (var type in types.Where(type => IsControlType(type, baseType)))
                {
                    var fullName = type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
                    if (processedTypeNames.Add(fullName))
                    {
                        controlTypes.Add(type);
                    }
                }
            }
        }

        return controlTypes;
    }

    private static IEnumerable<INamedTypeSymbol> GetTypesFromNamespace(INamespaceSymbol namespaceSymbol)
    {
        var types = new List<INamedTypeSymbol>();
        
        // Add types in current namespace
        types.AddRange(namespaceSymbol.GetTypeMembers());
        
        // Recursively search child namespaces
        foreach (var childNamespace in namespaceSymbol.GetNamespaceMembers())
        {
            types.AddRange(GetTypesFromNamespace(childNamespace));
        }
        
        return types;
    }

    private static bool IsControlType(INamedTypeSymbol typeSymbol, INamedTypeSymbol baseType)
    {
        if (typeSymbol.DeclaredAccessibility != Accessibility.Public ||
            typeSymbol.IsGenericType ||
            typeSymbol.GetAttributes().Any(a => a.AttributeClass?.Name == "ObsoleteAttribute"))
            return false;

        var current = typeSymbol.BaseType;
        while (current != null)
        {
            if (SymbolEqualityComparer.Default.Equals(current, baseType))
                return true;
            current = current.BaseType;
        }
        return false;
    }

    private static bool ShouldSkipType(INamedTypeSymbol typeSymbol)
    {
        return false; // We'll generate for all suitable control types
    }

    private static string GenerateExtensionsForType(Compilation compilation, INamedTypeSymbol controlType, INamedTypeSymbol? styledElementSymbol)
    {
        var sb = new StringBuilder();
        var totalExtensions = 0;

        // Properties
        var propertyExtensions = GeneratePropertyExtensions(controlType, ref totalExtensions);
        
        // Attached Properties  
        var attachedPropertyExtensions = GenerateAttachedPropertyExtensions(compilation, controlType, ref totalExtensions);
    
        // Events
        var eventExtensions = GenerateEventExtensions(controlType, ref totalExtensions);
        
        // Styles (only for StyledElement and its descendants)
        var styleExtensions = IsStyledElement(controlType, styledElementSymbol) 
            ? GenerateStyleExtensions(controlType, ref totalExtensions)
            : string.Empty;

        if (totalExtensions == 0)
            return string.Empty;

        sb.AppendLine("#nullable enable");
        
        foreach (var ns in InitialNamespaces.OrderBy(x => x))
            sb.AppendLine($"using {ns};");
        
        string className = controlType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
        className = $"{className.Replace(".", "_").Replace("global::", "")}";
        
        sb.AppendLine();
        sb.AppendLine("namespace Avalonia.Markup.Declarative;");
        sb.AppendLine();
        sb.AppendLine("""[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaControlExtensionsGenerator", "1.0.0.0")]""");
        sb.AppendLine("[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]");
        sb.AppendLine($"public static partial class {className}_MarkupExtensions");
        sb.AppendLine("{");

        if (!string.IsNullOrEmpty(propertyExtensions))
        {
            sb.AppendLine("    //================= Properties ======================//");
            sb.AppendLine(propertyExtensions);
        }

        if (!string.IsNullOrEmpty(attachedPropertyExtensions))
        {
            sb.AppendLine("    //================= Attached Properties ======================//");
            sb.AppendLine(attachedPropertyExtensions);
        }

        if (!string.IsNullOrEmpty(eventExtensions))
        {
            sb.AppendLine("    //================= Events ======================//");
            sb.AppendLine(eventExtensions);
        }

        if (!string.IsNullOrEmpty(styleExtensions))
        {
            sb.AppendLine("    //================= Styles ======================//");
            sb.AppendLine(styleExtensions);
        }

        sb.AppendLine("}");

        return sb.ToString();
    }

    private static string GeneratePropertyExtensions(INamedTypeSymbol controlType, ref int totalExtensions)
    {
        var sb = new StringBuilder();
        var controlTypeName = GetFullTypeName(controlType);

        var processedProperties = new HashSet<string>();
        var properties = controlType.GetMembers()
            .OfType<IFieldSymbol>()
            .Where(f => IsAvaloniaPropertyField(f) && !IsReadOnlyField(f) && 
                           SymbolEqualityComparer.Default.Equals(f.ContainingType, controlType) && 
                           processedProperties.Add(f.Name));
        
        var isGeneric = !controlType.IsSealed;
        
        string returnType = isGeneric ? "TControl" : controlTypeName;
        if (isGeneric)
        {
            sb.AppendLine($"    extension<{returnType}>(TControl control)");
            sb.AppendLine($"        where {returnType} : {controlTypeName}");
        }
        else
        {
            sb.AppendLine($"    extension({controlTypeName} control)");
        }

        sb.AppendLine("    {");

        foreach (var field in properties)
        {
            var propertyName = field.Name.Replace("Property", "");
            var propertyType = GetPropertyType(field);

            sb.AppendLine($"        // {propertyName}");
            sb.AppendLine();

            // ValueSetterGenerator
            if (!propertyType.EndsWith("IBinding") && !propertyType.EndsWith("IBinding?"))
            {
                sb.AppendLine($"        public {returnType} {propertyName}({propertyType} value)");
                sb.AppendLine($"            => control.Execute(() => control.{propertyName} = value);");
                sb.AppendLine();
                totalExtensions++;
            }

            // BindFromExpressionSetterGenerator
            sb.AppendLine($"        [DynamicDependency(nameof({controlTypeName}.{propertyName}), typeof({controlTypeName}))]");
            sb.AppendLine($"        public {returnType} {propertyName}(Func<{propertyType}> func, Action<{propertyType}>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)");
            sb.AppendLine($"            => control.Bind({controlTypeName}.{field.Name}!, func, onChanged, expression);");
            sb.AppendLine();

            // BindFromExpressionAsyncSetterGenerator
            sb.AppendLine($"        [DynamicDependency(nameof({controlTypeName}.{propertyName}), typeof({controlTypeName}))]");
            sb.AppendLine($"        public {returnType} {propertyName}(Func<ValueTask<{propertyType}>> getter, Func<{propertyType}>? fallbackGetter = null, Action<{propertyType}>? onChanged = null, [CallerArgumentExpression(nameof(getter))] string? expression = null)");
            sb.AppendLine($"            => control.Bind({controlTypeName}.{field.Name}!, getter, fallbackGetter, onChanged, expression);");
            sb.AppendLine();

            // BindSetterGenerator
            sb.AppendLine($"        [DynamicDependency(nameof({controlTypeName}.{propertyName}), typeof({controlTypeName}))]");
            sb.AppendLine($"        public {returnType} {propertyName}(IBinding binding)");
            sb.AppendLine($"            => control.BindR({controlTypeName}.{field.Name}, binding);");
            sb.AppendLine();

            sb.AppendLine($"        [DynamicDependency(nameof({controlTypeName}.{propertyName}), typeof({controlTypeName}))]");
            sb.AppendLine($"        public {returnType} {propertyName}(AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)");
            sb.AppendLine($"            => control.Bind({controlTypeName}.{field.Name}, avaloniaProperty, bindingMode, converter, overrideView);");
            sb.AppendLine();
            
            totalExtensions += 4;

            // Generate additional overloads for convenience
            if (propertyType.EndsWith("Thickness"))
            {
                sb.AppendLine($"        public {returnType} {propertyName}(double value)");
                sb.AppendLine($"            => control.Execute(() => control.{propertyName} = new Avalonia.Thickness(value));");
                sb.AppendLine();
                sb.AppendLine($"        public {returnType} {propertyName}(double left = 0, double top = 0, double right = 0, double bottom = 0)");
                sb.AppendLine($"            => control.Execute(() => control.{propertyName} = new Avalonia.Thickness(left, top, right, bottom));");
                sb.AppendLine();
                totalExtensions += 2;
            }
            else if (propertyType.EndsWith("CornerRadius"))
            {
                sb.AppendLine($"        public {returnType} {propertyName}(double value)");
                sb.AppendLine($"            => control.Execute(() => control.{propertyName} = new Avalonia.CornerRadius(value));");
                sb.AppendLine();
                sb.AppendLine($"        public {returnType} {propertyName}(double left = 0, double top = 0, double right = 0, double bottom = 0)");
                sb.AppendLine($"            => control.Execute(() => control.{propertyName} = new Avalonia.CornerRadius(left, top, right, bottom));");
                sb.AppendLine();
                totalExtensions += 2;
            }
        }

        sb.AppendLine("    }");

        return sb.ToString();
    }

    private static string GenerateAttachedPropertyExtensions(Compilation compilation, INamedTypeSymbol controlType, ref int totalExtensions)
    {
        var sb = new StringBuilder();

        var attachedProperties = controlType.GetMembers()
            .OfType<IFieldSymbol>()
            .Where(f => IsAttachedPropertyField(f) && !IsReadOnlyAttachedField(f))
            .ToArray();

        if (attachedProperties.Length == 0) 
            return string.Empty;

        sb.AppendLine();

        foreach (var field in attachedProperties)
        {
            var propertyName = field.Name.Replace("Property", "");
            var propertyType = GetPropertyType(field);
            var containingTypeName = GetFullTypeName(controlType);

            // TODO: Get the target type from the attached property registration.
            // Cannot seem to grab it from source generator.
            var targetTypeName = "global::Avalonia.AvaloniaObject";
            
            sb.AppendLine($"    // {controlType.Name}.{propertyName}");
            sb.AppendLine($"    extension<TControl>(TControl control)");
            sb.AppendLine($"        where TControl : {targetTypeName}");
            sb.AppendLine("    {");

            // Value setter using static Set method
            if (!propertyType.EndsWith("IBinding") && !propertyType.EndsWith("IBinding?"))
            {
                sb.AppendLine($"        public TControl {controlType.Name}_{propertyName}({propertyType} value)");
                sb.AppendLine($"            => control.Execute(() => control.SetValue({containingTypeName}.{propertyName}Property, value));");
                sb.AppendLine();
                totalExtensions++;
            }

            // Binding setter
            sb.AppendLine($"        public TControl {controlType.Name}_{propertyName}(IBinding binding)");
            sb.AppendLine($"            => control.BindR({containingTypeName}.{field.Name}, binding);");
            sb.AppendLine();

            totalExtensions++;
            sb.AppendLine("    }");
            sb.AppendLine();
        }

        return sb.ToString();
    }

    private static string GenerateEventExtensions(INamedTypeSymbol controlType, ref int totalExtensions)
    {
        var sb = new StringBuilder();
        var controlTypeName = GetFullTypeName(controlType);
        var isGeneric = !controlType.IsSealed;

        var events = controlType.GetMembers()
            .OfType<IEventSymbol>()
            .Where(e => 
                SymbolEqualityComparer.Default.Equals(e.ContainingType, controlType) &&
                e.DeclaredAccessibility == Accessibility.Public &&
                !e.GetAttributes().Any(a => a.AttributeClass?.Name == "ObsoleteAttribute"))
            .ToArray();
        
        if (events.Length == 0)
            return string.Empty;
        
        string returnType = isGeneric ? "TControl" : controlTypeName;
        if (isGeneric)
        {
            sb.AppendLine($"    extension<{returnType}>(TControl control)");
            sb.AppendLine($"        where {returnType} : {controlTypeName}");
        }
        else
        {
            sb.AppendLine($"    extension({controlTypeName} control)");
        }

        sb.AppendLine("    {");

        foreach (var evt in events)
        {
            var eventName = evt.Name;
            // The full type of the delegate (e.g., EventHandler<Thickness>)
            var delegateTypeString = evt.Type.ToDisplayString(MarkupTypeHelpers.FullSymbols);
            
            // Determine parameters based on the delegate's Invoke method
            string parameterList;
            string lambdaParameters;
            string lambdaBody;

            if (evt.Type is INamedTypeSymbol { DelegateInvokeMethod: not null } delegateSymbol)
            {
                var parameters = delegateSymbol.DelegateInvokeMethod.Parameters;

                if (parameters.Length == 2) 
                {
                    // Standard EventHandler or EventHandler<T>
                    // parameters[0] is sender, parameters[1] is TEventArgs
                    var argType = parameters[1].Type.ToDisplayString(MarkupTypeHelpers.FullSymbols);
                    parameterList = $"Action<{argType}> action";
                    lambdaParameters = "_, args";
                    lambdaBody = "action(args)";
                }
                else if (parameters.Length == 1)
                {
                    // Action<T>
                    var argType = parameters[0].Type.ToDisplayString(MarkupTypeHelpers.FullSymbols);
                    parameterList = $"Action<{argType}> action";
                    lambdaParameters = "args";
                    lambdaBody = "action(args)";
                }
                else
                {
                    // Parameterless Action or EventHandler
                    parameterList = "Action action";
                    lambdaParameters = parameters.Length == 0 ? "" : "(_, __)";
                    lambdaBody = "action()";
                }
            }
            else
            {
                // Fallback
                parameterList = "Action action";
                lambdaParameters = "";
                lambdaBody = "action()";
            }

            if (evt.AddMethod?.DeclaredAccessibility == Accessibility.Public)
            {
                sb.AppendLine($"        // {eventName}");
                sb.AppendLine($"        public {returnType} On{eventName}({parameterList}) =>");
                sb.AppendLine($"            control._setEvent(({delegateTypeString})(({lambdaParameters}) => {lambdaBody}), h => control.{eventName} += h);");
                sb.AppendLine();
            }

            totalExtensions++;
        }
        
        sb.AppendLine("    }");

        return sb.ToString();
    }

    private static string GenerateStyleExtensions(INamedTypeSymbol controlType, ref int totalExtensions)
    {
        var sb = new StringBuilder();
        var controlTypeName = GetFullTypeName(controlType);
        var isGeneric = !controlType.IsSealed;

        var styledProperties = controlType.GetMembers()
            .OfType<IFieldSymbol>()
            .Where(f => 
                IsStyledPropertyField(f) && 
                !IsReadOnlyField(f) && 
                SymbolEqualityComparer.Default.Equals(f.ContainingType, controlType))
            .ToArray();

        if (styledProperties.Length == 0)
            return string.Empty;

        string returnType = isGeneric ? "TControl" : controlTypeName;
        if (isGeneric)
        {
            sb.AppendLine($"    extension<{returnType}>(Style<{returnType}> style)");
            sb.AppendLine($"        where {returnType} : {controlTypeName}");
        }
        else
        {
            sb.AppendLine($"    extension(Style<{controlTypeName}> style)");
        }

        sb.AppendLine("    {");


        foreach (var field in styledProperties)
        {
            var propertyName = field.Name.Replace("Property", "");
            var propertyType = GetPropertyType(field);

            sb.AppendLine($"        // {propertyName}");
            sb.AppendLine();
            
            // ValueStyleSetterGenerator
            if (!propertyType.EndsWith("IBinding") && !propertyType.EndsWith("IBinding?"))
            {
                sb.AppendLine($"        public Style<{returnType}> {propertyName}({propertyType} value)");
                sb.AppendLine($"            => style.Setter({controlTypeName}.{propertyName}Property!, value!);");
                sb.AppendLine();
                totalExtensions++;
            }

            // BindingStyleSetterGenerator
            sb.AppendLine($"        public Style<{returnType}> {propertyName}(IBinding binding)");
            sb.AppendLine($"            => style.Setter({controlTypeName}.{propertyName}Property!, binding);");
            sb.AppendLine();

            // ValueOverloadsStyleSetterGenerator
            sb.AppendLine($"        public Style<{returnType}> {propertyName}(Func<{propertyType}> getter)");
            sb.AppendLine($"            => style.Setter({controlTypeName}.{propertyName}Property!, getter());");
            sb.AppendLine();

            totalExtensions += 2;

            if (propertyType.EndsWith("Thickness"))
            {
                sb.AppendLine($"        public Style<{returnType}> {propertyName}(double uniform)");
                sb.AppendLine($"            => style.Setter({controlTypeName}.{propertyName}Property!, new Avalonia.Thickness(uniform));");
                sb.AppendLine();
                sb.AppendLine($"        public Style<{returnType}> {propertyName}(double left = 0, double top = 0, double right = 0, double bottom = 0)");
                sb.AppendLine($"            => style.Setter({controlTypeName}.{propertyName}Property!, new Avalonia.Thickness(left, top, right, bottom));");
                sb.AppendLine();

                totalExtensions += 2;
            }
            else if (propertyType.EndsWith("CornerRadius"))
            {
                sb.AppendLine($"        public Style<{returnType}> {propertyName}(double uniform)");
                sb.AppendLine($"            => style.Setter({controlTypeName}.{propertyName}Property!, new Avalonia.CornerRadius(uniform));");
                sb.AppendLine();
                sb.AppendLine($"        public Style<{returnType}> {propertyName}(double left = 0, double top = 0, double right = 0, double bottom = 0)");
                sb.AppendLine($"            => style.Setter({controlTypeName}.{propertyName}Property!, new Avalonia.CornerRadius(left, top, right, bottom));");
                sb.AppendLine();
                
                totalExtensions += 2;
            }
        }
        
        sb.AppendLine("    }");

        return sb.ToString();
    }

    private static bool IsAvaloniaPropertyField(IFieldSymbol field)
    {
        if (field.GetAttributes().Any(a => a.AttributeClass?.Name == "ObsoleteAttribute"))
            return false;

        var typeName = field.Type.Name;
        return typeName.StartsWith("DirectProperty") ||
               typeName.StartsWith("StyledProperty") ||
               typeName.StartsWith("AttachedProperty") ||
               typeName.StartsWith("AvaloniaProperty");
    }

    private static bool IsAttachedPropertyField(IFieldSymbol field)
    {
        if (field.GetAttributes().Any(a => a.AttributeClass?.Name == "ObsoleteAttribute"))
            return false;

        return field.Type.Name.StartsWith("AttachedProperty");
    }

    private static bool IsStyledPropertyField(IFieldSymbol field)
    {
        if (field.GetAttributes().Any(a => a.AttributeClass?.Name == "ObsoleteAttribute"))
            return false;

        var typeName = field.Type.Name;
        return typeName.StartsWith("StyledProperty") || typeName.StartsWith("AttachedProperty");
    }

    private static bool IsReadOnlyField(IFieldSymbol field)
    {
        var propertyName = field.Name.Replace("Property", "");
        var property = field.ContainingType.GetMembers(propertyName).OfType<IPropertySymbol>().FirstOrDefault();
        
        return property == null || (property.SetMethod?.DeclaredAccessibility != Accessibility.Public) || (property.GetMethod?.DeclaredAccessibility != Accessibility.Public);
    }

    private static bool IsReadOnlyAttachedField(IFieldSymbol field)
    {
        var setterMethodName = "Set" + field.Name.Replace("Property", "");
        var setterMethod = field.ContainingType.GetMembers(setterMethodName)
            .OfType<IMethodSymbol>()
            .FirstOrDefault(m => m.IsStatic && m.DeclaredAccessibility == Accessibility.Public);
        
        return setterMethod == null;
    }

    private static bool IsStyledElement(INamedTypeSymbol typeSymbol, INamedTypeSymbol? styledElementSymbol)
    {
        if (styledElementSymbol == null)
            return false;
            
        var current = typeSymbol;
        while (current != null)
        {
            if (SymbolEqualityComparer.Default.Equals(current, styledElementSymbol))
                return true;
            current = current.BaseType;
        }
        return false;
    }

    private static string GetFullTypeName(INamedTypeSymbol typeSymbol)
    {
        return typeSymbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
    }

    private static string GetPropertyType(IFieldSymbol field)
    {
        if (field.Type is INamedTypeSymbol namedType && namedType.IsGenericType)
        {
            var typeArgs = namedType.TypeArguments;
            var innerType = typeArgs.LastOrDefault();
            if (innerType == null)
                return "object";

            return innerType.ToDisplayString(MarkupTypeHelpers.FullSymbols);
        }
        return "object";
    }

    private static bool ExtensionClassAlreadyExists(Compilation compilation, INamedTypeSymbol controlType)
    {
        var className = controlType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)
            .Replace(".", "_")
            .Replace("global::", "") + "_MarkupExtensions";
        
        // Check if the extension class already exists in any accessible namespace
        var extensionClassSymbol = compilation.GetTypeByMetadataName($"Avalonia.Markup.Declarative.{className}");
        if (extensionClassSymbol != null)
            return true;
            
        // Also check for partial classes that might exist in generated code
        var globalNamespace = compilation.GlobalNamespace;
        var avaloniaMarkupNamespace = globalNamespace.GetNamespaceMembers()
            .FirstOrDefault(ns => ns.ToDisplayString() == "Avalonia.Markup.Declarative");
            
        return avaloniaMarkupNamespace?.GetTypeMembers(className).Any() ?? false;
    }
    
}