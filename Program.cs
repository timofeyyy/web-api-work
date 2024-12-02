using app.Context;
using app.Router;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ConnectionString");

builder.Services.AddDbContext<DataBase>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();




app.MapGet("/", (HttpContext context) =>
{
    context.Response.Redirect("/api");
    //await TestSQL(context);
});

app.MapGet("/api", (async (HttpContext context) =>
{
    var response = context.Response;
    var routerInfo = new List<RouteInfo>()
    {
        //new RouteInfo("/api/component-kinds", "ComponentKinds"),
        //new RouteInfo("/api/component-types", "ComponentTypes"),
        //new RouteInfo("/api/manufactures", "Manufacturers"),
        //new RouteInfo("/api/technologies", "Technologies"),
        new RouteInfo("/api/resistors", "Resistors"),
        new RouteInfo("/api/transistors", "Transistors"),
        new RouteInfo("/api/diods", "Diods"),
        new RouteInfo("/api/microchips", "Microchips"),
        new RouteInfo("/api/capacitors", "Capacitors")
    };


    response.ContentType = "application/json";
    await response.WriteAsJsonAsync(routerInfo);
}));

//app.MapGet("/api/component-kinds", async (DataBase db, HttpContext context) =>
//{
//    var response = context.Response;
//    var items = db.ComponentKinds.ToList();

//    response.ContentType = "application/json";
//    await response.WriteAsJsonAsync(items);
//});

//app.MapGet("/api/component-types", async (DataBase db, HttpContext context) =>
//{
//    var response = context.Response;
//    var items = db.ComponentTypes.ToList();

//    response.ContentType = "application/json";
//    await response.WriteAsJsonAsync(items);
//});

//app.MapGet("/api/manufactures", async (DataBase db, HttpContext context) =>
//{
//    var response = context.Response;
//    var items = db.Manufacturers.ToList();

//    response.ContentType = "application/json";
//    await response.WriteAsJsonAsync(items);
//});

//app.MapGet("/api/technologies", async (DataBase db, HttpContext context) =>
//{
//    var response = context.Response;
//    var items = db.Technologies.ToList();

//    response.ContentType = "application/json";
//    await response.WriteAsJsonAsync(items);
//});

app.MapGet("/api/resistors", async (DataBase db, HttpContext context) =>
{
    var response = context.Response;
    var items = db.Resistors.ToList();

    response.ContentType = "application/json";
    await response.WriteAsJsonAsync(items);
});

app.MapGet("/api/transistors", async (DataBase db, HttpContext context) =>
{
    var response = context.Response;
    var items = db.Transistors.ToList();

    response.ContentType = "application/json";
    await response.WriteAsJsonAsync(items);
});

app.MapGet("/api/diods", async (DataBase db, HttpContext context) =>
{
    var response = context.Response;
    var items = db.Diods.ToList();

    response.ContentType = "application/json";
    await response.WriteAsJsonAsync(items);
});

app.MapGet("/api/microchips", async (DataBase db, HttpContext context) =>
{
    var response = context.Response;
    var items = db.Microchips.ToList();

    response.ContentType = "application/json";
    await response.WriteAsJsonAsync(items);
});

app.MapGet("/api/capacitors", async (DataBase db, HttpContext context) =>
{
    var response = context.Response;
    var items = db.Capacitors.ToList();

    response.ContentType = "application/json";
    await response.WriteAsJsonAsync(items);
});


//async Task TestSQL(HttpContext context) {

//    var response = context.Response;
//    //var items = db.ComponentKinds.ToList();
//    //var items = db.ComponentTypes.ToList();
//    //var items = db.Manufacturers.ToList();
//    //var items = db.Technologies.ToList();
//    //var items = db.Resistors.ToList();
//    //var items = db.Transistors.ToList();
//    //var items = db.Diods.ToList();
//    //var items = db.Capacitors.ToList();

//    context.Response.ContentType = "application/json";
//    await context.Response.WriteAsJsonAsync(items);

//}


app.Run();

