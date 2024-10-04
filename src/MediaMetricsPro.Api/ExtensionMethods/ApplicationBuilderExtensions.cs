using MediaMetricsPro.Api.Endpoints.Interfaces;

namespace MediaMetricsPro.Api.ExtensionMethods;

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
