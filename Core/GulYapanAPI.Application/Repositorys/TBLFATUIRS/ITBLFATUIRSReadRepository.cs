using GulYapan.API.Domain.Entity.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Application.Repositorys
{
    public interface ITBLFATUIRSReadRepository:IReadRepository<TBLFATUIRS> 
    {
        Task<string> GetLastInvoiceNumberAsync(Expression<Func<TBLFATUIRS, bool>> metod, bool tracking = true);
        
    }
}
