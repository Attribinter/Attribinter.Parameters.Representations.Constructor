namespace Paraminter.Parameters.Representations.LoweringConstructorParameterRepresentationFactoryCases;

using Moq;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        Mock<IConstructorParameterRepresentationFactory> innerFactoryMock = new();

        var sut = new LoweringConstructorParameterRepresentationFactory(innerFactoryMock.Object);

        return new FactoryFixture(sut, innerFactoryMock);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly IParameterRepresentationFactory<IConstructorParameter, IConstructorParameterRepresentation> Sut;

        private readonly Mock<IConstructorParameterRepresentationFactory> InnerFactoryMock;

        public FactoryFixture(IParameterRepresentationFactory<IConstructorParameter, IConstructorParameterRepresentation> sut, Mock<IConstructorParameterRepresentationFactory> innerFactoryMock)
        {
            Sut = sut;

            InnerFactoryMock = innerFactoryMock;
        }

        IParameterRepresentationFactory<IConstructorParameter, IConstructorParameterRepresentation> IFactoryFixture.Sut => Sut;

        Mock<IConstructorParameterRepresentationFactory> IFactoryFixture.InnerFactoryMock => InnerFactoryMock;
    }
}
