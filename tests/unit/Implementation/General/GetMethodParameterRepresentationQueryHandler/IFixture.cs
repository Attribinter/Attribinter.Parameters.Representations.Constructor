namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture
{
    public abstract IQueryHandler<IGetParameterRepresentationQuery<IMethodParameter>, IMethodParameterRepresentation> Sut { get; }

    public abstract Mock<IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation>> ByNameQueryHandlerMock { get; }
}
