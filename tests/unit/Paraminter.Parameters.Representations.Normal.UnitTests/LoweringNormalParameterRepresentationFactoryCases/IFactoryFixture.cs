namespace Paraminter.Parameters.Representations.LoweringNormalParameterRepresentationFactoryCases;

using Moq;

internal interface IFactoryFixture
{
    public abstract IParameterRepresentationFactory<INormalParameter, INormalParameterRepresentation> Sut { get; }

    public abstract Mock<INormalParameterRepresentationFactory> InnerFactoryMock { get; }
}
