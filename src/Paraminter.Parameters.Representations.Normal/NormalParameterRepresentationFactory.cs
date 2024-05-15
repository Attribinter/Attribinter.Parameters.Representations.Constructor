namespace Paraminter.Parameters.Representations;

using System;

/// <inheritdoc cref="INormalParameterRepresentationFactory"/>
public sealed class NormalParameterRepresentationFactory : INormalParameterRepresentationFactory
{
    /// <summary>Instantiates a <see cref="NormalParameterRepresentationFactory"/>, handling creation of <see cref="INormalParameterRepresentation"/>.</summary>
    public NormalParameterRepresentationFactory() { }

    INormalParameterRepresentation INormalParameterRepresentationFactory.Create(string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return new NormalParameterRepresentation(name);
    }

    private sealed class NormalParameterRepresentation : INormalParameterRepresentation
    {
        private readonly string Name;

        public NormalParameterRepresentation(string name)
        {
            Name = name;
        }

        string INormalParameterRepresentation.Name => Name;
    }
}
