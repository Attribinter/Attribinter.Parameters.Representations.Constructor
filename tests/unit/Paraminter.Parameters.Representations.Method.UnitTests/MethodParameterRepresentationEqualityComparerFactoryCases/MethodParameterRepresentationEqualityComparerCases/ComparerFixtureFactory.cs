namespace Paraminter.Parameters.Representations.MethodParameterRepresentationEqualityComparerFactoryCases.MethodParameterRepresentationEqualityComparerCases;

using Moq;

using System.Collections.Generic;

internal static class ComparerFixtureFactory
{
    public static IComparerFixture Create()
    {
        Mock<IEqualityComparer<string>> nameComparerMock = new();

        IMethodParameterRepresentationEqualityComparerFactory factory = new MethodParameterRepresentationEqualityComparerFactory();

        var sut = factory.Create(nameComparerMock.Object);

        return new ComparerFixture(sut, nameComparerMock);
    }

    private sealed class ComparerFixture
        : IComparerFixture
    {
        private readonly IEqualityComparer<IMethodParameterRepresentation> Sut;

        private readonly Mock<IEqualityComparer<string>> NameComparerMock;

        public ComparerFixture(
            IEqualityComparer<IMethodParameterRepresentation> sut,
            Mock<IEqualityComparer<string>> nameComparerMock)
        {
            Sut = sut;

            NameComparerMock = nameComparerMock;
        }

        IEqualityComparer<IMethodParameterRepresentation> IComparerFixture.Sut => Sut;

        Mock<IEqualityComparer<string>> IComparerFixture.NameComparerMock => NameComparerMock;
    }
}
