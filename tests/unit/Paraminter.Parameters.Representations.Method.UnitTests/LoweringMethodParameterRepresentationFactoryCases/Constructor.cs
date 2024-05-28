namespace Paraminter.Parameters.Representations.LoweringMethodParameterRepresentationFactoryCases;

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
        var result = Target(Mock.Of<IMethodParameterRepresentationFactory>());

        Assert.NotNull(result);
    }

    private static LoweringMethodParameterRepresentationFactory Target(
        IMethodParameterRepresentationFactory innerFactory)
    {
        return new LoweringMethodParameterRepresentationFactory(innerFactory);
    }
}
