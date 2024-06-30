namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles <see cref="IGetMethodParameterRepresentationByNameQuery"/>, and responds with <see cref="IMethodParameterRepresentation"/>.</summary>
public sealed class GetMethodParameterRepresentationByNameQueryHandler
    : IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation>
{
    /// <summary>Instantiates a <see cref="GetMethodParameterRepresentationByNameQueryHandler"/>, handling <see cref="IGetMethodParameterRepresentationByNameQuery"/>.</summary>
    public GetMethodParameterRepresentationByNameQueryHandler() { }

    IMethodParameterRepresentation IQueryHandler<IGetMethodParameterRepresentationByNameQuery, IMethodParameterRepresentation>.Handle(
        IGetMethodParameterRepresentationByNameQuery query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        return new MethodParameterRepresentation(query.Name);
    }

    private sealed class MethodParameterRepresentation
        : IMethodParameterRepresentation
    {
        private readonly string Name;

        public MethodParameterRepresentation(
            string name)
        {
            Name = name;
        }

        string IMethodParameterRepresentation.Name => Name;
    }
}
