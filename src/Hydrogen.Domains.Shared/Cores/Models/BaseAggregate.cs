namespace Hydrogen.Domains.Shared.Cores.Models;

public abstract class BaseAggregate : BaseEntity, IAggregate
{
    public Guid Key { get; }

    protected BaseAggregate() : base() => Key = Guid.NewGuid();
    protected BaseAggregate(long id, Guid key) : base(id) => Key = key;
}
