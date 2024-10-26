using MediaMetricsPro.Api.ExtensionMethods;
using MediaMetricsPro.Application.DependendyInjection;

var builder = WebApplication.CreateBuilder(args);

builder
    .Services
    .AddEndpointsApiExplorer()
    .AddEndpoints(typeof(Program).Assembly)
    .AddApplicationDependencies(builder.Configuration)
    ;

var app = builder.Build();

app.MapEndpoints();
app.Run();
