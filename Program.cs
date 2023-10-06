using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    Task task = new Task();
    task.Id = 1;
    task.DisplayName = "Kill all the people";
    
    return JsonSerializer.Serialize(task);
    });

app.Run();
