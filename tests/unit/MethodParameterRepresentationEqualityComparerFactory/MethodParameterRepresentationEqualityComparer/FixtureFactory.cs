namespace Paraminter.Parameters.Representations.MethodParameterRepresentationEqualityComparer;

using Moq;

using System.Collections.Generic;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IEqualityComparer<string>> nameComparerMock = new();

        IMethodParameterRepresentationEqualityComparerFactory factory = new MethodParameterRepresentationEqualityComparerFactory();

        var sut = factory.Create(nameComparerMock.Object);

        return new Fixture(sut, nameComparerMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IEqualityComparer<IMethodParameterRepresentation> Sut;

        private readonly Mock<IEqualityComparer<string>> NameComparerMock;

        public Fixture(
            IEqualityComparer<IMethodParameterRepresentation> sut,
            Mock<IEqualityComparer<string>> nameComparerMock)
        {
            Sut = sut;

            NameComparerMock = nameComparerMock;
        }

        IEqualityComparer<IMethodParameterRepresentation> IFixture.Sut => Sut;

        Mock<IEqualityComparer<string>> IFixture.NameComparerMock => NameComparerMock;
    }
}
