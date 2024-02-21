using Bumb.SharedKernel.CSharp.Domain.Base.ErrorCode;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Domain.Base.Rules.StringRules;

public class MaxLengthString : AbstractValidator<string>
{
    public MaxLengthString(int maxLength)
    {
        RuleFor(s => s)
            .MaximumLength(maxLength)
            .WithErrorCode(nameof(StringErrorCodes.ExceedMaxLength));
    }
}