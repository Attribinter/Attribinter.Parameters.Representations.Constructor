namespace Paraminter.Parameters.Representations.ConstructorParameterRepresentationEqualityComparerFactoryCases.ConstructorParameterRepresentationEqualityComparerCases;

using Moq;

using System;

using Xunit;

public sealed class Equals
{
    private bool Target(IConstructorParameterRepresentation x, IConstructorParameterRepresentation y) => Fixture.Sut.Equals(x, y);

    private readonly IComparerFixture Fixture = ComparerFixtureFactory.Create();

    [Fact]
    public void NullX_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!, Mock.Of<IConstructorParameterRepresentation>()));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NullY_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(Mock.Of<IConstructorParameterRepresentation>(), null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void FalseReturningNameComparer_ReturnsFalse() => PropagatesReturnValue(false);

    [Fact]
    public void TrueReturningNameComparer_ReturnsTrue() => PropagatesReturnValue(true);

    [AssertionMethod]
    private void PropagatesReturnValue(bool returnValue)
    {
        var xName = "NameX";
        var yName = "NameY";

        Mock<IConstructorParameterRepresentation> xMock = new();
        Mock<IConstructorParameterRepresentation> yMock = new();

        xMock.Setup(static (representation) => representation.Name).Returns(xName);
        yMock.Setup(static (representation) => representation.Name).Returns(yName);

        Fixture.NameComparerMock.Setup((comparer) => comparer.Equals(xName, yName)).Returns(returnValue);

        var result = Target(xMock.Object, yMock.Object);

        Assert.Equal(returnValue, result);
    }
}
