namespace Paraminter.Parameters.Representations;

using System.Collections.Generic;

/// <summary>Handles creation of comparers of <see cref="IMethodParameterRepresentation"/>.</summary>
public interface IMethodParameterRepresentationEqualityComparerFactory
{
    /// <summary>Creates a comparer of <see cref="IMethodParameterRepresentation"/>.</summary>
    /// <param name="nameComparer">Determines equality when comparing the names of method parameters.</param>
    /// <returns>The created comparer of <see cref="IMethodParameterRepresentation"/>.</returns>
    public abstract IEqualityComparer<IMethodParameterRepresentation> Create(IEqualityComparer<string> nameComparer);
}
