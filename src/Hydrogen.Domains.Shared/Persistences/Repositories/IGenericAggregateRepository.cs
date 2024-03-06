using Hydrogen.Domains.Shared.Cores.Models;

namespace Hydrogen.Domains.Shared.Persistences.Repositories;

public interface IGenericAggregateRepository<TAggregate>
    where TAggregate : IAggregate
{
    Task<TAggregate?> FindByIdAsync(long id, CancellationToken cancellationToken = default);
    Task<TAggregate?> FindByKeyAsync(Guid key, CancellationToken cancellationToken = default);
    void Add(TAggregate entity);
    void Update(TAggregate entity);
    void Remove(TAggregate entity);
}
