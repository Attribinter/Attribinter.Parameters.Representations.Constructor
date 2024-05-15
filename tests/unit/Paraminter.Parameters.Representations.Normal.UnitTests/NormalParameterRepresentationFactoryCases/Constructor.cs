namespace Paraminter.Parameters.Representations.NormalParameterRepresentationFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static NormalParameterRepresentationFactory Target() => new();
}
