using AutoFixture;

namespace MediaMetricsPro.UnitTest.Extensions;
public static class FixtureExtension
{
    public static IEnumerable<T> CreateIEnumerableData<T>(this Fixture fixture, int count)
    {
        fixture.RepeatCount = count;
        return fixture.CreateMany<T>();
    }
}
