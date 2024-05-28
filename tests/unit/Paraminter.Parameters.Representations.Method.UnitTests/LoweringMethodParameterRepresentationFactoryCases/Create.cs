namespace Paraminter.Parameters.Representations.LoweringMethodParameterRepresentationFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Create
{
    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void NullParameter_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidParameter_ReturnsRepresentation()
    {
        var representation = Mock.Of<IMethodParameterRepresentation>();

        var name = "Name";

        Mock<IMethodParameter> parameterMock = new();

        parameterMock.Setup(static (parameter) => parameter.Symbol.Name).Returns(name);

        Fixture.InnerFactoryMock.Setup((factory) => factory.Create(name)).Returns(representation);

        var result = Target(parameterMock.Object);

        Assert.Same(representation, result);
    }

    private IMethodParameterRepresentation Target(
        IMethodParameter parameter)
    {
        return Fixture.Sut.Create(parameter);
    }
}
