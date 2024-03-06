using Microsoft.EntityFrameworkCore;

namespace Hydrogen.Domains.Shared.Persistences.Repositories.EF;

public class BaseUnitOfWork<TDbContext>(TDbContext context)
    where TDbContext : DbContext
{
    private readonly TDbContext context = context;

    public async Task<int> SaveAsync(CancellationToken cancellationToken = default)
        => await context.SaveChangesAsync(cancellationToken);
}
