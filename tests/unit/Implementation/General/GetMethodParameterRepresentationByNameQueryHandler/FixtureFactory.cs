namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        GetMethodParameterRepresentationByNameQueryHandler sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation> Sut;

        public Fixture(
            IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation> sut)
        {
            Sut = sut;
        }

        IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation> IFixture.Sut => Sut;
    }
}
