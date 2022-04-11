using Ocelot.DependencyInjection;
using Ocelot.Middleware;


var builder = WebApplication.CreateBuilder(args);
//builder.ConfigureServices(s => s.AddSingleton(builder))
//    .ConfigureAppConfiguration(ic => ic.AddJsonFile("ocelot.json"));
builder.Host.ConfigureAppConfiguration(ic => ic.AddJsonFile("ocelot.json"));

//builder.Services.AddOcelot(builder.Configuration);
builder.Services.AddOcelot();

var app = builder.Build();
app.UseRouting();
app.UseOcelot();

app.MapGet("/", () => "Hello World!");

app.Run();
