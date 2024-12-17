using YazilimAcademy.Domain.Common;
using YazilimAcademy.Domain.Identity;

namespace YazilimAcademy.Domain.Entities
{
    public class CourseComment:EntityBase<Guid>
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public string CourseId { get; set; }
        public Course Course { get; set; }

        public string Text { get; set; }
    }
}
