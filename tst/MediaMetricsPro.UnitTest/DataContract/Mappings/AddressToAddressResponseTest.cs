using AutoFixture;
using FluentAssertions;
using Mapster;
using MediaMetricsPro.Application.DataContract.DataContract.Response;
using MediaMetricsPro.Domain.Register;

namespace MediaMetricsPro.UnitTest.DataContract.Mappings;
public class AddressToAddressResponseTest : BaseMappingTest
{
    [Fact]
    public void Should_Parse_Domain_To_DTO_With_Success()
    {
        var source = fixture.Create<Address>();

        var result = source.Adapt<AddressResponse>();

        result.Should().BeEquivalentTo(source);
    }

    [Fact]
    public void Should_Parse_DTO_To_Domain_With_Success()
    {
        var source = fixture.Create<AddressResponse>();

        var result = source.Adapt<Address>();

        result.Should().BeEquivalentTo(source);
    }
}
