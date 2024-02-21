using Bumb.SharedKernel.CSharp.Domain.Base.ErrorCode;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Domain.Base.Rules.StringRules;

public class MinLengthString : AbstractValidator<string>
{
    public MinLengthString(int minLength)
    {
        RuleFor(c => c)
            .MinimumLength(minLength)
            .WithErrorCode(StringErrorCodes.NotReachMinLength);
    }
}