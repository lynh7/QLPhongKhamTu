﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhongKham.Infrastructure.Data;

namespace PhongKham.Infrastructure.Migrations
{
    [DbContext(typeof(PhongKhamDbContext))]
    [Migration("20230627091630_updateForeignKey")]
    partial class updateForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PhongKham.Core.Entities.BacSi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenBacSi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChiBS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sdtBS")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("bacSis");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.BenhNhan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenBenhNhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dChiBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gioiTinh")
                        .HasColumnType("int");

                    b.Property<int>("sdtBN")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("benhNhans");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.ChiTietToaThuoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ThuocId")
                        .HasColumnType("int");

                    b.Property<int>("ToaThuocId")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ThuocId");

                    b.HasIndex("ToaThuocId");

                    b.ToTable("chiTietToaThuocs");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BenhNhanId")
                        .HasColumnType("int");

                    b.Property<int>("PhieuKhamBenhId")
                        .HasColumnType("int");

                    b.Property<int>("TongThanhToan")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BenhNhanId");

                    b.HasIndex("PhieuKhamBenhId")
                        .IsUnique();

                    b.ToTable("hoaDons");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.LichHen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BenhNhanId")
                        .HasColumnType("int");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateTimeLichHen")
                        .HasColumnType("datetime2");

                    b.Property<string>("tenBenhNhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenLichHen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BenhNhanId");

                    b.ToTable("lichHens");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.PhieuKhamBenh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BacSiId")
                        .HasColumnType("int");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LichHenId")
                        .HasColumnType("int");

                    b.Property<string>("TrieuChung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateTimeKhamBenh")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BacSiId");

                    b.HasIndex("LichHenId")
                        .IsUnique();

                    b.ToTable("phieuKhamBenhs");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.PhieuTiemPhong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ghichu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTiemPhong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThanhTien")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateTimeTiemPhong")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("phieuTiemPhongs");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.PhieuTuVan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTuVan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThanhTien")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateTimeTuVan")
                        .HasColumnType("datetime2");

                    b.Property<int?>("lichHenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("lichHenId");

                    b.ToTable("phieuTuVans");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.PhieuXetNghiem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenXetNghiem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThanhTien")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateTimeXetNghiem")
                        .HasColumnType("datetime2");

                    b.Property<int>("ketQuaXetNghiem")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("phieuXetNghiems");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Thuoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<string>("TenThuoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cachDung")
                        .HasColumnType("int");

                    b.Property<int>("donVi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("thuocs");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.ToaThuoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhieuKhamBenhId")
                        .HasColumnType("int");

                    b.Property<int>("TongTienThuoc")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataTimeToaThuoc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PhieuKhamBenhId")
                        .IsUnique();

                    b.ToTable("toaThuocs");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.ChiTietToaThuoc", b =>
                {
                    b.HasOne("PhongKham.Core.Entities.Thuoc", "Thuoc")
                        .WithMany()
                        .HasForeignKey("ThuocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhongKham.Core.Entities.ToaThuoc", "ToaThuoc")
                        .WithMany("chiTietToaThuocs")
                        .HasForeignKey("ToaThuocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Thuoc");

                    b.Navigation("ToaThuoc");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.HoaDon", b =>
                {
                    b.HasOne("PhongKham.Core.Entities.BenhNhan", "benhNhan")
                        .WithMany()
                        .HasForeignKey("BenhNhanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhongKham.Core.Entities.PhieuKhamBenh", "phieuKhamBenh")
                        .WithOne("hoaDon")
                        .HasForeignKey("PhongKham.Core.Entities.HoaDon", "PhieuKhamBenhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("benhNhan");

                    b.Navigation("phieuKhamBenh");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.LichHen", b =>
                {
                    b.HasOne("PhongKham.Core.Entities.BenhNhan", "BenhNhan")
                        .WithMany("lichHens")
                        .HasForeignKey("BenhNhanId");

                    b.Navigation("BenhNhan");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.PhieuKhamBenh", b =>
                {
                    b.HasOne("PhongKham.Core.Entities.BacSi", "bacSi")
                        .WithMany("phieuKhamBenhs")
                        .HasForeignKey("BacSiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhongKham.Core.Entities.LichHen", "lichHen")
                        .WithOne("phieuKhamBenh")
                        .HasForeignKey("PhongKham.Core.Entities.PhieuKhamBenh", "LichHenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bacSi");

                    b.Navigation("lichHen");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.PhieuTuVan", b =>
                {
                    b.HasOne("PhongKham.Core.Entities.LichHen", "lichHen")
                        .WithMany()
                        .HasForeignKey("lichHenId");

                    b.Navigation("lichHen");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.ToaThuoc", b =>
                {
                    b.HasOne("PhongKham.Core.Entities.PhieuKhamBenh", "phieuKhamBenh")
                        .WithOne("toaThuoc")
                        .HasForeignKey("PhongKham.Core.Entities.ToaThuoc", "PhieuKhamBenhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("phieuKhamBenh");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.BacSi", b =>
                {
                    b.Navigation("phieuKhamBenhs");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.BenhNhan", b =>
                {
                    b.Navigation("lichHens");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.LichHen", b =>
                {
                    b.Navigation("phieuKhamBenh");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.PhieuKhamBenh", b =>
                {
                    b.Navigation("hoaDon");

                    b.Navigation("toaThuoc");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.ToaThuoc", b =>
                {
                    b.Navigation("chiTietToaThuocs");
                });
#pragma warning restore 612, 618
        }
    }
}
