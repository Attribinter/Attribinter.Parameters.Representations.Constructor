namespace Paraminter.Parameters.Representations;

using System.Collections.Generic;

/// <summary>Handles creation of comparers of <see cref="IConstructorParameterRepresentation"/>.</summary>
public interface IConstructorParameterRepresentationEqualityComparerFactory
{
    /// <summary>Creates a comparer of <see cref="IConstructorParameterRepresentation"/>.</summary>
    /// <param name="nameComparer">Determines equality when comparing the names of constructor parameters.</param>
    /// <returns>The created comparer of <see cref="IConstructorParameterRepresentation"/>.</returns>
    public abstract IEqualityComparer<IConstructorParameterRepresentation> Create(IEqualityComparer<string> nameComparer);
}
