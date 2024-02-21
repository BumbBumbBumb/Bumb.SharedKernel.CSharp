using Bumb.SharedKernel.CSharp.Domain.Base.Rules;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Domain.Base.Entities;

public abstract class BaseEntity(Guid? id = null, DateTime? createdAt = null)
{
    public Guid Id { get; } = id ?? Guid.NewGuid();

    public DateTime CreatedAt { get; } = createdAt ?? DateTime.Now;
}

public sealed class BaseEntityValidator : AbstractValidator<BaseEntity>
{
    public BaseEntityValidator()
    {
        RuleFor(e => e.Id)
            .SetValidator(new IdRule());

        RuleFor(e => e.CreatedAt)
            .SetValidator(new CreatedAtRule());
    }
}