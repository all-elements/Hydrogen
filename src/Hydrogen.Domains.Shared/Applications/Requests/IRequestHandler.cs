namespace Hydrogen.Domains.Shared.Applications.Requests;

public interface IRequestHandler<in TRequest> : MediatR.IRequestHandler<TRequest>
    where TRequest : IRequest;

public interface IRequestHandler<in TRequest, TResponse> : MediatR.IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>;
