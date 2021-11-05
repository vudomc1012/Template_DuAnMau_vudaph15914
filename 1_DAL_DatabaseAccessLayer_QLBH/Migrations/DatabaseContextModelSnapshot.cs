﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL_DatabaseAccessLayer_QLBH.Context;

namespace _1_DAL_DatabaseAccessLayer_QLBH.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("_1_DAL_DatabaseAccessLayer_QLBH.Models.KhachHang", b =>
                {
                    b.Property<string>("DienThoai")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MaNv")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("MaNV");

                    b.Property<string>("Phai")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("TenKhach")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte>("TinhTrang")
                        .HasColumnType("tinyint");

                    b.Property<byte>("statsSave")
                        .HasColumnType("tinyint");

                    b.HasKey("DienThoai")
                        .HasName("PK__KhachHan__1F031877DF2266FE");

                    b.HasIndex("MaNv");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1_DAL_DatabaseAccessLayer_QLBH.Models.NhanVien", b =>
                {
                    b.Property<string>("MaNv")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("MaNV");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<byte>("Loginf")
                        .HasColumnType("tinyint");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenNv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenNV");

                    b.Property<byte>("TinhTrang")
                        .HasColumnType("tinyint");

                    b.Property<byte>("VaiTro")
                        .HasColumnType("tinyint");

                    b.Property<byte>("statsSave")
                        .HasColumnType("tinyint");

                    b.HasKey("MaNv")
                        .HasName("PK__NhanVien__2725D70A7FF9AD11");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1_DAL_DatabaseAccessLayer_QLBH.Models.SanPham", b =>
                {
                    b.Property<int>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<double>("DonGiaBan")
                        .HasColumnType("float");

                    b.Property<double>("DonGiaNhap")
                        .HasColumnType("float");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasMaxLength(400)
                        .IsUnicode(false)
                        .HasColumnType("varchar(400)");

                    b.Property<string>("MaNv")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("MaNV");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte>("statsSave")
                        .HasColumnType("tinyint");

                    b.HasKey("MaSanPham")
                        .HasName("PK__SanPham__FAC7442D5ACC255A");

                    b.HasIndex("MaNv");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("_1_DAL_DatabaseAccessLayer_QLBH.Models.KhachHang", b =>
                {
                    b.HasOne("_1_DAL_DatabaseAccessLayer_QLBH.Models.NhanVien", "MaNvNavigation")
                        .WithMany("KhachHangs")
                        .HasForeignKey("MaNv")
                        .HasConstraintName("FK__KhachHang__MaNV__3C69FB99")
                        .IsRequired();

                    b.Navigation("MaNvNavigation");
                });

            modelBuilder.Entity("_1_DAL_DatabaseAccessLayer_QLBH.Models.SanPham", b =>
                {
                    b.HasOne("_1_DAL_DatabaseAccessLayer_QLBH.Models.NhanVien", "MaNvNavigation")
                        .WithMany("SanPhams")
                        .HasForeignKey("MaNv")
                        .HasConstraintName("FK__SanPham__MaNV__398D8EEE")
                        .IsRequired();

                    b.Navigation("MaNvNavigation");
                });

            modelBuilder.Entity("_1_DAL_DatabaseAccessLayer_QLBH.Models.NhanVien", b =>
                {
                    b.Navigation("KhachHangs");

                    b.Navigation("SanPhams");
                });
#pragma warning restore 612, 618
        }
    }
}