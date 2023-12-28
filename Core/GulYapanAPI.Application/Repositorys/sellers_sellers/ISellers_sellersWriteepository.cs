using GulYapan.API.Domain.Entity.MySql;
using GulYapan.API.Domain.Entity.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Application.Repositorys
{
    public interface ISellers_sellersWriteepository : IWriteRepositorycs<sellers_sellers>
    {
        Task<sellers_sellers> GetSellers(Expression<Func<sellers_sellers, bool>> metod);
    }
}
