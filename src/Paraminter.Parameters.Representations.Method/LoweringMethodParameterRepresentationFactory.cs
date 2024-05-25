namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles creation of <see cref="IMethodParameterRepresentation"/> using <see cref="IMethodParameter"/>.</summary>
public sealed class LoweringMethodParameterRepresentationFactory : IParameterRepresentationFactory<IMethodParameter, IMethodParameterRepresentation>
{
    private readonly IMethodParameterRepresentationFactory InnerFactory;

    /// <summary>Instantiates a <see cref="LoweringMethodParameterRepresentationFactory"/>, handling creation of <see cref="IMethodParameterRepresentation"/> using <see cref="IMethodParameter"/>.</summary>
    /// <param name="innerFactory">Handles creation of <see cref="IMethodParameterRepresentation"/>.</param>
    public LoweringMethodParameterRepresentationFactory(IMethodParameterRepresentationFactory innerFactory)
    {
        InnerFactory = innerFactory ?? throw new ArgumentNullException(nameof(innerFactory));
    }

    IMethodParameterRepresentation IParameterRepresentationFactory<IMethodParameter, IMethodParameterRepresentation>.Create(IMethodParameter parameter)
    {
        if (parameter is null)
        {
            throw new ArgumentNullException(nameof(parameter));
        }

        return InnerFactory.Create(parameter.Symbol.Name);
    }
}
