using Bumb.SharedKernel.CSharp.Base.Domain.ErrorCodes.Base;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Rules.Base.StringRules;

public class ShouldNotHaveSpaceAroundString : AbstractValidator<string>
{
    public ShouldNotHaveSpaceAroundString()
    {
        RuleFor(s => s)
            .Must(s => !(s.StartsWith(' ') || s.EndsWith(' ')))
            .WithErrorCode(StringErrorCodes.ShouldNotHaveSpaceAround);
    }
}