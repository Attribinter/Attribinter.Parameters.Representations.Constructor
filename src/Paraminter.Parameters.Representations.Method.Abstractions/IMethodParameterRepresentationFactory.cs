namespace Paraminter.Parameters.Representations;

/// <summary>Handles creation of <see cref="IMethodParameterRepresentation"/>.</summary>
public interface IMethodParameterRepresentationFactory
{
    /// <summary>Creates a <see cref="IMethodParameterRepresentation"/>.</summary>
    /// <param name="name">The name of the method parameter.</param>
    /// <returns>The created <see cref="IMethodParameterRepresentation"/>.</returns>
    public abstract IMethodParameterRepresentation Create(string name);
}
