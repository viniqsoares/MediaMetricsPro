using MediaMetricsPro.Domain.Services.Sellers;
using MediaMetricsPro.Infrastructure.Database.EF.Context;
using MediaMetricsPro.Infrastructure.Database.EF.Services.Sellers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MediaMetricsPro.Infrastructure.Database.EF.DependendyInjection;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<ApplicationContext>(opt => opt.UseNpgsql(config.GetConnectionString("DefaultConnection")));
        services.AddScoped<ISellerInformation, SellersInformationService>();
        return services;
    }
}