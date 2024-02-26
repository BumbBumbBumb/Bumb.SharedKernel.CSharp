using Bumb.SharedKernel.CSharp.Base.Domain.ErrorCodes.Base;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.ValueObjectRules.Base.StringRules;

public class ShouldNotHaveSpaceBetweenString : AbstractValidator<string>
{
    public ShouldNotHaveSpaceBetweenString()
    {
        RuleFor(s => s)
            .Must(s => !s.Trim().Contains(' '))
            .WithErrorCode(StringErrorCodes.ShouldNotHaveSpaceBetween);
    }
}