namespace Paraminter.Parameters.Representations;

using System.Collections.Generic;

/// <summary>Handles creation of comparers of <see cref="INormalParameterRepresentation"/>.</summary>
public interface INormalParameterRepresentationEqualityComparerFactory
{
    /// <summary>Creates a comparer of <see cref="INormalParameterRepresentation"/>.</summary>
    /// <param name="nameComparer">Determines equality when comparing the names of normal parameters.</param>
    /// <returns>The created comparer of <see cref="INormalParameterRepresentation"/>.</returns>
    public abstract IEqualityComparer<INormalParameterRepresentation> Create(IEqualityComparer<string> nameComparer);
}
