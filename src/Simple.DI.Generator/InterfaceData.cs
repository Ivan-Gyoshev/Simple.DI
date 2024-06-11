﻿namespace Simple.DI.Generator;

/// <summary>
/// Contains interface meta data
/// </summary>
internal sealed record InterfaceData
{
    internal InterfaceData(string name, string containingNamespace)
    {
        Name = name;
        ContainingNamespace = containingNamespace;
    }

    /// <summary>
    /// The name of the interface
    /// </summary>
    internal string Name { get; private set; }

    /// <summary>
    /// The namespace where the interface is located at.
    /// </summary>
    internal string ContainingNamespace { get; private set; }

    internal static InterfaceData None = new InterfaceData(string.Empty, string.Empty);

    internal bool IsEmtpy => string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(ContainingNamespace);
}