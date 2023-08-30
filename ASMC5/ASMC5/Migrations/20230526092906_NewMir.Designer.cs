﻿// <auto-generated />
using System;
using ASMC5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASMC5.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230526092906_NewMir")]
    partial class NewMir
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASMC5.Models.DonHang", b =>
                {
                    b.Property<int>("Id_DonHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Id_KhachHang")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayDat")
                        .HasColumnType("datetime2");

                    b.Property<double>("ThanhTienChuaThue")
                        .HasColumnType("float");

                    b.Property<double>("ThanhTienCoThue")
                        .HasColumnType("float");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id_DonHang");

                    b.HasIndex("Id_KhachHang");

                    b.ToTable("DonHangs");
                });

            modelBuilder.Entity("ASMC5.Models.DonHangChiTiet", b =>
                {
                    b.Property<int>("Id_DHCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Id_DonHang")
                        .HasColumnType("int");

                    b.Property<int>("Id_MonAn")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<double>("ThanhTienChuaThue")
                        .HasColumnType("float");

                    b.Property<double>("ThanhTienCoThue")
                        .HasColumnType("float");

                    b.Property<double>("VAT")
                        .HasColumnType("float");

                    b.HasKey("Id_DHCT");

                    b.HasIndex("Id_DonHang");

                    b.HasIndex("Id_MonAn");

                    b.ToTable("DonHangChiTiets");
                });

            modelBuilder.Entity("ASMC5.Models.KhachHang", b =>
                {
                    b.Property<int>("Id_KH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FbLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("Char(15)");

                    b.HasKey("Id_KH");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("ASMC5.Models.MonAn", b =>
                {
                    b.Property<int>("Id_MonAn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Image")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PhanLoai")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id_MonAn");

                    b.ToTable("MonAns");
                });

            modelBuilder.Entity("ASMC5.Models.NguoiDung", b =>
                {
                    b.Property<int>("Id_NguoiDung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("Char(15)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id_NguoiDung");

                    b.ToTable("NguoiDungs");
                });

            modelBuilder.Entity("ASMC5.Models.ViewModels.DoiMatKhau", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NewPass")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("RetypePass")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Email");

                    b.ToTable("DoiMatKhau");
                });

            modelBuilder.Entity("ASMC5.Models.ViewModels.Login", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<bool>("role")
                        .HasColumnType("bit");

                    b.HasKey("Email");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("ASMC5.Models.DonHang", b =>
                {
                    b.HasOne("ASMC5.Models.KhachHang", "KhachHang")
                        .WithMany("DonHang")
                        .HasForeignKey("Id_KhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("ASMC5.Models.DonHangChiTiet", b =>
                {
                    b.HasOne("ASMC5.Models.DonHang", "DonHang")
                        .WithMany("DonHangChiTiet")
                        .HasForeignKey("Id_DonHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASMC5.Models.MonAn", "MonAn")
                        .WithMany("DonHangChiTiet")
                        .HasForeignKey("Id_MonAn")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonHang");

                    b.Navigation("MonAn");
                });

            modelBuilder.Entity("ASMC5.Models.DonHang", b =>
                {
                    b.Navigation("DonHangChiTiet");
                });

            modelBuilder.Entity("ASMC5.Models.KhachHang", b =>
                {
                    b.Navigation("DonHang");
                });

            modelBuilder.Entity("ASMC5.Models.MonAn", b =>
                {
                    b.Navigation("DonHangChiTiet");
                });
#pragma warning restore 612, 618
        }
    }
}