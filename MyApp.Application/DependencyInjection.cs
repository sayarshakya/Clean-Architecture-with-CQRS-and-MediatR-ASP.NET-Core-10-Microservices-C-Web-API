using Microsoft.Extensions.DependencyInjection;
using MyApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
            return services;
        }
    }
}
