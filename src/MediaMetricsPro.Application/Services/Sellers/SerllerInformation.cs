using Mapster;
using MediaMetricsPro.Application.DataContract.DataContract.Response;
using MediaMetricsPro.Domain.Services.Sellers;

namespace MediaMetricsPro.Application.Services.Sellers;
internal class SellerInformation(ISellerInformation sellerInformationService): IGetSellerInformation
{
    public async Task<IReadOnlyCollection<SellerResponse>> GetSellersInformation(CancellationToken ct)
    {
        var sellers = await sellerInformationService.GetSellersInformation(ct);
        var response = sellers.Adapt<IReadOnlyCollection<SellerResponse>>();
        return response;
    }
}

public interface IGetSellerInformation
{
    Task<IReadOnlyCollection<SellerResponse>> GetSellersInformation(CancellationToken ct);
}