using Bumb.SharedKernel.CSharp.IdentityService.Domain.User.ValueObjects;
using Bumb.SharedKernel.CSharp.IdentityService.Drivings.Authorization.NoRole.V1.Contracts.Response;
using MediatR;

namespace Bumb.SharedKernel.CSharp.Base.Drivings.Requests;

public abstract record AuthorizationCommandRequest<TBody, TRes> 
    : IRequest<TRes>, ICommandRequest<TBody>, IAuthorizationRequest where TBody : notnull
{
    public required TBody Body { get; init; }
    
    public required  string AccessToken { get; init; }
    
    // this will be set in AuthorizationPipeline
    public AuthorInfo AuthorInfo { get; set; } = null!;

    public abstract IEnumerable<Role> GetAllowedRoles();
}