﻿// <auto-generated />
using DemoMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoMVC.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    partial class ApplicationDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("DemoMVC.Models.DaiLy", b =>
                {
                    b.Property<string>("MaDaiLy")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .HasColumnType("TEXT");

                    b.Property<string>("DienThoai")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaHTPP")
                        .HasColumnType("TEXT");

                    b.Property<string>("NguoiDaiDien")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenDaiLy")
                        .HasColumnType("TEXT");

                    b.HasKey("MaDaiLy");

                    b.HasIndex("MaHTPP");

                    b.ToTable("Daily");
                });

            modelBuilder.Entity("DemoMVC.Models.HeThongPhanPhoi", b =>
                {
                    b.Property<string>("MaHTPP")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenHTPP")
                        .HasColumnType("TEXT");

                    b.HasKey("MaHTPP");

                    b.ToTable("HeThongPhanPhoi");
                });

            modelBuilder.Entity("DemoMVC.Models.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DemoMVC.Models.Employee", b =>
                {
                    b.HasBaseType("DemoMVC.Models.Person");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("DemoMVC.Models.DaiLy", b =>
                {
                    b.HasOne("DemoMVC.Models.HeThongPhanPhoi", "HeThongPhanPhoi")
                        .WithMany()
                        .HasForeignKey("MaHTPP");

                    b.Navigation("HeThongPhanPhoi");
                });
#pragma warning restore 612, 618
        }
    }
}
