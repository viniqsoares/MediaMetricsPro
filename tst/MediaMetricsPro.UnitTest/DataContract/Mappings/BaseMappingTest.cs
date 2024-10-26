using AutoFixture;
using MediaMetricsPro.Application.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace MediaMetricsPro.UnitTest.DataContract.Mappings;

public class BaseMappingTest
{
    protected readonly Fixture fixture;
    public BaseMappingTest()
    {
        fixture = new Fixture();
        new ServiceCollection().RegisterMapster();
    }
}