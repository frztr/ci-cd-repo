using WebApp.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton(TimeProvider.System);
builder.Services.AddSingleton<IGreetingService, GreetingService>();
var app = builder.Build();
app.MapControllers();
app.Run();