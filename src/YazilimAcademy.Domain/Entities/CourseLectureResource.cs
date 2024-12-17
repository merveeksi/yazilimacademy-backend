using YazilimAcademy.Domain.Common;

namespace YazilimAcademy.Domain.Entities;

public class CourseLectureResource : EntityBase
{
    public Guid LectureId { get; set; }
    public CourseLecture Lecture { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public int Order { get; set; }
}
