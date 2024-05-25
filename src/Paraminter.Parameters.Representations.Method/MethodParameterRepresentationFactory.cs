namespace Paraminter.Parameters.Representations;

using System;

/// <inheritdoc cref="IMethodParameterRepresentationFactory"/>
public sealed class MethodParameterRepresentationFactory : IMethodParameterRepresentationFactory
{
    /// <summary>Instantiates a <see cref="MethodParameterRepresentationFactory"/>, handling creation of <see cref="IMethodParameterRepresentation"/>.</summary>
    public MethodParameterRepresentationFactory() { }

    IMethodParameterRepresentation IMethodParameterRepresentationFactory.Create(string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return new MethodParameterRepresentation(name);
    }

    private sealed class MethodParameterRepresentation : IMethodParameterRepresentation
    {
        private readonly string Name;

        public MethodParameterRepresentation(string name)
        {
            Name = name;
        }

        string IMethodParameterRepresentation.Name => Name;
    }
}
