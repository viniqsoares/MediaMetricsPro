using MediaMetricsPro.Domain.Register;

namespace MediaMetricsPro.Application.Services.Sellers;
internal class SerllerInformation : IGetSellerInformation
{
    public Task<IReadOnlyCollection<Seller>> GetAll() => throw new NotImplementedException();
}

public interface IGetSellerInformation
{
    Task<IReadOnlyCollection<Seller>> GetAll();
}