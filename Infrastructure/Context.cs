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
            modelBuilder.Entity<MOVIMENTO_MANUAL>().HasKey(m => new {
                m.DAT_MES,
                m.DAT_ANO,
                m.NUM_LANCAMENTO,
                m.COD_PRODUTO
            });
            modelBuilder.Entity<MOVIMENTO_MANUAL>().Property(m => m.DAT_MOVIMENTO).HasColumnType("smalldatetime");

        }

        public Context(DbContextOptions<Context> opts) : base(opts) { }

        public DbSet<MOVIMENTO_MANUAL> MOVIMENTO_MANUAL { get; set; }
        public DbSet<PRODUTO> PRODUTO { get; set; }
        public DbSet<PRODUTO_COSIF> PRODUTO_COSIF { get; set; }

    }

   
}
