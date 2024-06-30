namespace Paraminter.Parameters.Representations;

internal interface IFixture
{
    public abstract IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation> Sut { get; }
}
