namespace MediaMetricsPro.Application.DataContract.DataContract.Response;

public record AddressResponse
{
    public AddressResponse()
    {
    }

    public Guid Id { get; init; }
    public required string Street { get; init; }
    public required string Number { get; init; }
    public required string District { get; init; }
    public required string City { get; init; }
    public required StateResponse State { get; init; }
}
