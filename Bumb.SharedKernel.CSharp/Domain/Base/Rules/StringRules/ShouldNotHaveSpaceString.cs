using Bumb.SharedKernel.CSharp.Domain.Base.ErrorCode;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Domain.Base.Rules.StringRules;

public class ShouldNotHaveSpaceString : AbstractValidator<string>
{
    public ShouldNotHaveSpaceString()
    {
        RuleFor(s => s)
            .Must(s => !s.Contains(' '))
            .WithErrorCode(StringErrorCodes.ShouldNotHaveSpace);
    }
}