using Bumb.SharedKernel.CSharp.Base.Domain.ErrorCodes.Base;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.ValueObjectRules.Base.GuidRules;

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