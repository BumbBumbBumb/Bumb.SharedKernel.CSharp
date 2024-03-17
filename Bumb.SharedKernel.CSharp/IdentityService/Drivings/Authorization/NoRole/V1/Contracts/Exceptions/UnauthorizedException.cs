using Bumb.SharedKernel.CSharp.Base.Domain.Exceptions;
using Bumb.SharedKernel.CSharp.IdentityService.Domain.User.ErrorCodes;

namespace Bumb.SharedKernel.CSharp.IdentityService.Drivings.Authorization.NoRole.V1.Contracts.Exceptions;

public class UnauthorizedException : Exception, IExcHasErrorCode
{
    public string ErrorCode => AuthorizationErrorCodes.Unauthorized;
}