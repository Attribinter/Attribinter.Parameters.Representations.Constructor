namespace Paraminter.Parameters.Representations.NormalParameterRepresentationEqualityComparerFactoryCases.NormalParameterRepresentationEqualityComparerCases;

using Moq;

using System.Collections.Generic;

internal static class ComparerFixtureFactory
{
    public static IComparerFixture Create()
    {
        Mock<IEqualityComparer<string>> nameComparerMock = new();

        INormalParameterRepresentationEqualityComparerFactory factory = new NormalParameterRepresentationEqualityComparerFactory();

        var sut = factory.Create(nameComparerMock.Object);

        return new ComparerFixture(sut, nameComparerMock);
    }

    private sealed class ComparerFixture : IComparerFixture
    {
        private readonly IEqualityComparer<INormalParameterRepresentation> Sut;

        private readonly Mock<IEqualityComparer<string>> NameComparerMock;

        public ComparerFixture(IEqualityComparer<INormalParameterRepresentation> sut, Mock<IEqualityComparer<string>> nameComparerMock)
        {
            Sut = sut;
            NameComparerMock = nameComparerMock;
        }

        IEqualityComparer<INormalParameterRepresentation> IComparerFixture.Sut => Sut;

        Mock<IEqualityComparer<string>> IComparerFixture.NameComparerMock => NameComparerMock;
    }
}
