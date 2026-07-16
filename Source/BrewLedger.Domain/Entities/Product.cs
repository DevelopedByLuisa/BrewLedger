using BrewLedger.Domain.Entities.Common;

namespace BrewLedger.Domain.Entities;

public class Product : BaseEntity
{
  public string Name { get; set; }
  public string Description { get; set; }
  public decimal UnitPrice { get; set; }
}
