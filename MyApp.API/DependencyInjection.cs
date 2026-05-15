using MyApp.Application;
using MyApp.Infrastructure;

namespace MyApp.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services)
        {
            services.AddInfrastructureDI().AddApplicationDI();
            return services;
        }
    }   
}
