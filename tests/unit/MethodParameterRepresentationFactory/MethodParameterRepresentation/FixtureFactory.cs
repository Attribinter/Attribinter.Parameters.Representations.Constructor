namespace Paraminter.Parameters.Representations.MethodParameterRepresentation;

internal static class FixtureFactory
{
    public static IFixture Create(string name)
    {
        IMethodParameterRepresentationFactory factory = new MethodParameterRepresentationFactory();

        var sut = factory.Create(name);

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IMethodParameterRepresentation Sut;

        public Fixture(
            IMethodParameterRepresentation sut)
        {
            Sut = sut;
        }

        IMethodParameterRepresentation IFixture.Sut => Sut;
    }
}
