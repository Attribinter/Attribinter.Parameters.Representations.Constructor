namespace Paraminter.Parameters.Representations;

/// <summary>Handles creation of <see cref="INormalParameterRepresentation"/>.</summary>
public interface INormalParameterRepresentationFactory
{
    /// <summary>Creates a <see cref="INormalParameterRepresentation"/>.</summary>
    /// <param name="name">The name of the normal parameter.</param>
    /// <returns>The created <see cref="INormalParameterRepresentation"/>.</returns>
    public abstract INormalParameterRepresentation Create(string name);
}
