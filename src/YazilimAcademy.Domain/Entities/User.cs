using YazilimAcademy.Domain.Common;
using YazilimAcademy.Domain.ValueObjects;

namespace YazilimAcademy.Domain.Entities;

public sealed class User : EntityBase
{
    public Email Email { get; set; }
    public FullName FullName { get; set; }
    public PhoneNumber PhoneNumber { get; set; }
}

