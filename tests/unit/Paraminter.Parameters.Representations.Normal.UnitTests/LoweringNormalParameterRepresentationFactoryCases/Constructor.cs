namespace Paraminter.Parameters.Representations.LoweringNormalParameterRepresentationFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void NullInnerFactory_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidInnerFactory_ReturnsFactory()
    {
        var result = Target(Mock.Of<INormalParameterRepresentationFactory>());

        Assert.NotNull(result);
    }

    private static LoweringNormalParameterRepresentationFactory Target(INormalParameterRepresentationFactory innerFactory) => new(innerFactory);
}
