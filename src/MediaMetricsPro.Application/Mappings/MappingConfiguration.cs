using System.Reflection;
using Mapster;
using MediaMetricsPro.Application.DataContract.DataContract.Response;
using MediaMetricsPro.Domain.Register;
using Microsoft.Extensions.DependencyInjection;

namespace MediaMetricsPro.Application.Mappings;
public static class MappingConfiguration
{
    public static IServiceCollection RegisterMapster(this IServiceCollection services)
    {
        GlobalSeetings();

        TypeAdapterConfig<Seller, SellerResponse>
            .NewConfig()
            .Map(d => d.Address, s => s.Address);

        TypeAdapterConfig<SellerResponse, Seller>
           .NewConfig()
           .ConstructUsing(source => new Seller(source.Id, source.Name, source.Address.Adapt<Address>()));

        TypeAdapterConfig<State, StateResponse>
            .NewConfig()
            .Map(d => d.Country, s => s.Country.Adapt<CountryResponse>());

        TypeAdapterConfig<StateResponse, State>
            .NewConfig()
            .ConstructUsing(source => new State(source.Id, source.Name, source.Country.Adapt<Country>()));

        TypeAdapterConfig<Country, CountryResponse>
          .NewConfig();

        TypeAdapterConfig<CountryResponse, Country>
           .NewConfig()
           .ConstructUsing(source => new Country(source.Id, source.Name));

        return services;
    }

    private static void GlobalSeetings()
    {
        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
        TypeAdapterConfig.GlobalSettings.Default.NameMatchingStrategy(NameMatchingStrategy.Flexible);
    }
}
