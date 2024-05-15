namespace Paraminter.Parameters.Representations;

using Microsoft.Extensions.DependencyInjection;

using System;

/// <summary>Allows the services provided by <i>Paraminter.Parameters.Representations.Normal</i> to be registered with a <see cref="IServiceCollection"/>.</summary>
public static class ParaminterNormalParameterRepresentationsServices
{
    /// <summary>Registers the services provided by <i>Paraminter.Parameters.Representations.Normal</i> with the provided <see cref="IServiceCollection"/>.</summary>
    /// <param name="services">The <see cref="IServiceCollection"/> with which services are registered.</param>
    /// <returns>The provided <see cref="IServiceCollection"/>, so that calls can be chained.</returns>
    public static IServiceCollection AddParaminterNormalParameterRepresentations(this IServiceCollection services)
    {
        if (services is null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddTransient<INormalParameterRepresentationEqualityComparerFactory, NormalParameterRepresentationEqualityComparerFactory>();
        services.AddTransient<INormalParameterRepresentationFactory, NormalParameterRepresentationFactory>();

        services.AddTransient<IParameterRepresentationFactory<INormalParameter, INormalParameterRepresentation>, LoweringNormalParameterRepresentationFactory>();

        return services;
    }
}
