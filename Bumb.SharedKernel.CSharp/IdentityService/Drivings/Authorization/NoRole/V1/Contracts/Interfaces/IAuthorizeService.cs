using Bumb.SharedKernel.CSharp.IdentityService.Domain.User.ValueObjects;
using Bumb.SharedKernel.CSharp.IdentityService.Drivings.Authorization.NoRole.V1.Contracts.Response;

namespace Bumb.SharedKernel.CSharp.IdentityService.Drivings.Authorization.NoRole.V1.Contracts.Interfaces;

public interface IAuthorizeService
{
    public Task<AuthorInfo> AuthorizeAndThrowAsync(
        string accessToken,
        IEnumerable<Role>? allowedRoles = null,
        IEnumerable<Role>? requiredPermissions = null,
        CancellationToken cancellationToken = default);
}
