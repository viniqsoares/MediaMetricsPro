using System.Reflection;
using Mapster;
using MediaMetricsPro.Application.DataContract.DataContract.Response;
using MediaMetricsPro.Domain.Register;
using Microsoft.Extensions.DependencyInjection;

namespace MediaMetricsPro.Application.Mappings;
internal static class MappingConfiguration
{
    public static IServiceCollection RegisterMapster(this IServiceCollection services)
    {
        TypeAdapterConfig<Seller, SellerResponse>
            .NewConfig()
            .TwoWays();
        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());

        return services;
    }
}
