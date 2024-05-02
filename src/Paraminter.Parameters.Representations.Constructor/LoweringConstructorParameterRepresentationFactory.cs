namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles creation of <see cref="IConstructorParameterRepresentation"/> using <see cref="IConstructorParameter"/>.</summary>
public sealed class LoweringConstructorParameterRepresentationFactory : IParameterRepresentationFactory<IConstructorParameter, IConstructorParameterRepresentation>
{
    private readonly IConstructorParameterRepresentationFactory InnerFactory;

    /// <summary>Instantiates a <see cref="LoweringConstructorParameterRepresentationFactory"/>, handling creation of <see cref="IConstructorParameterRepresentation"/> using <see cref="IConstructorParameter"/>.</summary>
    /// <param name="innerFactory">Handles creation of <see cref="IConstructorParameterRepresentation"/> using the indices and names of type parameters.</param>
    public LoweringConstructorParameterRepresentationFactory(IConstructorParameterRepresentationFactory innerFactory)
    {
        InnerFactory = innerFactory ?? throw new ArgumentNullException(nameof(innerFactory));
    }

    IConstructorParameterRepresentation IParameterRepresentationFactory<IConstructorParameter, IConstructorParameterRepresentation>.Create(IConstructorParameter parameter)
    {
        if (parameter is null)
        {
            throw new ArgumentNullException(nameof(parameter));
        }

        return InnerFactory.Create(parameter.Symbol.Name);
    }
}
