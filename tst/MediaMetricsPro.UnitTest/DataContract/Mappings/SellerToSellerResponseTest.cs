using AutoFixture;
using FluentAssertions;
using Mapster;
using MediaMetricsPro.Application.DataContract.DataContract.Response;
using MediaMetricsPro.Domain.Register;

namespace MediaMetricsPro.UnitTest.DataContract.Mappings;
public class SellerToSellerResponseTest : BaseMappingTest
{
    [Fact]
    public void Should_Parse_Domain_To_DTO_With_Success()
    {
        var seller = fixture.Create<Seller>();

        var result = seller.Adapt<SellerResponse>();
        result.Should().BeEquivalentTo(seller);
    }

    [Fact]
    public void Should_Parse_DTO_To_Domain_With_Success()
    {
        var source = fixture.Create<SellerResponse>();

        var result = source.Adapt<Seller>();

        result.Should().BeEquivalentTo(source);
    }
}
