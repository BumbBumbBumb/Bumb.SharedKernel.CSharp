using Bumb.SharedKernel.CSharp.Domain.Base.ErrorCode;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Domain.Base.Rules.StringRules;

public class ShouldNotHaveSpaceBetweenString : AbstractValidator<string>
{
    public ShouldNotHaveSpaceBetweenString()
    {
        RuleFor(s => s)
            .Must(s => !s.Trim().Contains(' '))
            .WithErrorCode(StringErrorCodes.ShouldNotHaveSpaceBetween);
    }
}