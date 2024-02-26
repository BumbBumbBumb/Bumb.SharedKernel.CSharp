using Bumb.SharedKernel.CSharp.Base.Domain.ErrorCodes.Base;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.ValueObjectRules.Base.StringRules;

public class MinLengthString : AbstractValidator<string>
{
    public MinLengthString(int minLength)
    {
        RuleFor(c => c)
            .MinimumLength(minLength)
            .WithErrorCode(StringErrorCodes.NotReachMinLength);
    }
}