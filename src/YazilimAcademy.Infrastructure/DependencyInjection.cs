using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YazilimAcademy.Application.Common.Interfaces;
using YazilimAcademy.Infrastructure.Persistence.Dapper;
using YazilimAcademy.Infrastructure.Persistence.EntityFramework.Contexts;
using YazilimAcademy.Infrastructure.Persistence.EntityFramework.Interceptors;

namespace YazilimAcademy.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ISqlConnectionFactory, SqlConnectionFactory>(provider => new SqlConnectionFactory(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<EntityInterceptor>();

        services.AddDbContext<ApplicationDbContext>((provider, options) =>
        {
            var entityInterceptor = provider.GetRequiredService<EntityInterceptor>();

            options.AddInterceptors(entityInterceptor);

            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));

            options.UseSnakeCaseNamingConvention();
        });

        services.AddScoped<IApplicationDbContext, ApplicationDbContext>();


        return services;
    }
}
