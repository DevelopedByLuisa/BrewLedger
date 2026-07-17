using System.Diagnostics.CodeAnalysis;
using BrewLedger.Extensions;
using BrewLedger.Infrastructure.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace BrewLedger;

[ExcludeFromCodeCoverage(Justification = "No custom logic has been implemented; it's purely a DI registration.")]
public static class Program
{
  public static void Main(string[] args)
  {
    var builder = WebApplication.CreateBuilder(args);
    var connectionString = builder.Configuration.GetConnectionString("MariaDB");

    if (connectionString == null)
    {
      return;
    }

    builder.Services.AddApiDocumentation();
    builder.Services.AddDatabaseConnection(connectionString);

    var app = builder.Build();
    app.MapGet("/", () => "BrewLedger is up!");
    app.UseSwagger();
    app.UseSwaggerUI();

    app.Run();
  }
}
