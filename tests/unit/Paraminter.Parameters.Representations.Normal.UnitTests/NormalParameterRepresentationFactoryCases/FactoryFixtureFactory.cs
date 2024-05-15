namespace Paraminter.Parameters.Representations.NormalParameterRepresentationFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        NormalParameterRepresentationFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly INormalParameterRepresentationFactory Sut;

        public FactoryFixture(INormalParameterRepresentationFactory sut)
        {
            Sut = sut;
        }

        INormalParameterRepresentationFactory IFactoryFixture.Sut => Sut;
    }
}
