using Bumb.SharedKernel.CSharp.IdentityService.Domain.User.ValueObjects;
using Bumb.SharedKernel.CSharp.IdentityService.Drivings.Authorization.NoRole.V1.Contracts.Exceptions;
using Bumb.SharedKernel.CSharp.IdentityService.Drivings.Authorization.NoRole.V1.Contracts.Interfaces;
using Bumb.SharedKernel.CSharp.IdentityService.Drivings.Authorization.NoRole.V1.Contracts.Response;

namespace Bumb.SharedKernel.CSharp.IdentityService.Drivings.Authorization.NoRole.V1.Implementations.Redis;

public record AuthorizeService : IAuthorizeService
{
    public Task<AuthorInfo> AuthorizeAndThrowAsync(
        string accessToken, 
        IEnumerable<Role>? allowedRoles = null,
        IEnumerable<Role>? requiredPermissions = null,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(accessToken))
            throw new UnauthorizedException();

        return new Task<AuthorInfo>(() => new AuthorInfo
        {
            Id = "123456"
        });
    }
}