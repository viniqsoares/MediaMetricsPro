namespace MediaMetricsPro.Application.DataContract.DataContract.Response;

public record StateResponse
{
    public StateResponse()
    {
    }

    public short Id { get; init; }
    public string Name { get; init; }
    public CountryResponse Country { get; init; }
}
