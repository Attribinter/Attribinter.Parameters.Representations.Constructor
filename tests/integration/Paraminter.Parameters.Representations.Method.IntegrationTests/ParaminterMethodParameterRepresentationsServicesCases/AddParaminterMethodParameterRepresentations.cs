namespace Paraminter.Parameters.Representations.ParaminterMethodParameterRepresentationsServicesCases;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Xunit;

public sealed class AddParaminterMethodParameterRepresentations
{
    [Fact]
    public void IMethodParameterRepresentationEqualityComparerFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IMethodParameterRepresentationEqualityComparerFactory>();

    [Fact]
    public void IMethodParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IMethodParameterRepresentationFactory>();

    [Fact]
    public void IParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IParameterRepresentationFactory<IMethodParameter, IMethodParameterRepresentation>>();

    private static void Target(
        IServiceCollection services)
    {
        ParaminterMethodParameterRepresentationsServices.AddParaminterMethodParameterRepresentations(services);
    }

    [AssertionMethod]
    private static void ServiceCanBeResolved<TService>()
        where TService : notnull
    {
        HostBuilder host = new();

        host.ConfigureServices(static (services) => Target(services));

        var serviceProvider = host.Build().Services;

        var result = serviceProvider.GetRequiredService<TService>();

        Assert.NotNull(result);
    }
}
