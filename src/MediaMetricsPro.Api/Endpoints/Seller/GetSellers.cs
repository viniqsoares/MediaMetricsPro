using MediaMetricsPro.Api.Endpoints.Interfaces;

namespace MediaMetricsPro.Api.Endpoints.Seller;

public class GetSellers : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/sellers", (CancellationToken ct) =>
        {
            var sellers = new[] { "Gabriel", "Filipi", "Júlio", "Ricardo", "Murilo" };
            return Results.Ok(sellers);
        })
           .WithTags("Tags.Sellers");
    }
}
