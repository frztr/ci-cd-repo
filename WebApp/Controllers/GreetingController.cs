using Microsoft.AspNetCore.Mvc;
using WebApp.Services;

namespace WebApp.Controllers;


[ApiController]
[Route("api/[controller]")]
public sealed class GreetingController(IGreetingService greetingService) : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new { message = greetingService.GetGreeting() });
}