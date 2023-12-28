using GulYapan.API.Domain.Entity.MySql;
using GulYapan.API.Domain.Entity.Sql;
using GulYapanAPI.Application.Repositorys;
using GulYapanAPI.Application.Repositorys.Payment;
using GulYapanAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Persistence.Respositories.Sellers_Sellers
{
    public class Sellers_SellerseadRepository : WriteRepository<sellers_sellers>, ISellers_sellersWriteepository
    {
        public Sellers_SellerseadRepository(GulYapanMysqlAPIDbContext context) : base(context)
        {
        }

        public async Task<sellers_sellers> GetSellers(Expression<Func<sellers_sellers, bool>> metod)
        {
            var query = Table.AsQueryable();
             
            return await query.Where(metod).FirstOrDefaultAsync();       

            


        }
    }
}
