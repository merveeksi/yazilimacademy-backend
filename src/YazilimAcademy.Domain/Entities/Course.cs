using YazilimAcademy.Domain.Common;
using YazilimAcademy.Domain.Enums;

namespace YazilimAcademy.Domain.Entities;

public class Course : EntityBase
{
    public string Title { get; private set; }
    public string? SubTitle { get; private set; }
    public string? Description { get; private set; }
    public CourseLevel Level { get; private set; }
    public bool IsActive { get; private set; }
    public ICollection<CourseCategory> CourseCategories { get; private set; } = [];
}
