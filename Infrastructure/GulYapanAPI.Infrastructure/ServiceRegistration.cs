using GulYapanAPI.Application.Rest;
using Microsoft.Extensions.DependencyInjection;
using GulYapanAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static  void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IRest,Rest>();

        }
    }
}
