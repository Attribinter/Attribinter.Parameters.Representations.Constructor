namespace Paraminter.Parameters.Representations;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation>> byNameQueryHandlerMock = new();

        var sut = new GetMethodParameterRepresentationQueryHandler(byNameQueryHandlerMock.Object);

        return new Fixture(sut, byNameQueryHandlerMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetParameterRepresentationQuery<IMethodParameter>, IMethodParameterRepresentation> Sut;

        private readonly Mock<IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation>> ByNameQueryHandlerMock;

        public Fixture(
            IQueryHandler<IGetParameterRepresentationQuery<IMethodParameter>, IMethodParameterRepresentation> sut,
            Mock<IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation>> byNameQueryHandlerMock)
        {
            Sut = sut;

            ByNameQueryHandlerMock = byNameQueryHandlerMock;
        }

        IQueryHandler<IGetParameterRepresentationQuery<IMethodParameter>, IMethodParameterRepresentation> IFixture.Sut => Sut;

        Mock<IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation>> IFixture.ByNameQueryHandlerMock => ByNameQueryHandlerMock;
    }
}
