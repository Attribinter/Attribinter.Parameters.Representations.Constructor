namespace Attribinter.Parameters.Representations;

using System;

/// <inheritdoc cref="IConstructorParameterRepresentationFactory"/>
public sealed class ConstructorParameterRepresentationFactory : IConstructorParameterRepresentationFactory
{
    /// <summary>Instantiates a <see cref="ConstructorParameterRepresentationFactory"/>, handling creation of <see cref="IConstructorParameterRepresentation"/>.</summary>
    public ConstructorParameterRepresentationFactory() { }

    IConstructorParameterRepresentation IConstructorParameterRepresentationFactory.Create(string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return new ConstructorParameterRepresentation(name);
    }

    private sealed class ConstructorParameterRepresentation : IConstructorParameterRepresentation
    {
        private readonly string Name;

        public ConstructorParameterRepresentation(string name)
        {
            Name = name;
        }

        string IConstructorParameterRepresentation.Name => Name;
    }
}
