using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi;

namespace BrewLedger.Extensions;

public static class ApiDocumentation
{
  public static IServiceCollection AddApiDocumentation(this IServiceCollection services)
  {
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
    services.AddSwaggerGen(options =>
    {
      options.SwaggerDoc("v1",
        new OpenApiInfo { Version = "v1", Title = "BrewLedger", Description = "Simple coffee tracking for teams." });

      var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
      options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
    });

    return services;
  }
}
