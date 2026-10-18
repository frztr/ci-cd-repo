namespace WebApp.Services;

public interface IGreetingService
{
    string GetGreeting();
    
    string GetGreetingForName(string name);
}