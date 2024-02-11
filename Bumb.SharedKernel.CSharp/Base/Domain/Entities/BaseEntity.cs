using Bumb.SharedKernel.CSharp.Base.Domain.ValObjs.GuidId;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Entities;

public abstract class BaseEntity<TId> where TId : BaseGuidId<TId>
{
    public TId Id { get; init; } = (TId)Activator.CreateInstance(typeof(TId), Guid.NewGuid())!;

    public DateTime CreatedAt { get; init; } = DateTime.Now;

    protected BaseEntity()
    { }

    protected BaseEntity(TId id, DateTime createdAt)
    {
        Id = id;
        CreatedAt = createdAt;
    }
}