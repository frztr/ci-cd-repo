namespace WebApp.Services;

/// <summary>
/// Сервис формирования приветствий
/// </summary>
public interface IGreetingService
{
    /// <summary>
    /// Получить простое приветствие по времени суток
    /// </summary>
    /// <returns>строка приветствия</returns>
    string GetGreeting();
    
    /// <summary>
    /// Возвращает приветствие по времени суток для имени пользователя
    /// </summary>
    /// <param name="name">имя пользователя</param>
    /// <returns>приветствие по времени суток для имени пользователя</returns>
    string GetGreetingForName(string name);
}