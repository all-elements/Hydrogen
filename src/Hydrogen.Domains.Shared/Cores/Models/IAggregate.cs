namespace Hydrogen.Domains.Shared.Cores.Models;

public interface IAggregate : IEntity
{
    Guid Key { get; }
}
