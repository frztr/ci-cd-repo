using Microsoft.AspNetCore.Mvc;
using WebApp.Services;

namespace WebApp.Controllers;

/// <summary>
/// Контроллер приветствия пользователя
/// </summary>
/// <param name="greetingService"><see cref="GreetingService"/></param>
[ApiController]
[Route("api/[controller]")]
public sealed class GreetingController(IGreetingService greetingService) : ControllerBase
{
    /// <summary>
    /// Отправляет приветствие, зависящее от текущего времени в формате json
    /// </summary>
    /// <returns>JSON со строкой приветствия</returns>
    [HttpGet]
    public IActionResult Get() => Ok(new { message = greetingService.GetGreeting() });
}