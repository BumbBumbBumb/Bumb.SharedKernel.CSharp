using Bumb.SharedKernel.CSharp.Base.Domain.ValueObjectRules.Base.GuidRules;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.ValueObjectRules;

public class GuidIdRule : AbstractValidator<Guid>
{
    public GuidIdRule()
    {
        RuleFor(id => id)
            .SetValidator(new RequiredGuid());
    }
}