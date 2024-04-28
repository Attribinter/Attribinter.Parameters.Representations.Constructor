namespace Attribinter.Parameters.Representations;

using Microsoft.Extensions.DependencyInjection;

using System;

/// <summary>Allows the services provided by <i>Attribinter.Parameters.Representations.Constructor</i> to be registered with a <see cref="IServiceCollection"/>.</summary>
public static class AttribinterConstructorParameterRepresentationsServices
{
    /// <summary>Registers the services provided by <i>Attribinter.Parameters.Representations.Constructor</i> with the provided <see cref="IServiceCollection"/>.</summary>
    /// <param name="services">The <see cref="IServiceCollection"/> with which services are registered.</param>
    /// <returns>The provided <see cref="IServiceCollection"/>, so that calls can be chained.</returns>
    public static IServiceCollection AddAttribinterConstructorParameterRepresentations(this IServiceCollection services)
    {
        if (services is null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddTransient<IConstructorParameterRepresentationEqualityComparerFactory, ConstructorParameterRepresentationEqualityComparerFactory>();
        services.AddTransient<IConstructorParameterRepresentationFactory, ConstructorParameterRepresentationFactory>();

        return services;
    }
}
