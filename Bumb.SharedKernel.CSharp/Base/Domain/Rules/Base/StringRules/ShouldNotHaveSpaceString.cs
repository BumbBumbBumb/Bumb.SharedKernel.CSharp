using Bumb.SharedKernel.CSharp.Base.Domain.ErrorCodes.Base;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Rules.Base.StringRules;

public class ShouldNotHaveSpaceString : AbstractValidator<string>
{
    public ShouldNotHaveSpaceString()
    {
        RuleFor(s => s)
            .Must(s => !s.Contains(' '))
            .WithErrorCode(StringErrorCodes.ShouldNotHaveSpace);
    }
}