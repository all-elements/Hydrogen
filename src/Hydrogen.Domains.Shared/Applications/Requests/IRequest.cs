using Hydrogen.Domains.Shared.Common.Interfaces;

namespace Hydrogen.Domains.Shared.Applications.Requests;

public interface IRequest : ITrigger, MediatR.IRequest;
public interface IRequest<TResponse> : ITrigger, MediatR.IRequest<TResponse>;