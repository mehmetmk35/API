using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Application.Repositorys
{
    public interface IReadRepositoryNetsis<T> : IRepository<T> where T : class
    {
        IQueryable<T> Get(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> metod, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> metod, bool tracking = true);
    }
}
