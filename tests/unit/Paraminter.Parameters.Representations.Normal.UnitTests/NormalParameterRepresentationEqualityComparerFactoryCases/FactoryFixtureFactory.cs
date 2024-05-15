namespace Paraminter.Parameters.Representations.NormalParameterRepresentationEqualityComparerFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        NormalParameterRepresentationEqualityComparerFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly INormalParameterRepresentationEqualityComparerFactory Sut;

        public FactoryFixture(INormalParameterRepresentationEqualityComparerFactory sut)
        {
            Sut = sut;
        }

        INormalParameterRepresentationEqualityComparerFactory IFactoryFixture.Sut => Sut;
    }
}
