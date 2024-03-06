namespace Hydrogen.Domains.Shared.Cores.ValueObjects;

public record class OptimisticLock(int Version, DateTime Timestamp);
