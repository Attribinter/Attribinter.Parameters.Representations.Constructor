namespace Paraminter.Parameters.Representations;

/// <summary>Represents a query for a method parameter representation, given the name of the method parameter.</summary>
public interface IGetMethodParameterRepresentationByNameQuery
    : IQuery
{
    /// <summary>The name of the method parameter.</summary>
    public abstract string Name { get; }
}
