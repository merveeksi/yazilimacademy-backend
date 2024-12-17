using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace YazilimAcademy.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddMediatR(config =>
           {
               config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());

               // config.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

               // config.AddBehavior(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));

           });

        return services;
    }
}
