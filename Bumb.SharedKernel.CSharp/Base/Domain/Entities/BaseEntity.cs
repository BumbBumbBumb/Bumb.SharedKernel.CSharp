using Bumb.SharedKernel.CSharp.Base.Domain.Rules.BaseEntityRules;
using Bumb.SharedKernel.CSharp.Base.Domain.Validation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateTime CreatedAt { get; init; } = DateTime.Now;
}

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