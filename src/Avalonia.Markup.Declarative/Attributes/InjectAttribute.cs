using System;

namespace Avalonia.Markup.Declarative;

/// <summary>
/// Marks a property or field to be automatically injected using dependency injection.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public sealed class InjectAttribute : Attribute;