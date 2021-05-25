using BackNexos.Api.Application;
using BackNexos.Domain;
using BackNexos.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackNexos.Api.Config
{
    public static class ServiceConfig
    {
        public static IServiceCollection AddApplicationService (this IServiceCollection services)
        {
            services.AddScoped<IService, Service>();
            services.AddScoped<IRepository, Repository>();
            return services;
        }
    }
}
