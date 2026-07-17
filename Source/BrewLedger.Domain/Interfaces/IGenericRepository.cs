using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BrewLedger.Domain.Entities.Common;

namespace BrewLedger.Domain.Interfaces;

public interface IGenericRepository<TEntity> where TEntity : BaseEntity
{
  Task<IEnumerable<TEntity>> GetEntitiesAsync(CancellationToken cancellationToken);
  Task<TEntity> GetEntityAsync(int id, CancellationToken cancellationToken);
  Task<TEntity> CreateEntityAsync(TEntity entity, CancellationToken cancellationToken);
}
