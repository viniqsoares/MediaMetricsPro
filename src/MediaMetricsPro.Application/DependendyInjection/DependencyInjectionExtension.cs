using MediaMetricsPro.Application.Mappings;
using MediaMetricsPro.Application.Services.Sellers;
using MediaMetricsPro.Infrastructure.Database.EF.DependendyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MediaMetricsPro.Application.DependendyInjection;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddApplicationDependencies(this IServiceCollection services, IConfiguration config)
    {
        services.RegisterMapster();
        services.AddScoped<IGetSellerInformation, SellerInformation>();
        services.AddInfrastructureDependencies(config);
        return services;
    }
}
