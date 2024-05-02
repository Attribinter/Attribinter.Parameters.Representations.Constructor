namespace Paraminter.Parameters.Representations;

/// <summary>Represents a constructor parameter.</summary>
public interface IConstructorParameterRepresentation
{
    /// <summary>The name of the constructor parameter.</summary>
    public abstract string Name { get; }
}
