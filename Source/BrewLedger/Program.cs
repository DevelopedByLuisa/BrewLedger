using Microsoft.AspNetCore.Builder;

namespace BrewLedger;

public static class Program
{
  public static void Main(string[] args)
  {
    var builder = WebApplication.CreateBuilder(args);
    var app = builder.Build();

    app.MapGet("/", () => "BrewLedger is up!");

    app.Run();
  }
}
