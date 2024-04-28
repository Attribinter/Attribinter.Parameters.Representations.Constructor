namespace Attribinter.Parameters.Representations.ConstructorParameterRepresentationFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static ConstructorParameterRepresentationFactory Target() => new();
}
