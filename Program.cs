var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(Routing);
async Task Routing(HttpContext context)
{
    var response = context.Response;
    var request = context.Request;

    if (request.Path == "/")
        context.Response.Redirect("/Home");
    
    string fullPath = @"./View"+ request.Path + "/index.html";

    if (!File.Exists(fullPath))
        fullPath = @"./View/NotFound/index.html";
    
    await response.SendFileAsync(fullPath);
}

app.Run();


