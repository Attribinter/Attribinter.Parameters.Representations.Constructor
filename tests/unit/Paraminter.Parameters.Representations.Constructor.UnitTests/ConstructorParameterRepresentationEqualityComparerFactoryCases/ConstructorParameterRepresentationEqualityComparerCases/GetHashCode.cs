namespace Paraminter.Parameters.Representations.ConstructorParameterRepresentationEqualityComparerFactoryCases.ConstructorParameterRepresentationEqualityComparerCases;

using Moq;

using System;

using Xunit;

public sealed class GetHashCode
{
    private int Target(IConstructorParameterRepresentation obj) => Fixture.Sut.GetHashCode(obj);

    private readonly IComparerFixture Fixture = ComparerFixtureFactory.Create();

    [Fact]
    public void Null_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void PropagatesHashCode()
    {
        var hashCode = 42;
        var name = "Name";

        Mock<IConstructorParameterRepresentation> objMock = new();

        objMock.Setup(static (representation) => representation.Name).Returns(name);

        Fixture.NameComparerMock.Setup((comparer) => comparer.GetHashCode(name)).Returns(hashCode);

        var result = Target(objMock.Object);

        Assert.Equal(hashCode, result);
    }
}
