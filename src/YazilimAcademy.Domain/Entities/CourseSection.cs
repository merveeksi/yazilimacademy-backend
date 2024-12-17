using System;
using YazilimAcademy.Domain.Common;

namespace YazilimAcademy.Domain.Entities;

public sealed class CourseSection : EntityBase
{
    public Guid CourseId { get; set; }
    public Course Course { get; set; }
    public string Title { get; set; }
    public TimeSpan TotalLength { get; set; }
    public int LectureCount { get; set; }
    public int Order { get; set; }

}
