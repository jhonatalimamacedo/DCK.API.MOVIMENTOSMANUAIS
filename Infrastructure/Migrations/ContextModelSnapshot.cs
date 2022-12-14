// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("Infrastructure.Entity.MOVIMENTO_MANUAL", b =>
                {
                    b.Property<int>("DAT_MES")
                        .HasMaxLength(2)
                        .HasColumnType("INTEGER");

                    b.Property<int>("DAT_ANO")
                        .HasMaxLength(4)
                        .HasColumnType("INTEGER");

                    b.Property<int>("NUM_LANCAMENTO")
                        .HasMaxLength(18)
                        .HasColumnType("INTEGER");

                    b.Property<string>("COD_PRODUTO")
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<string>("COD_COSIF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<string>("COD_USUARIO")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DAT_MOVIMENTO")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("DES_DESCRICAO")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PRODUTO_COSIF_COD_COSIFCOD_COST")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PRODUTO_COSIF_COD_COSIFCOD_PRODUTO")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("VAL_VALOR")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.HasKey("DAT_MES", "DAT_ANO", "NUM_LANCAMENTO", "COD_PRODUTO");

                    b.HasIndex("PRODUTO_COSIF_COD_COSIFCOD_PRODUTO", "PRODUTO_COSIF_COD_COSIFCOD_COST");

                    b.ToTable("MOVIMENTO_MANUAL");
                });

            modelBuilder.Entity("Infrastructure.Entity.PRODUTO", b =>
                {
                    b.Property<string>("COD_PRODUTO")
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<string>("DES_PRODUTO")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("STA_STATUS")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("TEXT");

                    b.HasKey("COD_PRODUTO");

                    b.ToTable("PRODUTO");
                });

            modelBuilder.Entity("Infrastructure.Entity.PRODUTO_COSIF", b =>
                {
                    b.Property<string>("COD_PRODUTO")
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<string>("COD_COST")
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<string>("COD_CLASSIFICACAO")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<string>("STA_STATUS")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("TEXT");

                    b.HasKey("COD_PRODUTO", "COD_COST");

                    b.ToTable("PRODUTO_COSIF");
                });

            modelBuilder.Entity("Infrastructure.Entity.MOVIMENTO_MANUAL", b =>
                {
                    b.HasOne("Infrastructure.Entity.PRODUTO_COSIF", "PRODUTO_COSIF_COD_COSIF")
                        .WithMany()
                        .HasForeignKey("PRODUTO_COSIF_COD_COSIFCOD_PRODUTO", "PRODUTO_COSIF_COD_COSIFCOD_COST")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PRODUTO_COSIF_COD_COSIF");
                });

            modelBuilder.Entity("Infrastructure.Entity.PRODUTO_COSIF", b =>
                {
                    b.HasOne("Infrastructure.Entity.PRODUTO", "PRODUTO")
                        .WithMany()
                        .HasForeignKey("COD_PRODUTO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PRODUTO");
                });
#pragma warning restore 612, 618
        }
    }
}
