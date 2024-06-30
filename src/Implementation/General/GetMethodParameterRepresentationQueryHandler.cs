namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles <see cref="IGetParameterRepresentationQuery{TParameter}"/>, and responds with <see cref="IMethodParameterRepresentation"/>.</summary>
public sealed class GetMethodParameterRepresentationQueryHandler
    : IQueryHandler<IGetParameterRepresentationQuery<IMethodParameter>, IMethodParameterRepresentation>
{
    private readonly IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation> ByNameQueryHandler;

    /// <summary>Instantiates a <see cref="GetMethodParameterRepresentationQueryHandler"/>, handling <see cref="IGetParameterRepresentationQuery{TParameter}"/>.</summary>
    /// <param name="byNameQueryHandler">Handles <see cref="IGetMethodParameterRepresentationByNameQuery"/>, and responds with <see cref="IMethodParameterRepresentation"/>.</param>
    public GetMethodParameterRepresentationQueryHandler(
        IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation> byNameQueryHandler)
    {
        ByNameQueryHandler = byNameQueryHandler ?? throw new ArgumentNullException(nameof(byNameQueryHandler));
    }

    IMethodParameterRepresentation IQueryHandler<IGetParameterRepresentationQuery<IMethodParameter>, IMethodParameterRepresentation>.Handle(
        IGetParameterRepresentationQuery<IMethodParameter> query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        var byNameQuery = GetMethodParameterRepresentationByNameQueryFactory.FromParameter(query.Parameter);

        return ByNameQueryHandler.Handle(byNameQuery);
    }
}
