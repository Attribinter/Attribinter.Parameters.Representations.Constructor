namespace Attribinter.Parameters.Representations.ConstructorParameterRepresentationEqualityComparerFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        ConstructorParameterRepresentationEqualityComparerFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly IConstructorParameterRepresentationEqualityComparerFactory Sut;

        public FactoryFixture(IConstructorParameterRepresentationEqualityComparerFactory sut)
        {
            Sut = sut;
        }

        IConstructorParameterRepresentationEqualityComparerFactory IFactoryFixture.Sut => Sut;
    }
}
