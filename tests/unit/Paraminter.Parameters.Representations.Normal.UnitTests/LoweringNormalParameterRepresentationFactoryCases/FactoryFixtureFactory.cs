namespace Paraminter.Parameters.Representations.LoweringNormalParameterRepresentationFactoryCases;

using Moq;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        Mock<INormalParameterRepresentationFactory> innerFactoryMock = new();

        var sut = new LoweringNormalParameterRepresentationFactory(innerFactoryMock.Object);

        return new FactoryFixture(sut, innerFactoryMock);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly IParameterRepresentationFactory<INormalParameter, INormalParameterRepresentation> Sut;

        private readonly Mock<INormalParameterRepresentationFactory> InnerFactoryMock;

        public FactoryFixture(IParameterRepresentationFactory<INormalParameter, INormalParameterRepresentation> sut, Mock<INormalParameterRepresentationFactory> innerFactoryMock)
        {
            Sut = sut;

            InnerFactoryMock = innerFactoryMock;
        }

        IParameterRepresentationFactory<INormalParameter, INormalParameterRepresentation> IFactoryFixture.Sut => Sut;

        Mock<INormalParameterRepresentationFactory> IFactoryFixture.InnerFactoryMock => InnerFactoryMock;
    }
}
