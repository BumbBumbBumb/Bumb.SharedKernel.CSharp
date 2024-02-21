using Bumb.SharedKernel.CSharp.Domain.Base.ErrorCode;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Domain.Base.Rules.StringRules;

public class ShouldNotHaveSpaceAroundString : AbstractValidator<string>
{
    public ShouldNotHaveSpaceAroundString()
    {
        RuleFor(s => s)
            .Must(s => !(s.StartsWith(' ') || s.EndsWith(' ')))
            .WithErrorCode(StringErrorCodes.ShouldNotHaveSpaceAround);
    }
}