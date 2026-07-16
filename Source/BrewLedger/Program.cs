using System.Diagnostics.CodeAnalysis;
using BrewLedger.Extensions;
using Microsoft.AspNetCore.Builder;

namespace BrewLedger;

[ExcludeFromCodeCoverage(Justification = "No custom logic has been implemented; it's purely a DI registration.")]
public static class Program
{
  public static void Main(string[] args)
  {
    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddApiDocumentation();
    
    var app = builder.Build();
    app.MapGet("/", () => "BrewLedger is up!");
    app.UseSwagger();
    app.UseSwaggerUI();

    app.Run();
  }
}
