using System;
using YazilimAcademy.Application.Common.Interfaces;
using YazilimAcademy.Domain.Helpers;

namespace YazilimAcademy.WebApi.Services;

public sealed class CurrentUserManager : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IWebHostEnvironment _env;

    public CurrentUserManager(IHttpContextAccessor httpContextAccessor, IWebHostEnvironment env)
    {
        _httpContextAccessor = httpContextAccessor;
        _env = env;
    }

    public Guid UserId => GetUserId();

    public string IpAddress => GetIpAddress();

    private Guid GetUserId()
    {
        var userId = _httpContextAccessor.HttpContext?.User.FindFirst("uid")?.Value;

        return userId is null ? Guid.Empty : Guid.Parse(userId);
    }

    private string GetIpAddress()
    {
        if (_env.IsDevelopment())
            return IpHelper.GetIpAddress();

        if (_httpContextAccessor.HttpContext.Request.Headers.ContainsKey("X-Forwarded-For"))
            return _httpContextAccessor.HttpContext.Request.Headers["X-Forwarded-For"];
        else
            return _httpContextAccessor.HttpContext.Connection.RemoteIpAddress?.ToString();
    }
}