namespace Paraminter.Parameters.Representations.NormalParameterRepresentationFactoryCases.NormalParameterRepresentationCases;

internal static class RepresentationFixtureFactory
{
    public static IRepresentationFixture Create(string name)
    {
        INormalParameterRepresentationFactory factory = new NormalParameterRepresentationFactory();

        var sut = factory.Create(name);

        return new RepresentationFixture(sut);
    }

    private sealed class RepresentationFixture : IRepresentationFixture
    {
        private readonly INormalParameterRepresentation Sut;

        public RepresentationFixture(INormalParameterRepresentation sut)
        {
            Sut = sut;
        }

        INormalParameterRepresentation IRepresentationFixture.Sut => Sut;
    }
}
