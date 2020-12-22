using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StockMarket.AccoutAPI.Models
{
    public partial class StockMarketDBContext : DbContext
    {
        public StockMarketDBContext()
        {
        }

        public StockMarketDBContext(DbContextOptions<StockMarketDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<StockUser> StockUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SANTU\\MSSQLSERVER2019;Database=StockMarketDB;User ID=sa;Password=pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.Companyname)
                    .HasName("PK__company__838B6B7A54181764");

                entity.ToTable("company");

                entity.Property(e => e.Companyname)
                    .HasColumnName("companyname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ceo)
                    .HasColumnName("ceo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Stackexchage)
                    .HasColumnName("stackexchage")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Turnover).HasColumnName("turnover");
            });

            modelBuilder.Entity<StockUser>(entity =>
            {
                entity.ToTable("stock_user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pwd)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
