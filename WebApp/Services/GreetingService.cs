namespace WebApp.Services;

public sealed class GreetingService(TimeProvider timeProvider) : IGreetingService
{
    public string GetGreeting()
    {
        var hour = timeProvider.GetLocalNow().Hour;
        return hour switch
        {
            >= 5 and < 12 => "Good morning",
            >= 12 and < 17 => "Good day",
            >= 17 and < 22 => "Good evening",
            _ => "Good night",
        };
    }

    public string GetGreetingForName(string name)
    {
        return $"{GetGreeting()}, {name}";
    }
}