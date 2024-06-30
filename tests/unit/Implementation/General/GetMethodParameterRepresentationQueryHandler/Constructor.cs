namespace Paraminter.Parameters.Representations;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void NullByNameQueryHandler_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidByNameQueryHandler_ReturnsFactory()
    {
        var result = Target(Mock.Of<IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation>>());

        Assert.NotNull(result);
    }

    private static GetMethodParameterRepresentationQueryHandler Target(
        IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation> byNameQueryHandler)
    {
        return new GetMethodParameterRepresentationQueryHandler(byNameQueryHandler);
    }
}
