using System;
using YazilimAcademy.Domain.Common;

namespace YazilimAcademy.Domain.Entities;

public sealed class CourseCategory : EntityBase
{
    public Guid CourseId { get; set; }
    public Course Course { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
