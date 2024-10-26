using AutoFixture;
using FluentAssertions;
using Mapster;
using MediaMetricsPro.Application.DataContract.DataContract.Response;
using MediaMetricsPro.Domain.Register;

namespace MediaMetricsPro.UnitTest.DataContract.Mappings;
public class StateToStateResponseTest : BaseMappingTest
{
    [Fact]
    public void Should_Parse_Domain_To_DTO_With_Success()
    {
        var source = fixture.Create<State>();

        var result = source.Adapt<StateResponse>();
        result.Should().BeEquivalentTo(source);
    }

    [Fact]
    public void Should_Parse_DTO_To_Domain_With_Success()
    {
        var source = fixture.Create<StateResponse>();

        var result = source.Adapt<State>();

        result.Should().BeEquivalentTo(source);
    }
}
