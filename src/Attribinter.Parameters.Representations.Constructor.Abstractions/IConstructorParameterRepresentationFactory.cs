namespace Attribinter.Parameters.Representations;

/// <summary>Handles creation of <see cref="IConstructorParameterRepresentation"/>.</summary>
public interface IConstructorParameterRepresentationFactory
{
    /// <summary>Creates a <see cref="IConstructorParameterRepresentation"/>.</summary>
    /// <param name="name">The name of the constructor parameter.</param>
    /// <returns>The created <see cref="IConstructorParameterRepresentation"/>.</returns>
    public abstract IConstructorParameterRepresentation Create(string name);
}
