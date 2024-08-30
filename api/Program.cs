
using System.Text.Json;
using service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUserService, UserService>();



builder.Services.AddControllers();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
 var result =   scope.ServiceProvider.GetService<IUserService>().GetUsers();
 Console.WriteLine(JsonSerializer.Serialize(result));
}

app.MapControllers();

app.Run();
