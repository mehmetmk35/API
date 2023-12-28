using GulYapanAPI.Application.Repositorys;
using GulYapanAPI.Application.Repositorys.Payment;
using GulYapanAPI.Persistence.Contexts;
using GulYapanAPI.Persistence.Respositories;
using GulYapanAPI.Persistence.Respositories.Payment;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GulYapanAPI.Persistence.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GulYapanAPI.Persistence.Respositories.Sellers_Sellers;

namespace GulYapanAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static  void AddPersistanceServices(this IServiceCollection services) 
        {
            //services.AddSingleton

            services.AddDbContext<GulYapanMysqlAPIDbContext>(options => options.UseMySql(Configuration.ConnectionStringMysql, ServerVersion.AutoDetect(Configuration.ConnectionStringMysql)));
            services.AddDbContext<GulYapansqlAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionStringSql));
            services.AddDbContext<GulYapanNetsisSqlAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionStringSqlNetsis));

            services.AddScoped<ITBLFATUIRSReadRepository, TBLFATUIRSReadRepository>();
            services.AddScoped<IPayment_TraWriteRepositorycs, Payment_TraWriteRepositorycs>();
            services.AddScoped<ITBLEFATCARISReadRepository, TBLEFATCARIReadRepository>();
            services.AddScoped<ISellers_sellersWriteepository, Sellers_SellerseadRepository>();
            
        }
    }
}
