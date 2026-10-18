using Microsoft.Extensions.Time.Testing;
using WebApp.Services;

namespace WebAppTests;

public class GreetingTests
{
    [Theory]
    [InlineData(0, "Good night")]
    [InlineData(4, "Good night")]
    [InlineData(5, "Good morning")]
    [InlineData(11, "Good morning")]
    [InlineData(12, "Good day")]
    [InlineData(16, "Good day")]
    [InlineData(17, "Good evening")]
    [InlineData(21, "Good evening")]
    [InlineData(22, "Good night")]
    [InlineData(23, "Good night")]
    public void GetGreeting_ReturnsExpectedMessage(int hour, string expected)
    {
        var time = new FakeTimeProvider();
        time.SetLocalTimeZone(TimeZoneInfo.Utc);
        time.SetUtcNow(new DateTimeOffset(2026, 10, 18, hour, 0, 0, TimeSpan.Zero));
        var service = new GreetingService(time);
        Assert.Equal(expected, service.GetGreeting());
    }
    
    [Fact]
    public void GetGreetingForNameAppendsNameToGreeting()
    {
        var time = new FakeTimeProvider();
        time.SetLocalTimeZone(TimeZoneInfo.Utc);
        time.SetUtcNow(new DateTimeOffset(2026, 10, 18, 8, 0, 0, TimeSpan.Zero));
        var service = new GreetingService(time);
        Assert.Equal("Good morning, Ann", service.GetGreetingForName("Ann"));
    }
}