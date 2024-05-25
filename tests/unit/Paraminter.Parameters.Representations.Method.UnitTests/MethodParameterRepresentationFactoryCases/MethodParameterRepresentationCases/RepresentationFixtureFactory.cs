namespace Paraminter.Parameters.Representations.MethodParameterRepresentationFactoryCases.MethodParameterRepresentationCases;

internal static class RepresentationFixtureFactory
{
    public static IRepresentationFixture Create(string name)
    {
        IMethodParameterRepresentationFactory factory = new MethodParameterRepresentationFactory();

        var sut = factory.Create(name);

        return new RepresentationFixture(sut);
    }

    private sealed class RepresentationFixture : IRepresentationFixture
    {
        private readonly IMethodParameterRepresentation Sut;

        public RepresentationFixture(IMethodParameterRepresentation sut)
        {
            Sut = sut;
        }

        IMethodParameterRepresentation IRepresentationFixture.Sut => Sut;
    }
}
