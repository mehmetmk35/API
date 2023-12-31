﻿using GulYapanAPI.Application.Repositorys;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GulYapanAPI.Persistence.Contexts;

namespace GulYapanAPI.Persistence.Respositories
{
    public class WriteRepository<T> : IWriteRepositorycs<T> where T : class
    {
        private readonly GulYapanMysqlAPIDbContext _context;

        public WriteRepository(GulYapanMysqlAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityentry = await Table.AddAsync(model);

            return entityentry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true; //düzenleme yapılacak
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityentry = Table.Remove(model);
            return entityentry.State == EntityState.Deleted;
        }
        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<bool> Remove(Expression<Func<T, bool>> metod)
        {
            T model = await Table.FirstOrDefaultAsync(metod);
            return Remove(model);

        }
        public bool Update(T model)
        {
            EntityEntry<T> entityentry = Table.Update(model);
            return entityentry.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync()
         => await _context.SaveChangesAsync();


    }

}
