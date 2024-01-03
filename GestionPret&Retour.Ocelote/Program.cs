using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .AddJsonFile("Ocelote.json", optional: false, reloadOnChange: true);
builder.Services.AddControllers();
builder.Services.AddOcelot();

var app = builder.Build();
app.UseHttpsRedirection();

app.UseOcelot().Wait();
app.Run();