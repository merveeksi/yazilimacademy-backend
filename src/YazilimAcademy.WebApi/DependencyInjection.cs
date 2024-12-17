using Microsoft.Extensions.DependencyInjection;
using YazilimAcademy.Application.Common.Interfaces;
using YazilimAcademy.WebApi.Services;

namespace YazilimAcademy.WebApi;

public static class DependencyInjection
{
    public static IServiceCollection AddWebApi(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();

        services.AddScoped<ICurrentUserService, CurrentUserManager>();

        return services;
    }
}
