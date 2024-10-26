using MediaMetricsPro.Domain.Register;

namespace MediaMetricsPro.Domain.Services.Sellers;
public interface ISellerInformation
{
    Task<IReadOnlyList<Seller>> GetSellersInformation(CancellationToken ct);
    Task<IReadOnlyList<Seller>> GetSellerInformation(Func<Seller, bool> filter, CancellationToken ct);
}
