using MediaMetricsPro.Api.Endpoints.Interfaces;
using MediaMetricsPro.Application.Services.Sellers;

namespace MediaMetricsPro.Api.Endpoints.Seller;

public class GetSellers : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/sellers", async (IGetSellerInformation service, CancellationToken ct) =>
        {
            var sellers = await service.GetSellersInformation(ct);
            return Results.Ok(sellers);
        })
           .WithTags("Tags.Sellers");
    }
}
