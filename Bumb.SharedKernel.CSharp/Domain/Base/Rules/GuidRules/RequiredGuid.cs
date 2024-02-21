using Bumb.SharedKernel.CSharp.Domain.Base.ErrorCode;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Domain.Base.Rules.GuidRules;

public sealed class RequiredGuid : AbstractValidator<Guid>
{
    public RequiredGuid()
    {
        RuleFor(id => id)
            .NotNull()
            .WithErrorCode(nameof(CommonErrorCodes.Required))
            .NotEqual(Guid.Empty)
            .WithErrorCode(nameof(CommonErrorCodes.Required));
    }
}