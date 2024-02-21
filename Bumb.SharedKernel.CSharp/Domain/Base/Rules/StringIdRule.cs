using Bumb.SharedKernel.CSharp.Domain.Base.Rules.StringRules;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Domain.Base.Rules;

public class StringIdRule : AbstractValidator<string>
{
    public const int MaxLength = 255;
    
    public StringIdRule()
    {
        RuleFor(s => s)
            .SetValidator(new RequiredString())
            .SetValidator(new ShouldNotHaveSpaceString())
            .SetValidator(new MaxLengthString(MaxLength));
    }
}