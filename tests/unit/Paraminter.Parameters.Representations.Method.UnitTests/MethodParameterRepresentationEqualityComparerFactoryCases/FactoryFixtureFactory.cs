namespace Paraminter.Parameters.Representations.MethodParameterRepresentationEqualityComparerFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        MethodParameterRepresentationEqualityComparerFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture
        : IFactoryFixture
    {
        private readonly IMethodParameterRepresentationEqualityComparerFactory Sut;

        public FactoryFixture(
            IMethodParameterRepresentationEqualityComparerFactory sut)
        {
            Sut = sut;
        }

        IMethodParameterRepresentationEqualityComparerFactory IFactoryFixture.Sut => Sut;
    }
}
