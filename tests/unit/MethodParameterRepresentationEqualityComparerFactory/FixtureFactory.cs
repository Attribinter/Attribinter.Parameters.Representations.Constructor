namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        MethodParameterRepresentationEqualityComparerFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IMethodParameterRepresentationEqualityComparerFactory Sut;

        public Fixture(
            IMethodParameterRepresentationEqualityComparerFactory sut)
        {
            Sut = sut;
        }

        IMethodParameterRepresentationEqualityComparerFactory IFixture.Sut => Sut;
    }
}
