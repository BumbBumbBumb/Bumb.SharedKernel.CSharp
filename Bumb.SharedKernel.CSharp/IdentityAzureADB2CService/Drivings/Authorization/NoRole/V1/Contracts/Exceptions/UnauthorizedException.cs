using Bumb.SharedKernel.CSharp.Base.Domain.Exceptions;
using Bumb.SharedKernel.CSharp.IdentityAzureADB2CService.Domain.User.ErrorCodes;

namespace Bumb.SharedKernel.CSharp.IdentityAzureADB2CService.Drivings.Authorization.NoRole.V1.Contracts.Exceptions;

public class UnauthorizedException : Exception, IExcHasErrorCode
{
    public string ErrorCode => AuthorizationErrorCodes.Unauthorized;
}