using System;

namespace Avalonia.Markup.Declarative;

/// <summary>
/// Marks a field as observable, automatically handling subscription/unsubscription
/// when the property value changes. Use this for properties that can be reassigned to different
/// INotifyPropertyChanged instances during the component's lifetime.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public sealed class Observable : Attribute;