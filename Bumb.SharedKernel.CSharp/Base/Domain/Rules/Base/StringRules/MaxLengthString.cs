using Bumb.SharedKernel.CSharp.Base.Domain.ErrorCodes.Base;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Rules.Base.StringRules;

public class MaxLengthString : AbstractValidator<string>
{
    public MaxLengthString(int maxLength)
    {
        RuleFor(s => s)
            .MaximumLength(maxLength)
            .WithErrorCode(nameof(StringErrorCodes.ExceedMaxLength));
    }
}