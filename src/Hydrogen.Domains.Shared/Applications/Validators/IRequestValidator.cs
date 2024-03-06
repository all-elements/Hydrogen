using Hydrogen.Domains.Shared.Common.Interfaces;

namespace Hydrogen.Domains.Shared.Applications.Validators;

public interface IRequestValidator<TRequest> where TRequest : ITrigger
{
    bool Verify(TRequest request, bool throwException = true);
}
