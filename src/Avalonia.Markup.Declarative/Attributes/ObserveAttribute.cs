using System;

namespace Avalonia.Markup.Declarative;

/// <summary>
/// Marks a property or field to be automatically subscribed to for INotifyPropertyChanged changes.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public sealed class ObserveAttribute : Attribute;