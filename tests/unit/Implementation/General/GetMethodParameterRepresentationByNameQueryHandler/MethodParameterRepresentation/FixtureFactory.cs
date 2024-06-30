namespace Paraminter.Parameters.Representations.MethodParameterRepresentation;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create(string name)
    {
        Mock<IGetMethodParameterRepresentationByNameQuery> queryMock = new();

        queryMock.Setup(static (query) => query.Name).Returns(name);

        IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation> factory = new GetMethodParameterRepresentationByNameQueryHandler();

        var sut = factory.Handle(queryMock.Object);

        return new Fixture(sut, name);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IMethodParameterRepresentation Sut;

        private readonly string Name;

        public Fixture(
            IMethodParameterRepresentation sut,
            string name)
        {
            Sut = sut;

            Name = name;
        }

        IMethodParameterRepresentation IFixture.Sut => Sut;

        string IFixture.Name => Name;
    }
}
