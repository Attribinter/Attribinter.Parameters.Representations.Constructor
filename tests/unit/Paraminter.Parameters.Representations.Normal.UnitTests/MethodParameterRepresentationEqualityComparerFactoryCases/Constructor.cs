namespace Paraminter.Parameters.Representations.MethodParameterRepresentationEqualityComparerFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static MethodParameterRepresentationEqualityComparerFactory Target() => new();
}
