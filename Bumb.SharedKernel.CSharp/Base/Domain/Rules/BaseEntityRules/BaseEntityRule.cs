using Bumb.SharedKernel.CSharp.Base.Domain.Entities;
using Bumb.SharedKernel.CSharp.Base.Domain.Validation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Rules.BaseEntityRules;

public class BaseEntityRule : BaseValidator<BaseEntity, BaseEntityRule>
{
    public BaseEntityRule()
    {
        RuleFor(e => e.Id)
            .SetValidator(GuidIdRule.Instance);

        RuleFor(e => e.CreatedAt)
            .SetValidator(CreatedAtRule.Instance);
    }
}