using YazilimAcademy.Domain.Common;
using YazilimAcademy.Domain.ValueObjects;

namespace YazilimAcademy.Domain.Entities;

public class User : EntityBase
{
    public Email Email { get; set; }
    public FullName FullName { get; set; }
    public PhoneNumber PhoneNumber { get; set; }
}

