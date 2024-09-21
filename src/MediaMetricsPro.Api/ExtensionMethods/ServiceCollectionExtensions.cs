using System.Reflection;
using MediaMetricsPro.Api.Endpoints.Interfaces;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace MediaMetricsPro.Api.ExtensionMethods;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEndpoints(this IServiceCollection services, Assembly assembly)
    {
        var serviceDescriptors = assembly
                .DefinedTypes
                .Where(type => type is { IsAbstract: false, IsInterface: false } &&
                type.IsAssignableTo(typeof(IEndpoint)))
                .Select(type => ServiceDescriptor.Transient(typeof(IEndpoint), type));

        services.TryAddEnumerable(serviceDescriptors);

        return services;
    }
}

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder MapEndpoints(
    this WebApplication app,
    RouteGroupBuilder? routeGroupBuilder = null)
    {
        var endpoints = app
            .Services
            .GetRequiredService<IEnumerable<IEndpoint>>();

        IEndpointRouteBuilder builder =
            routeGroupBuilder is null ? app : routeGroupBuilder;

        foreach (var endpoint in endpoints)
            endpoint.MapEndpoint(builder);

        return app;
    }
}
