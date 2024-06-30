namespace Paraminter.Parameters.Representations;

internal static class GetMethodParameterRepresentationByNameQueryFactory
{
    public static IGetMethodParameterRepresentationByNameQuery FromParameter(
        IMethodParameter parameter)
    {
        return new GetMethodParameterRepresentationByNameQuery(parameter.Symbol.Name);
    }

    private sealed record class GetMethodParameterRepresentationByNameQuery
        : IGetMethodParameterRepresentationByNameQuery
    {
        private readonly string Name;

        public GetMethodParameterRepresentationByNameQuery(
            string name)
        {
            Name = name;
        }

        string IGetMethodParameterRepresentationByNameQuery.Name => Name;
    }
}
