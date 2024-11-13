using MediaMetricsPro.Application.DataContract.Enums;

namespace MediaMetricsPro.Application.DataContract.DataContract.Response;

public record SellerResponse
{
    public SellerResponse()
    {
    }

    public long Id { get; init; }
    public required string Name { get; init; }

    public required StatusSeller Status { get; init; }
    public required AddressResponse Address { get; init; }
}
