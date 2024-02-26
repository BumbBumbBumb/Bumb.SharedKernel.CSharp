using Bumb.SharedKernel.CSharp.Base.Domain.ErrorCodes.Base;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Rules.Base.StringRules;

public class MinLengthString : AbstractValidator<string>
{
    public MinLengthString(int minLength)
    {
        RuleFor(c => c)
            .MinimumLength(minLength)
            .WithErrorCode(StringErrorCodes.NotReachMinLength);
    }
}