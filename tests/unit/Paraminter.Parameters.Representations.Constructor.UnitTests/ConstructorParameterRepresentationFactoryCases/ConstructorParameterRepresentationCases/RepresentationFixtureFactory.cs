namespace Paraminter.Parameters.Representations.ConstructorParameterRepresentationFactoryCases.ConstructorParameterRepresentationCases;

internal static class RepresentationFixtureFactory
{
    public static IRepresentationFixture Create(string name)
    {
        IConstructorParameterRepresentationFactory factory = new ConstructorParameterRepresentationFactory();

        var sut = factory.Create(name);

        return new RepresentationFixture(sut);
    }

    private sealed class RepresentationFixture : IRepresentationFixture
    {
        private readonly IConstructorParameterRepresentation Sut;

        public RepresentationFixture(IConstructorParameterRepresentation sut)
        {
            Sut = sut;
        }

        IConstructorParameterRepresentation IRepresentationFixture.Sut => Sut;
    }
}
