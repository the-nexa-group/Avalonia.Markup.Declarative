using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Avalonia.Markup.Declarative.SourceGenerator;

[Generator]
public class AvaloniaComponentGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var classDeclarations = context.SyntaxProvider
            .CreateSyntaxProvider(
                predicate: static (s, _) => s is ClassDeclarationSyntax,
                transform: static (ctx, _) => GetSemanticTarget(ctx))
            .Where(static c => c is not null);

        context.RegisterSourceOutput(classDeclarations,
            static (spc, data) => GenerateSource(spc, data));
    }

    private static (ClassDeclarationSyntax Syntax, GeneratorData Data)? GetSemanticTarget(GeneratorSyntaxContext context)
    {
        var classDecl = (ClassDeclarationSyntax)context.Node;
        var symbol = context.SemanticModel.GetDeclaredSymbol(classDecl);

        if (symbol is not INamedTypeSymbol typeSymbol || !InheritsFrom(typeSymbol, "ComponentBase"))
            return null;

        var injectables = new List<(string Name, string Type, bool IsProperty, bool HasSetter)>();
        var observables = new List<(string Name, string Type, bool IsProperty)>();
        var deepObservables = new List<(string Name, string Type, bool IsNotifier, bool IsPrimitive)>();

        var currentType = typeSymbol;
        while (currentType != null && currentType.SpecialType != SpecialType.System_Object)
        {
            var members = currentType.GetMembers()
                .Where(m => SymbolEqualityComparer.Default.Equals(m.ContainingType, typeSymbol));

            foreach (var member in members)
            {
                var hasInject = member.GetAttributes().Any(a => a.AttributeClass?.Name is "InjectAttribute" or "Inject");
                var hasObserve = member.GetAttributes().Any(a => a.AttributeClass?.Name is "ObserveAttribute" or "Observe");
                var hasDeepObserve = member.GetAttributes().Any(a => a.AttributeClass?.Name is "ObservableAttribute" or "Observable");

                if (hasInject)
                {
                    if (member is IPropertySymbol prop)
                    {
                        injectables.Add((prop.Name, prop.Type.ToDisplayString(), true, !prop.IsReadOnly));
                    }
                    else if (member is IFieldSymbol field)
                    {
                        injectables.Add((field.Name, field.Type.ToDisplayString(), false, !field.IsReadOnly));
                    }
                }

                if (hasObserve)
                {
                    if (member is IPropertySymbol prop)
                    {
                        observables.Add((prop.Name, prop.Type.ToDisplayString(), true));
                    }
                    else if (member is IFieldSymbol field)
                    {
                        observables.Add((field.Name, field.Type.ToDisplayString(), false));
                    }
                }

                if (hasDeepObserve)
                {
                    if (member is IFieldSymbol field)
                    {
                        bool isNotifier = field.Type.AllInterfaces.Any(x => x.Name == "INotifyPropertyChanged");
                        deepObservables.Add((field.Name, field.Type.ToDisplayString(), isNotifier, field.Type.IsValueType));
                        
                        if (isNotifier)
                            observables.Add((field.Name, field.Type.ToDisplayString(), false));
                    }
                }
            }
            
            currentType = currentType.BaseType;
        }

        if (injectables.Count == 0 && observables.Count == 0 && deepObservables.Count == 0)
            return null;

        return (classDecl, new GeneratorData
        {
            Symbol = typeSymbol,
            Injectables = injectables,
            Observables = observables,
            DeepObservables = deepObservables
        });
    }

    private static bool InheritsFrom(INamedTypeSymbol symbol, string baseName)
    {
        var current = symbol.BaseType;
        while (current != null)
        {
            if (current.Name == baseName) 
                return true;
            current = current.BaseType;
        }
        return false;
    }

    private static void GenerateSource(SourceProductionContext context, (ClassDeclarationSyntax Syntax, GeneratorData Data)? data)
    {
        if (data == null) 
            return;
        
        var typeSymbol = data.Value.Data.Symbol;
        var className = typeSymbol.Name;
        var injectables = data.Value.Data.Injectables;
        var observables = data.Value.Data.Observables;
        var deepObservables = data.Value.Data.DeepObservables;

        var sb = new StringBuilder();
        sb.AppendLine("// <auto-generated />");
        sb.AppendLine("#nullable enable");
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine("using System.ComponentModel;");
        sb.AppendLine("using System.Diagnostics.CodeAnalysis;");
        sb.AppendLine("using System.Threading.Tasks;");
        sb.AppendLine("using Avalonia;");
        sb.AppendLine("using Avalonia.Controls;");
        sb.AppendLine("using Avalonia.Markup.Declarative;");
        sb.AppendLine("using Avalonia.Threading;");
        sb.AppendLine();

        // Handle Namespace
        if (!typeSymbol.ContainingNamespace.IsGlobalNamespace)
        {
            sb.AppendLine($"namespace {typeSymbol.ContainingNamespace.ToDisplayString()};");
            sb.AppendLine();
        }

        // Handle Nested Classes
        var parents = new Stack<INamedTypeSymbol>();
        var parent = typeSymbol.ContainingType;
        while (parent != null)
        {
            parents.Push(parent);
            parent = parent.ContainingType;
        }

        int indentLevel = 0;

        // Open Parent Classes
        foreach (var p in parents)
        {
            sb.AppendLine($"{Indent(indentLevel)}partial class {p.Name}");
            sb.AppendLine($"{Indent(indentLevel)}{{");
            indentLevel++;
        }

        // Open The Component Class
        sb.AppendLine($"{Indent(indentLevel)}partial class {className}");
        sb.AppendLine($"{Indent(indentLevel)}{{");

        string indent = Indent(indentLevel + 1); // Generate DeepObserve properties and tracking if needed
        
        if (deepObservables.Count > 0)
        {
            sb.AppendLine($"{indent}// Generated Observable Avalonia Properties");
            sb.AppendLine();
                
            // Generate Avalonia properties for deep observable fields
            foreach (var item in deepObservables)
            {
                string propertyName = item.Name.TrimStart('_');
                propertyName = char.ToUpper(propertyName[0]) + propertyName.Substring(1);
                string avaloniaPropertyName = propertyName + "Property";
                
                sb.AppendLine($"{indent}public static readonly Avalonia.DirectProperty<{className}, {item.Type}> {avaloniaPropertyName} =");
                sb.AppendLine($"{indent}    Avalonia.AvaloniaProperty.RegisterDirect<{className}, {item.Type}>(");
                sb.AppendLine($"{indent}        nameof({propertyName}),");
                sb.AppendLine($"{indent}        o => o.{propertyName},");
                sb.AppendLine($"{indent}        (o, value) => o.{propertyName} = value);");
                sb.AppendLine();
            }
            
            sb.AppendLine($"{indent}// Generated Observable Properties");
            sb.AppendLine();
            
            foreach (var item in deepObservables)
            {
                string propertyName = item.Name.TrimStart('_');
                propertyName = char.ToUpper(propertyName[0]) + propertyName.Substring(1);
                string avaloniaPropertyName = propertyName + "Property";
                var propertyType = item.Type;
                
                sb.AppendLine($"{indent}public {propertyType} {propertyName}");
                sb.AppendLine($"{indent}{{");
                sb.AppendLine($"{indent}    get => {item.Name};");
                sb.AppendLine($"{indent}    set");
                sb.AppendLine($"{indent}    {{");

                sb.AppendLine(item.IsPrimitive
                    ? $"{indent}        if ({item.Name} == value)"
                    : $"{indent}        if (ReferenceEquals({item.Name}, value))");
                sb.AppendLine($"{indent}            return;");
                sb.AppendLine();
                
                // Unsubscribe from old value if it implements INotifyPropertyChanged
                if (item.IsNotifier)
                    sb.AppendLine($"{indent}        UntrackPropertyChanged({item.Name});");
                
                sb.AppendLine($"{indent}        SetAndRaise({avaloniaPropertyName}, ref {item.Name}, value);");
                
                // Subscribe to new value if it implements INotifyPropertyChanged
                if (item.IsNotifier)
                    sb.AppendLine($"{indent}        TrackPropertyChanged({item.Name});");
                
                // I think these are still necessary tho I'm confused why the View doesn't listen to its own Property Changed events?
                // I'm assuming there's a reason so let's stick with this for now.
                sb.AppendLine($"{indent}        StateHasChanged();");
                sb.AppendLine($"{indent}    }}");
                sb.AppendLine($"{indent}}}");
                sb.AppendLine();
            }
            
            sb.AppendLine($"{indent}// Generated Observable Async Setters and Getters");
            sb.AppendLine();

            foreach (var item in deepObservables)
            {
                string propertyName = item.Name.TrimStart('_');
                propertyName = char.ToUpper(propertyName[0]) + propertyName.Substring(1);
                
                sb.AppendLine($"{indent}public async ValueTask<{item.Type}> Get{propertyName}Async()");
                sb.AppendLine($"{indent}{{");
                sb.AppendLine($"{indent}    if (Dispatcher.UIThread.CheckAccess())");
                sb.AppendLine($"{indent}        return {propertyName};");
                sb.AppendLine($"{indent}    else");
                sb.AppendLine($"{indent}        return await Dispatcher.UIThread.InvokeAsync(() => {propertyName});");
                sb.AppendLine($"{indent}}}");
                sb.AppendLine();
                
                sb.AppendLine($"{indent}public async ValueTask Set{propertyName}Async({item.Type} value)");
                sb.AppendLine($"{indent}{{");
                sb.AppendLine($"{indent}    if (Dispatcher.UIThread.CheckAccess())");
                sb.AppendLine($"{indent}        {propertyName} = value;");
                sb.AppendLine($"{indent}    else");
                sb.AppendLine($"{indent}        await Dispatcher.UIThread.InvokeAsync(() => {propertyName} = value);");
                sb.AppendLine($"{indent}}}");
                sb.AppendLine();
            }
        }

        // Generate InjectServices method if needed
        if (injectables.Count > 0)
        {
            sb.AppendLine($"{indent}// Generated Injected Services");
            sb.AppendLine();
            
            // [DynamicDependency] attributes
            foreach (var item in injectables)
                sb.AppendLine($"{indent}[DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof({item.Type.TrimEnd('?')}))]");

            sb.AppendLine($"{indent}protected override void InjectServices()");
            sb.AppendLine($"{indent}{{");
            sb.AppendLine($"{indent}    base.InjectServices();");
            sb.AppendLine();
            sb.AppendLine($"{indent}    if (AppBuilderExtensions.ServiceProvider == null)");
            sb.AppendLine($"{indent}        throw new InvalidOperationException(\"Set AppBuilderExtensions.ServiceProvider to use Dependency Injection\");");
            sb.AppendLine();

            foreach (var item in injectables)
                sb.AppendLine($"{indent}    this.{item.Name} = ({item.Type})AppBuilderExtensions.ServiceProvider.GetService(typeof({item.Type.TrimEnd('?')}));");

            sb.AppendLine($"{indent}}}");
            sb.AppendLine();
        }
        

        if (observables.Count > 0) 
        {
            sb.AppendLine($"{indent}// Generated Notifier Subscriptions");
            sb.AppendLine();
            
            sb.AppendLine($"{indent}protected override void SubscribeToNotifyPropertyChangedMembers()");
            sb.AppendLine($"{indent}{{");
            sb.AppendLine($"{indent}    base.SubscribeToNotifyPropertyChangedMembers();");
            sb.AppendLine();

            foreach (var item in observables)
                sb.AppendLine($"{indent}    TrackPropertyChanged({item.Name});");

            sb.AppendLine($"{indent}}}");
            sb.AppendLine();

            sb.AppendLine($"{indent}protected override void UnsubscribeToNotifyPropertyChangedMembers()");
            sb.AppendLine($"{indent}{{");
            sb.AppendLine($"{indent}    base.UnsubscribeToNotifyPropertyChangedMembers();");
            sb.AppendLine();
            
            foreach (var item in observables)
                sb.AppendLine($"{indent}    UntrackPropertyChanged({item.Name});");

            sb.AppendLine($"{indent}}}");
        }

        sb.AppendLine($"{Indent(indentLevel)}}}"); // Close Component Class

        // Close Parent Classes
        while (parents.Count > 0)
        {
            parents.Pop();
            indentLevel--;
            sb.AppendLine($"{Indent(indentLevel)}}}");
        }

        // Use a unique filename for nested types: "Outer_Inner.Component.g.cs"
        var uniqueName = typeSymbol.ToDisplayString().Replace(".", "_").Replace("<", "").Replace(">", "");
        context.AddSource($"{uniqueName}.Component.g.cs", SourceText.From(sb.ToString(), Encoding.UTF8));
    }

    private static string Indent(int level) => new string(' ', level * 4);

    private class GeneratorData
    {
        public INamedTypeSymbol Symbol { get; set; } = null!;
        public List<(string Name, string Type, bool IsProperty, bool HasSetter)> Injectables { get; set; } = new();
        public List<(string Name, string Type, bool IsProperty)> Observables { get; set; } = new();
        public List<(string Name, string Type, bool IsNotifier, bool IsPrimitive)> DeepObservables { get; set; } = new();
    }
}