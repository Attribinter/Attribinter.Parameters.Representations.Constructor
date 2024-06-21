namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        MethodParameterRepresentationFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IMethodParameterRepresentationFactory Sut;

        public Fixture(
            IMethodParameterRepresentationFactory sut)
        {
            Sut = sut;
        }

        IMethodParameterRepresentationFactory IFixture.Sut => Sut;
    }
}
