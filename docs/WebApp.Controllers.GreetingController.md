#### [WebApp](index.md 'index')
### [WebApp\.Controllers](WebApp.Controllers.md 'WebApp\.Controllers')

## GreetingController Class

Контроллер возвращающий приветствия пользователя, зависящие от времени суток\.

```csharp
public sealed class GreetingController : Microsoft.AspNetCore.Mvc.ControllerBase
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → GreetingController

| Constructors | |
| :--- | :--- |
| [GreetingController\(IGreetingService\)](WebApp.Controllers.GreetingController.GreetingController(WebApp.Services.IGreetingService).md 'WebApp\.Controllers\.GreetingController\.GreetingController\(WebApp\.Services\.IGreetingService\)') | Контроллер возвращающий приветствия пользователя, зависящие от времени суток\. |

| Methods | |
| :--- | :--- |
| [Get\(\)](WebApp.Controllers.GreetingController.Get().md 'WebApp\.Controllers\.GreetingController\.Get\(\)') | Отправляет приветствие, зависящее от текущего времени в формате json |
