using Hydrogen.Domains.Shared.Cores.Models;
using Microsoft.EntityFrameworkCore;

namespace Hydrogen.Domains.Shared.Persistences.Repositories.EF;

public abstract class BaseAggregateRepository<TDbContext, TAggregate>(TDbContext context) : IGenericAggregateRepository<TAggregate>
    where TDbContext : DbContext
    where TAggregate : class, IAggregate
{
    protected TDbContext Context { get; } = context;

    public async Task<TAggregate?> FindByIdAsync(long id, CancellationToken cancellationToken = default)
        => await Context.Set<TAggregate>().FirstOrDefaultAsync(r => r.Id == id, cancellationToken);

    public async Task<TAggregate?> FindByKeyAsync(Guid key, CancellationToken cancellationToken = default)
        => await Context.Set<TAggregate>().FirstOrDefaultAsync(r => r.Key == key, cancellationToken);

    public void Add(TAggregate entity)
        => Context.Attach(entity).State = EntityState.Added;

    public void Update(TAggregate entity)
        => Context.Attach(entity).State = EntityState.Modified;

    public void Remove(TAggregate entity)
        => Context.Remove(entity);
}
