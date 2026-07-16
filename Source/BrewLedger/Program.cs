using BrewLedger.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BrewLedger;

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
