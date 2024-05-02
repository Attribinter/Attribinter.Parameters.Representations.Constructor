namespace Paraminter.Parameters.Representations.LoweringConstructorParameterRepresentationFactoryCases;

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
        var result = Target(Mock.Of<IConstructorParameterRepresentationFactory>());

        Assert.NotNull(result);
    }

    private static LoweringConstructorParameterRepresentationFactory Target(IConstructorParameterRepresentationFactory innerFactory) => new(innerFactory);
}
