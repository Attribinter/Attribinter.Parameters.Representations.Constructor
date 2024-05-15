namespace Paraminter.Parameters.Representations.ParaminterNormalParameterRepresentationsServicesCases;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Moq;

using System;

using Xunit;

public sealed class AddParaminterNormalParameterRepresentations
{
    [Fact]
    public void NullServiceCollection_ArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidServiceCollection_ReturnsSameServiceCollection()
    {
        var services = Mock.Of<IServiceCollection>();

        var result = Target(services);

        Assert.Same(services, result);
    }

    [Fact]
    public void INormalParameterRepresentationEqualityComparerFactory_ServiceCanBeResolved() => ServiceCanBeResolved<INormalParameterRepresentationEqualityComparerFactory>();

    [Fact]
    public void INormalParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<INormalParameterRepresentationFactory>();

    [Fact]
    public void IParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IParameterRepresentationFactory<INormalParameter, INormalParameterRepresentation>>();

    private static IServiceCollection Target(IServiceCollection services) => ParaminterNormalParameterRepresentationsServices.AddParaminterNormalParameterRepresentations(services);

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
