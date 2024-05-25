namespace Paraminter.Parameters.Representations.LoweringMethodParameterRepresentationFactoryCases;

using Moq;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        Mock<IMethodParameterRepresentationFactory> innerFactoryMock = new();

        var sut = new LoweringMethodParameterRepresentationFactory(innerFactoryMock.Object);

        return new FactoryFixture(sut, innerFactoryMock);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly IParameterRepresentationFactory<IMethodParameter, IMethodParameterRepresentation> Sut;

        private readonly Mock<IMethodParameterRepresentationFactory> InnerFactoryMock;

        public FactoryFixture(IParameterRepresentationFactory<IMethodParameter, IMethodParameterRepresentation> sut, Mock<IMethodParameterRepresentationFactory> innerFactoryMock)
        {
            Sut = sut;

            InnerFactoryMock = innerFactoryMock;
        }

        IParameterRepresentationFactory<IMethodParameter, IMethodParameterRepresentation> IFactoryFixture.Sut => Sut;

        Mock<IMethodParameterRepresentationFactory> IFactoryFixture.InnerFactoryMock => InnerFactoryMock;
    }
}
