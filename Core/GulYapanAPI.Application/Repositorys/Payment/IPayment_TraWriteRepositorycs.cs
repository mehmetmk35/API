using GulYapan.API.Domain.Entity.MySql;
using GulYapan.API.Domain.Entity.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Application.Repositorys.Payment
{
    public interface IPayment_TraWriteRepositorycs : IWriteRepositorycs<payment_transactions>
    {
        Task<List<payment_transactions>> GetFilteredTransactions();
    }
}
