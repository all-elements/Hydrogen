namespace Hydrogen.Domains.Shared.Cores.Models;

public abstract class BaseEntity : IEntity
{
    public long Id { get; }

    protected BaseEntity() => Id = default;
    protected BaseEntity(long id) => Id = id;
}
