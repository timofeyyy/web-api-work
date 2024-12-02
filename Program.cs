using app.Context;
using app.Router;

var builder = WebApplication.CreateBuilder(args);


//builder.Services.AddCors(options =>
//{
//    options.AddDefaultPolicy(policy =>
//    {
//        policy.AllowAnyOrigin() // Разрешить запросы с любого источника
//              .AllowAnyMethod() // Разрешить любые методы 
//              .AllowAnyHeader(); // Разрешить любые заголовки
//    });
//});
var app = builder.Build();
//app.UseCors();

DataBase db = new DataBase();



app.MapGet("/", (HttpContext context) =>
{
    context.Response.Redirect("/api");
    //await TestSQL(context);
});

app.MapGet("/api", (Delegate)(async (HttpContext context) =>
{
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


    context.Response.ContentType = "application/json";
    await context.Response.WriteAsJsonAsync(routerInfo);
}));

//app.MapGet("/api/component-kinds", async (HttpContext context) =>
//{
//    var response = context.Response;
//    var items = db.ComponentKinds.ToList();

//    context.Response.ContentType = "application/json";
//    await context.Response.WriteAsJsonAsync(items);
//});

//app.MapGet("/api/component-types", async (HttpContext context) =>
//{
//    var response = context.Response;
//    var items = db.ComponentTypes.ToList();

//    context.Response.ContentType = "application/json";
//    await context.Response.WriteAsJsonAsync(items);
//});

//app.MapGet("/api/manufactures", async (HttpContext context) =>
//{
//    var response = context.Response;
//    var items = db.Manufacturers.ToList();

//    context.Response.ContentType = "application/json";
//    await context.Response.WriteAsJsonAsync(items);
//});

//app.MapGet("/api/technologies", async (HttpContext context) =>
//{
//    var response = context.Response;
//    var items = db.Technologies.ToList();

//    context.Response.ContentType = "application/json";
//    await context.Response.WriteAsJsonAsync(items);
//});

app.MapGet("/api/resistors", async (HttpContext context) =>
{
    var response = context.Response;
    var items = db.Resistors.ToList();

    context.Response.ContentType = "application/json";
    await context.Response.WriteAsJsonAsync(items);
});

app.MapGet("/api/transistors", async (HttpContext context) =>
{
    var response = context.Response;
    var items = db.Transistors.ToList();

    context.Response.ContentType = "application/json";
    await context.Response.WriteAsJsonAsync(items);
});

app.MapGet("/api/diods", async (HttpContext context) =>
{
    var response = context.Response;
    var items = db.Diods.ToList();

    context.Response.ContentType = "application/json";
    await context.Response.WriteAsJsonAsync(items);
});

app.MapGet("/api/microchips", async (HttpContext context) =>
{
    var response = context.Response;
    var items = db.Microchips.ToList();

    context.Response.ContentType = "application/json";
    await context.Response.WriteAsJsonAsync(items);
});

app.MapGet("/api/capacitors", async (HttpContext context) =>
{
    var response = context.Response;
    var items = db.Capacitors.ToList();

    context.Response.ContentType = "application/json";
    await context.Response.WriteAsJsonAsync(items);
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

