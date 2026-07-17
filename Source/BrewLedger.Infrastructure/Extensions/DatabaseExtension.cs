using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BrewLedger.Infrastructure.Extensions;

[ExcludeFromCodeCoverage(Justification = "No custom logic has been implemented; it's purely a DI registration.")]
public static class DatabaseExtension
{
  public static IServiceCollection AddDatabaseConnection(this IServiceCollection services, string connectionString)
  {
    var serverVersion = ServerVersion.AutoDetect(connectionString);
    services.AddDbContext<ApplicationContext>(context => context
      .UseMySql(connectionString, serverVersion));

    return services;
  }
}
