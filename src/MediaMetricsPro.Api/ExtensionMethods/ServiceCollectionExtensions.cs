using Asp.Versioning;
using MediaMetricsPro.Api.Endpoints.Interfaces;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;

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

    public static IServiceCollection AddVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(opt =>
        {
            /* Retorna os headers "api-supported-versions" e "api-deprecated-versions"
               indicando versoes suportadas pela API e o que esta como deprecated*/
            opt.ReportApiVersions = true;

            opt.AssumeDefaultVersionWhenUnspecified = true;
            opt.DefaultApiVersion = new ApiVersion(1);
        });
        return services;
    }
}
