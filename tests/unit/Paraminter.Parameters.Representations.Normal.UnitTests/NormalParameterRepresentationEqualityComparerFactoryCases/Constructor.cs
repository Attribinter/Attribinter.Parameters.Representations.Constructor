namespace Paraminter.Parameters.Representations.NormalParameterRepresentationEqualityComparerFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static NormalParameterRepresentationEqualityComparerFactory Target() => new();
}
