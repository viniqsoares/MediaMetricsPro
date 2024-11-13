using MediaMetricsPro.Api.ExtensionMethods;
using MediaMetricsPro.Api.Extensions;
using MediaMetricsPro.Application.DependendyInjection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder
    .Services
    .AddDatabase(builder.Configuration)
    .AddEndpoints(typeof(Program).Assembly)
    .AddEndpointsApiExplorer()
    .AddSwaggerGen(config => config.SwaggerDoc("v1", new OpenApiInfo { Title = "Media Metric Api", Version = "v1" }))
    .AddApplicationDependencies(builder.Configuration)
    ;

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger()
       .UseSwaggerUI(config =>
       {
           config.SwaggerEndpoint("/swagger/v1/swagger.json", "Media Metric Pro");
           config.RoutePrefix = string.Empty;
       });
}

app.MapEndpoints();
await app.RunAsync();
