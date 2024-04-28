namespace Attribinter.Parameters.Representations.ConstructorParameterRepresentationFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        ConstructorParameterRepresentationFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly IConstructorParameterRepresentationFactory Sut;

        public FactoryFixture(IConstructorParameterRepresentationFactory sut)
        {
            Sut = sut;
        }

        IConstructorParameterRepresentationFactory IFactoryFixture.Sut => Sut;
    }
}
