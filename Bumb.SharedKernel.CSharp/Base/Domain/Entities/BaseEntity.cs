using Bumb.SharedKernel.CSharp.Base.Domain.Rules;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Entities;

public abstract class BaseEntity
{
    private readonly Guid _id;
    public Guid Id
    {
        get => _id;
        init
        {
            EntityIdRule.ValidateAndThrow(value);
            _id = value;
        }
    }

    public DateTime CreatedAt { get; }

    protected BaseEntity(Guid? id = null, DateTime? createdAt = null)
    {
        Id = id ?? Guid.NewGuid();
        CreatedAt = createdAt ?? DateTime.Now;
    }
}