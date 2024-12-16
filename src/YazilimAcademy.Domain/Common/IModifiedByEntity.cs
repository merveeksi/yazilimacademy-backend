namespace YazilimAcademy.Domain.Common;

public interface IModifiedByEntity
{
    public string? ModifiedByUserId { get; set; }
    public DateTimeOffset? ModifiedAt { get; set; }
}
