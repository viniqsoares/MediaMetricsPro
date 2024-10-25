using MediaMetricsPro.Domain.Register;
using MediaMetricsPro.Domain.Services.Sellers;

namespace MediaMetricsPro.Infrastructure.Database.EF.Services.Sellers;
internal class SellersInformationService : ISellerInformation
{
    public async Task<IReadOnlyList<Seller>> GetSellerInformation(Func<Seller, bool> filter, CancellationToken ct)
    {
        var result = await SellersInformationFake();
        result = (IReadOnlyList<Seller>)result.Where(filter);
        return result;
    }

    public async Task<IReadOnlyList<Seller>> GetSellersInformation(CancellationToken ct)
    {
        var result = await SellersInformationFake();
        return result;
    }

    private async Task<IReadOnlyList<Seller>> SellersInformationFake()
    {
        var country = new Country(55, "Brasil");
        var state = new State(1, "Rio de Janeiro", country);
        var address = new Address(Guid.NewGuid(), "Rodovia amaral Peixoto km90", "110", "Bananeira", "Araruama", state);
        var informations = new List<Seller>() { new Seller(0, "Filipi", address) };

        return await Task.FromResult<List<Seller>>(informations);
    }
}
