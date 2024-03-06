namespace Hydrogen.Domains.Shared.Applications.Requests;

public abstract class BaseRequestHandler<TRequest> : MediatR.IRequestHandler<TRequest>
    where TRequest : MediatR.IRequest
{
    public abstract Task Handle(TRequest request, CancellationToken cancellationToken);
}

public abstract class BaseRequestHandler<TRequest, TResponse> : MediatR.IRequestHandler<TRequest, TResponse>
    where TRequest : MediatR.IRequest<TResponse>
{
    public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}
