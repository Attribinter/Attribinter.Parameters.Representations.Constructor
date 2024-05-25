namespace Paraminter.Parameters.Representations.MethodParameterRepresentationFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static MethodParameterRepresentationFactory Target() => new();
}
