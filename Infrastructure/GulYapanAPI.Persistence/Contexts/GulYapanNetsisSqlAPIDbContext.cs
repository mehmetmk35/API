using GulYapan.API.Domain.Entity.MySql;
using GulYapan.API.Domain.Entity.Sql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Persistence.Contexts
{
    public class GulYapanNetsisSqlAPIDbContext:DbContext
    {
        public GulYapanNetsisSqlAPIDbContext()
        {
        }

        public GulYapanNetsisSqlAPIDbContext(DbContextOptions<GulYapanNetsisSqlAPIDbContext> options) : base(options)
        {
        }
       
      public DbSet<TBLEFATCARI> TBLEFATCARI { get; set; }
    }
}
