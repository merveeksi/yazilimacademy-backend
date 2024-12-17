using YazilimAcademy.Domain.Common;

namespace YazilimAcademy.Domain.Entities;

public class Category : EntityBase
{
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public ICollection<CourseCategory> CourseCategories { get; private set; } = [];

    public static Category Create(string name, string? description)
    {
        return new Category
        {
            Id = Guid.CreateVersion7(),
            Name = name,
            Description = description,
            CreatedAt = DateTimeOffset.UtcNow,
        };
    }
}
