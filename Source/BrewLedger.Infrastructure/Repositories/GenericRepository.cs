using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BrewLedger.Domain.Entities.Common;
using BrewLedger.Domain.Interfaces;

namespace BrewLedger.Infrastructure.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
{
  public async Task<IEnumerable<TEntity>> GetEntitiesAsync(CancellationToken cancellationToken)
  {
    throw new System.NotImplementedException();
  }

  public async Task<TEntity> GetEntityAsync(int id, CancellationToken cancellationToken)
  {
    throw new System.NotImplementedException();
  }

  public async Task<TEntity> CreateEntityAsync(TEntity entity, CancellationToken cancellationToken)
  {
    throw new System.NotImplementedException();
  }
}
