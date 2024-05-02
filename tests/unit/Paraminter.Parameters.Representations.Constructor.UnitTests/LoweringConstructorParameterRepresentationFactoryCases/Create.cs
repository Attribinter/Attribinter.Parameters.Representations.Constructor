namespace Paraminter.Parameters.Representations.LoweringConstructorParameterRepresentationFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Create
{
    private IConstructorParameterRepresentation Target(IConstructorParameter parameter) => Fixture.Sut.Create(parameter);

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
        var representation = Mock.Of<IConstructorParameterRepresentation>();

        var name = "Name";

        Mock<IConstructorParameter> parameterMock = new();

        parameterMock.Setup(static (parameter) => parameter.Symbol.Name).Returns(name);

        Fixture.InnerFactoryMock.Setup((factory) => factory.Create(name)).Returns(representation);

        var result = Target(parameterMock.Object);

        Assert.Same(representation, result);
    }
}
