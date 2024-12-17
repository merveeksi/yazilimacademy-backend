namespace YazilimAcademy.Domain.Common;

public abstract class EntityBase : ICreatedByEntity, IModifiedByEntity, IIsActive
{
    public virtual Guid Id { get; set; }
    public virtual string CreatedByUserId { get; set; }
    public virtual DateTimeOffset CreatedAt { get; set; }
    public virtual string? ModifiedByUserId { get; set; }
    public virtual DateTimeOffset? ModifiedAt { get; set; }
    public virtual bool IsActive { get; set; }
}

