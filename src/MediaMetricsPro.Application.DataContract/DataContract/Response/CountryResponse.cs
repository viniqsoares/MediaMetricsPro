namespace MediaMetricsPro.Application.DataContract.DataContract.Response;

public record CountryResponse
{
    public CountryResponse()
    {
    }

    public short Id { get; init; }
    public required string Name { get; init; }
}