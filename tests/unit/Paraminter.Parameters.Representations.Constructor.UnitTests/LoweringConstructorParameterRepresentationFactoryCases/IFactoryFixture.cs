namespace Paraminter.Parameters.Representations.LoweringConstructorParameterRepresentationFactoryCases;

using Moq;

internal interface IFactoryFixture
{
    public abstract IParameterRepresentationFactory<IConstructorParameter, IConstructorParameterRepresentation> Sut { get; }

    public abstract Mock<IConstructorParameterRepresentationFactory> InnerFactoryMock { get; }
}
