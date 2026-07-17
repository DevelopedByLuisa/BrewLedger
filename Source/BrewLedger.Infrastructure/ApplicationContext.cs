using Microsoft.EntityFrameworkCore;

namespace BrewLedger.Infrastructure;

public class ApplicationContext(DbContextOptions<ApplicationContext> contextOptions) : DbContext(contextOptions)
{

}
