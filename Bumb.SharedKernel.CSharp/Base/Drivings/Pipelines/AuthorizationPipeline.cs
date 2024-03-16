using Bumb.SharedKernel.CSharp.Base.Drivings.Requests;
using Bumb.SharedKernel.CSharp.IdentityAzureADB2CService.Domain.User.ValueObjects;
using Bumb.SharedKernel.CSharp.IdentityAzureADB2CService.Drivings.Authorization.NoRole.V1.Contracts.Interfaces;
using MediatR;

namespace Bumb.SharedKernel.CSharp.Base.Drivings.Pipelines;

public record AuthorizationPipeline<TReq, TRes>
    : IPipelineBehavior<TReq, TRes> where TReq : IBaseRequest
{
    private readonly IAuthorizeService _authorizeService;

    public AuthorizationPipeline(IAuthorizeService authorizeService)
    {
        _authorizeService = authorizeService;
    }

    public async Task<TRes> Handle(TReq request, RequestHandlerDelegate<TRes> next, CancellationToken cancellationToken)
    {
        if (request is not IAuthorizationRequest authReq) 
            return await next();

        var authorInfo = await _authorizeService.AuthorizeAndThrowAsync(
            accessToken: authReq.AccessToken,
            allowedRoles: authReq.GetAllowedRoles(),
            requiredPermissions: new List<Role>(),
            cancellationToken
        );

        authReq.AuthorInfo = authorInfo;
        
        return await next();
    }
}