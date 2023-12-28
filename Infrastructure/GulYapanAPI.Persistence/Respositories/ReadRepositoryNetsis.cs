using GulYapanAPI.Application.Repositorys;
using GulYapanAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Persistence.Respositories
{

    public class ReadRepositoryNetsis<T> : IReadRepositoryNetsis<T> where T : class
    {
        private readonly GulYapanNetsisSqlAPIDbContext _context;

        public ReadRepositoryNetsis(GulYapanNetsisSqlAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> Get(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking(); //takip edilmesini istenmediği zaman 
            return query;
        }
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> metod, bool tracking = true)
        {

            var query = Table.Where(metod).AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;

        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> metod, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(metod);
        }





    }

}
