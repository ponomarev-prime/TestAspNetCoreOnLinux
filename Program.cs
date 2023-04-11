var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
    string html = @"<!DOCTYPE html>
        <html>
        <head>
            <title>My First ASP.NET Core Web App</title>
            <style>
                body {
                    background-color: #f5f5f5;
                    font-family: Arial, sans-serif;
                    font-size: 16px;
                }
                h1 {
                    color: #333;
                    text-align: center;
                    margin-top: 50px;
                }
                p {
                    color: #666;
                    text-align: center;
                    margin-top: 30px;
                }
            </style>
        </head>
        <body>
            <h1>Hello, world!</h1>
            <p>Welcome to my first ASP.NET Core web app!</p>
        </body>
        </html>";
        
    await context.Response.WriteAsync(html);
});

app.Run();
