using GulYapan.API.Domain.Entity.MySql;
using GulYapan.API.Domain.Entity.Sql;
using GulYapanAPI.Application.Repositorys.Payment;
using GulYapanAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Persistence.Respositories.Payment
{
    public class Payment_TraWriteRepositorycs : WriteRepository<payment_transactions>, IPayment_TraWriteRepositorycs
    {
        public Payment_TraWriteRepositorycs(GulYapanMysqlAPIDbContext context) : base(context)
        {
        }

        public async Task<List<payment_transactions>> GetFilteredTransactions()
        {
            var query =  Table.Where(x=>x.InstallmentRate>Configuration.InstallmentRate && x.Installment>Configuration.Installment && x.Status=="complete" && x.InvoiceSyncStatus=="pending").AsQueryable();

            return await query.ToListAsync();
        }
    }
}
