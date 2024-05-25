namespace Paraminter.Parameters.Representations.LoweringMethodParameterRepresentationFactoryCases;

using Moq;

internal interface IFactoryFixture
{
    public abstract IParameterRepresentationFactory<IMethodParameter, IMethodParameterRepresentation> Sut { get; }

    public abstract Mock<IMethodParameterRepresentationFactory> InnerFactoryMock { get; }
}
