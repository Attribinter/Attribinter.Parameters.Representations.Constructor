namespace Paraminter.Parameters.Representations;

/// <summary>Represents a method parameter.</summary>
public interface IMethodParameterRepresentation
{
    /// <summary>The name of the method parameter.</summary>
    public abstract string Name { get; }
}
