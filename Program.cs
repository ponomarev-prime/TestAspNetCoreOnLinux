var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
    string html = File.ReadAllText("wwwroot/index.html");
    await context.Response.WriteAsync(html);
});

app.MapGet("wwwroot/aspnet.png", async context =>
{
    string imagePath = "wwwroot/aspnet.png";
    var imageBytes = File.ReadAllBytes(imagePath);
    await context.Response.Body.WriteAsync(imageBytes);
});

app.Run();
