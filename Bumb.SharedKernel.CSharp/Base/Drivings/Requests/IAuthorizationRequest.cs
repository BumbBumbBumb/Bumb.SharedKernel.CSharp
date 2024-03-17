using Bumb.SharedKernel.CSharp.IdentityService.Domain.User.ValueObjects;
using Bumb.SharedKernel.CSharp.IdentityService.Drivings.Authorization.NoRole.V1.Contracts.Response;

namespace Bumb.SharedKernel.CSharp.Base.Drivings.Requests;

public interface IAuthorizationRequest
{
    public string AccessToken { get; init; }
    
    public AuthorInfo AuthorInfo { get; set; }

    public IEnumerable<Role> GetAllowedRoles();
}