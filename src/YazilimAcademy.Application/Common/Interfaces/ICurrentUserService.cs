using System;

namespace YazilimAcademy.Application.Common.Interfaces;

public interface ICurrentUserService
{
    Guid UserId { get; }
    string IpAddress { get; }
}
