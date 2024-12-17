namespace YazilimAcademy.Domain.Entities;

public sealed class CourseCategory
{
    public Guid CourseId { get; set; }
    public Course Course { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
