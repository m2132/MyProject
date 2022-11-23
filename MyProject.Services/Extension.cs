using Microsoft.Extensions.DependencyInjection;
using MyProject.Repositories;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public static class Extension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IPermissionService, PermissionSerevice>();
            services.AddScoped<IClaimService, ClaimService>();
            services.AddAutoMapper(typeof(Mapping));
            return services;
        }

    }
}
