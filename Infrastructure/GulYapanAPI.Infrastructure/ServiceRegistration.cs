using GulYapanAPI.Application.Rest;
using Microsoft.Extensions.DependencyInjection; 
using GulYapanAPI.Application.Repositorys.ILogger;
using GulYapanAPI.Infrastructure.Logger;

namespace GulYapanAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static  void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IRest,Rest>();
            services.AddScoped<ILog,Log>();

        }
    }
}
