using Hydrogen.Domains.Shared.Applications.Requests;

namespace Hydrogen.Domains.Shared.Applications.Queries;

public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>;