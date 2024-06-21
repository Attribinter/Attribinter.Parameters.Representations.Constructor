namespace Paraminter.Parameters.Representations;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IMethodParameterRepresentationFactory> innerFactoryMock = new();

        var sut = new LoweringMethodParameterRepresentationFactory(innerFactoryMock.Object);

        return new Fixture(sut, innerFactoryMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IParameterRepresentationFactory<IMethodParameter, IMethodParameterRepresentation> Sut;

        private readonly Mock<IMethodParameterRepresentationFactory> InnerFactoryMock;

        public Fixture(
            IParameterRepresentationFactory<IMethodParameter, IMethodParameterRepresentation> sut,
            Mock<IMethodParameterRepresentationFactory> innerFactoryMock)
        {
            Sut = sut;

            InnerFactoryMock = innerFactoryMock;
        }

        IParameterRepresentationFactory<IMethodParameter, IMethodParameterRepresentation> IFixture.Sut => Sut;

        Mock<IMethodParameterRepresentationFactory> IFixture.InnerFactoryMock => InnerFactoryMock;
    }
}
