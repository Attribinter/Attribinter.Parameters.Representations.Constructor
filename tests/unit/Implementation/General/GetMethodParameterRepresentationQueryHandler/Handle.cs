namespace Paraminter.Parameters.Representations;

using Moq;

using System;
using System.Linq.Expressions;

using Xunit;

public sealed class Handle
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void NullQuery_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidQuery_ReturnsRepresentation()
    {
        var representation = Mock.Of<IMethodParameterRepresentation>();

        var name = "Name";

        Mock<IMethodParameter> parameterMock = new();
        Mock<IGetParameterRepresentationQuery<IMethodParameter>> queryMock = new();

        parameterMock.Setup(static (parameter) => parameter.Symbol.Name).Returns(name);

        queryMock.Setup(static (query) => query.Parameter).Returns(parameterMock.Object);

        Fixture.ByNameQueryHandlerMock.Setup((factory) => factory.Handle(It.Is(CreateByNameQueryMatcher(name)))).Returns(representation);

        var result = Target(queryMock.Object);

        Assert.Same(representation, result);
    }

    private static Expression<Func<IGetMethodParameterRepresentationByNameQuery, bool>> CreateByNameQueryMatcher(
        string name)
    {
        return (query) => query.Name == name;
    }

    private IMethodParameterRepresentation Target(
        IGetParameterRepresentationQuery<IMethodParameter> query)
    {
        return Fixture.Sut.Handle(query);
    }
}
