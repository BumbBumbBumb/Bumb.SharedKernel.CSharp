using Bumb.SharedKernel.CSharp.Domain.Base.Rules.GuidRules;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Domain.Base.Rules;

public class IdRule : AbstractValidator<Guid>
{
    public IdRule()
    {
        RuleFor(id => id)
            .SetValidator(new RequiredGuid());
    }
}