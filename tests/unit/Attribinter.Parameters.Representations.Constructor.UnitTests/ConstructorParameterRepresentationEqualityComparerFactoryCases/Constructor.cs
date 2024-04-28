namespace Attribinter.Parameters.Representations.ConstructorParameterRepresentationEqualityComparerFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static ConstructorParameterRepresentationEqualityComparerFactory Target() => new();
}
