using MediaMetricsPro.Application.Mappings;
using MediaMetricsPro.Infrastructure.Database.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MediaMetricsPro.Application.DependendyInjection;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddApplicationDependencies(this IServiceCollection services, IConfiguration config)
    {
        services.RegisterMapster();
        services.AddDbContext<ApplicationContext>(opt => opt.UseNpgsql(config.GetConnectionString("DefaultConnection")));
        return services;
    }
}
