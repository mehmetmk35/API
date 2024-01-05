using GulYapan.API.Domain.Entity.Sql;
using GulYapanAPI.Application.Repositorys;
using GulYapanAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Persistence.Respositories
{
    public class TBLEFATCARIReadRepository : ReadRepositoryNetsis<TBLEFATCARI>, ITBLEFATCARISReadRepository
    {
        public TBLEFATCARIReadRepository(GulYapanNetsisSqlAPIDbContext context) : base(context)
        {
        }

        public async Task<bool> EInvoiceRecipient(Expression<Func<TBLEFATCARI, bool>> metod)
        {

            var query = Table.AsQueryable();
            return await Task.Run(() => query.Where(metod).Any());

        }
    }
}
