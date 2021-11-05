using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1_DAL_DatabaseAccessLayer_QLBH.Models;

#nullable disable

namespace _1_DAL_DatabaseAccessLayer_QLBH.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=CHEMMS;Initial Catalog=Vu98765;Persist Security Info=True;User ID=vudaph15914;Password=123");
#pragma warning restore CS1030 // #warning directive
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.DienThoai)
                    .HasName("PK__KhachHan__1F031877DF2266FE");

                entity.Property(e => e.DienThoai).IsUnicode(false);

                entity.Property(e => e.MaNv).IsUnicode(false);

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.KhachHangs)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KhachHang__MaNV__3C69FB99");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__NhanVien__2725D70A7FF9AD11");

                entity.Property(e => e.MaNv).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SanPham__FAC7442D5ACC255A");

                entity.Property(e => e.MaSanPham).ValueGeneratedNever();

                entity.Property(e => e.HinhAnh).IsUnicode(false);

                entity.Property(e => e.MaNv).IsUnicode(false);

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPham__MaNV__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
