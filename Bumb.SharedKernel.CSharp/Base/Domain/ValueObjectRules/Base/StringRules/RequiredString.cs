using Bumb.SharedKernel.CSharp.Base.Domain.ErrorCodes.Base;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.ValueObjectRules.Base.StringRules;

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