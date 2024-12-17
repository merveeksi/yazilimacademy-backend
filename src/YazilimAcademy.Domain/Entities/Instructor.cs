using YazilimAcademy.Domain.Common;
using YazilimAcademy.Domain.ValueObjects;

namespace YazilimAcademy.Domain.Entities
{
    public class Instructor : EntityBase
    {
        public FullName FullName { get; set; }
        public string? Headline { get; set; }
        public Email Email { get; set; }
        public string? Bio { get; set; }
        public string? ProfilePicturePath { get; set; }
        public ICollection<InstructorSocialMediaLink> SocialMediaLinks { get; set; } = [];

        public ICollection<CourseInstructor> Courses { get; set; }
    }
}
