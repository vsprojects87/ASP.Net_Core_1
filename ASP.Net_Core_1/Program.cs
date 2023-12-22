// returns an instance of WebApplicationBuilder class which builds app

var builder = WebApplication.CreateBuilder(args);

// returns an instance of WebApplication
var app = builder.Build();

// creating a route : HTTP method + URL
app.MapGet("/", () => "Hello World!");

app.Run();
