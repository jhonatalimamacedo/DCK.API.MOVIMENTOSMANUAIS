using Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure
{
    public class Context : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PRODUTO>().HasKey(p => new { p.COD_PRODUTO });
            modelBuilder.Entity<PRODUTO_COSIF>().HasKey(p => new {
                p.COD_PRODUTO,
                p.COD_COST
            });
            modelBuilder.Entity<MOVIMENTO_MANUAL>().HasKey(p => new { p.DAT_MES });
        }

        public Context(DbContextOptions<Context> opts) : base(opts) { }

        public DbSet<MOVIMENTO_MANUAL> mOVIMENTO_MANUAL { get; set; }
        public DbSet<PRODUTO> pRODUTO { get; set; }
        public DbSet<PRODUTO_COSIF> pRODUTO_COSIF { get; set; }

    }

   
}
