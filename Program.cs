using app.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddCors(options =>
//{
//    options.AddDefaultPolicy(policy =>
//    {
//        policy.AllowAnyOrigin() // Разрешить запросы с любого источника
//              .AllowAnyMethod() // Разрешить любые методы (GET, POST и т. д.)
//              .AllowAnyHeader(); // Разрешить любые заголовки
//    });
//});
var app = builder.Build();
//app.UseCors();

//app.Run(Routing);
//async Task Routing(HttpContext context)
//{
//    var response = context.Response;
//    var request = context.Request;

//    if (request.Path == "/")
//        context.Response.Redirect("/Home");

//    string fullPath = @"./View"+ request.Path + "/index.html";

//    if (!File.Exists(fullPath))
//        fullPath = @"./View/NotFound/index.html";

//    await response.SendFileAsync(fullPath);
//}

app.MapGet("/test", async (HttpContext context) =>
{
    await Test(context);
});
async Task Test(HttpContext context)
{
    var response = context.Response;

    List<object> items = new List<object>() {
        new Transistors() {
        ID = 1,
        ComponentName = "transistor1"
    },
        new Transistors()
    {
        ID = 2,
        ComponentName = "transistor2"
    },
        new Transistors()
    {
        ID = 3,
        ComponentName = "transistor3"
        }
    };

    context.Response.ContentType = "application/json";
    await context.Response.WriteAsJsonAsync(items);
}


app.Run();


