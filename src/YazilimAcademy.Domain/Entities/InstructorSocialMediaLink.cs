using YazilimAcademy.Domain.Common;
using YazilimAcademy.Domain.Enums;

namespace YazilimAcademy.Domain.Entities;

public sealed class InstructorSocialMediaLink : EntityBase
{
    public Guid InstructorId { get; set; }
    public Instructor Instructor { get; set; }
    public string Url { get; set; }
    public SocialMediaLinkType Type { get; set; }
}