using Microsoft.Extensions.DependencyInjection;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories
{
    public static class Extentions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IClaimRepository, ClaimRepository>();
            return services;
        }
    }
}
