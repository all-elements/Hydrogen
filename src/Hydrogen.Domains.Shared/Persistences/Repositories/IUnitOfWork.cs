namespace Hydrogen.Domains.Shared.Persistences.Repositories;

public interface IUnitOfWork
{
    int SaveAsync(CancellationToken cancellationToken = default);
}
