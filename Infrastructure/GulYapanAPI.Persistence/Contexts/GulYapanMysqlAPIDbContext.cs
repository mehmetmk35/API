using GulYapan.API.Domain.Entity.MySql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Persistence.Contexts
{
    public sealed class GulYapanMysqlAPIDbContext : DbContext
    {
        public GulYapanMysqlAPIDbContext()
        {
        }
        public GulYapanMysqlAPIDbContext(DbContextOptions<GulYapanMysqlAPIDbContext> options) : base(options)
        {
        }
        public DbSet<payment_transactions> payment_transactions { get; set; }
        public DbSet<sellers_sellers> sellers_sellers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
