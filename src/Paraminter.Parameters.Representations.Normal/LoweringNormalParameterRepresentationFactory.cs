namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles creation of <see cref="INormalParameterRepresentation"/> using <see cref="INormalParameter"/>.</summary>
public sealed class LoweringNormalParameterRepresentationFactory : IParameterRepresentationFactory<INormalParameter, INormalParameterRepresentation>
{
    private readonly INormalParameterRepresentationFactory InnerFactory;

    /// <summary>Instantiates a <see cref="LoweringNormalParameterRepresentationFactory"/>, handling creation of <see cref="INormalParameterRepresentation"/> using <see cref="INormalParameter"/>.</summary>
    /// <param name="innerFactory">Handles creation of <see cref="INormalParameterRepresentation"/> using the indices and names of type parameters.</param>
    public LoweringNormalParameterRepresentationFactory(INormalParameterRepresentationFactory innerFactory)
    {
        InnerFactory = innerFactory ?? throw new ArgumentNullException(nameof(innerFactory));
    }

    INormalParameterRepresentation IParameterRepresentationFactory<INormalParameter, INormalParameterRepresentation>.Create(INormalParameter parameter)
    {
        if (parameter is null)
        {
            throw new ArgumentNullException(nameof(parameter));
        }

        return InnerFactory.Create(parameter.Symbol.Name);
    }
}
