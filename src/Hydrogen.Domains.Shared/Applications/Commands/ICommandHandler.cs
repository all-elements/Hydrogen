using Hydrogen.Domains.Shared.Applications.Requests;

namespace Hydrogen.Domains.Shared.Applications.Commands;

public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand>
    where TCommand : ICommand;

public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>;