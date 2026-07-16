using System;
using BrewLedger.Domain.Enumerations;

namespace BrewLedger.Domain.Entities.Common;

public abstract class BaseEntity
{
  public int Id { get; set; }
  public DateTime CreationDate { get; set; } = DateTime.Now;
  public DateTime ChangeDate { get; set; } = DateTime.Now;
  public StatusType StatusType { get; set; } = StatusType.Activated;

  public void RegisterChange()
  {
    ChangeDate = DateTime.UtcNow;
  }

  public void Activate()
  {
    RegisterChange();
    StatusType = StatusType.Activated;
  }

  public void Deactivate()
  {
    RegisterChange();
    StatusType = StatusType.Deactivated;
  }
  
  public void Delete()
  {
    RegisterChange();
    StatusType = StatusType.Deleted;
  }
}
