using Bumb.SharedKernel.CSharp.Domain.Base.ErrorCode;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Domain.Base.Rules.StringRules;

public class RequiredString : AbstractValidator<string>
{
    public RequiredString()
    {
        RuleFor(s => s)
            .NotNull()
            .WithErrorCode(nameof(CommonErrorCodes.Required))
            .NotEmpty()
            .WithErrorCode(nameof(CommonErrorCodes.Required));
    }
}