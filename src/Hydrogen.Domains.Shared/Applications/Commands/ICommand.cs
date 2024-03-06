using Hydrogen.Domains.Shared.Applications.Requests;

namespace Hydrogen.Domains.Shared.Applications.Commands;

public interface ICommand : IRequest;
public interface ICommand<TResponse> : IRequest<TResponse>;
