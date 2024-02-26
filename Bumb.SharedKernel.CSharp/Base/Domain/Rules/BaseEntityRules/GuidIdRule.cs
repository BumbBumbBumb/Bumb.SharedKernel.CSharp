using Bumb.SharedKernel.CSharp.Base.Domain.Rules.Base.GuidRules;
using Bumb.SharedKernel.CSharp.Base.Domain.Validation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Rules.BaseEntityRules;

public class GuidIdRule : BaseValidator<Guid, GuidIdRule>
{
    public GuidIdRule()
    {
        RuleFor(id => id)
            .SetValidator(new RequiredGuid());
    }
}