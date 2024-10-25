using AutoFixture;
using FluentAssertions;
using Mapster;
using MediaMetricsPro.Application.DataContract.DataContract.Response;
using MediaMetricsPro.Domain.Register;

namespace MediaMetricsPro.UnitTest.DataContract.Mappings;
public class CountryToCountryResponseTest : BaseMappingTest
{
    [Fact]
    public void Should_Parse_Domain_To_DTO_With_Success()
    {
        var source = fixture.Create<Country>();

        var result = source.Adapt<CountryResponse>();

        result.Should().BeEquivalentTo(source);
    }

    [Fact]
    public void Should_Parse_DTO_To_Domain_With_Success()
    {
        var source = fixture.Create<CountryResponse>();

        var result = source.Adapt<Country>();

        result.Should().BeEquivalentTo(source);
    }
}
