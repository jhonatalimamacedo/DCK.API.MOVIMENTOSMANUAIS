using Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opts) : base(opts) { }

        public DbSet<MOVIMENTO_MANUAL> mOVIMENTO_MANUAL { get; set; }
        public DbSet<PRODUTO> pRODUTO { get; set; }
        public DbSet<PRODUTO_COSIF> pRODUTO_COSIF { get; set; }

    }
}
