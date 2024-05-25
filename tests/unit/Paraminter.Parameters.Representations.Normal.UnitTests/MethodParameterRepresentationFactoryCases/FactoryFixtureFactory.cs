namespace Paraminter.Parameters.Representations.MethodParameterRepresentationFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        MethodParameterRepresentationFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly IMethodParameterRepresentationFactory Sut;

        public FactoryFixture(IMethodParameterRepresentationFactory sut)
        {
            Sut = sut;
        }

        IMethodParameterRepresentationFactory IFactoryFixture.Sut => Sut;
    }
}
