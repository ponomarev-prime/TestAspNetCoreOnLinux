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
                    background-color: #1E1E1E;
                    color: #FFFFFF;
                    font-family: Arial, sans-serif;
                    font-size: 16px;
                }
                a {
                    color: #0099FF;
                    text-decoration: none;
                }
                a:hover {
                    color: #FFFFFF;
                    background-color: #2E2E2E;
                }
                .accent {
                    color: #FFA500;
                }
                .border {
                    border: 1px solid #4D4D4D;
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
