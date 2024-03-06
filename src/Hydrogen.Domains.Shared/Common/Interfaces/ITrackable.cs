namespace Hydrogen.Domains.Shared.Common.Interfaces;

public interface ITrackable
{
    Guid ReferenceKey { get; }
    DateTime Timestamp { get; }
}
