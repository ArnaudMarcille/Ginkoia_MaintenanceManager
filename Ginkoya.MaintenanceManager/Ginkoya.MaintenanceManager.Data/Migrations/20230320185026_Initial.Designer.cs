﻿// <auto-generated />
using System;
using Ginkoya.MaintenanceManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ginkoya.MaintenanceManager.Data.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20230320185026_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.CatalogProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CatalogProducts");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TypeId");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.EquipmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EquipmentTypes");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("FinalPrice")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technician")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("WorkTypeId");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.WorkChangedPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("WorkId");

                    b.ToTable("WorkChangedParts");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.WorkType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipmentTypeId")
                        .HasColumnType("int");

                    b.Property<int>("FixedDuration")
                        .HasColumnType("int");

                    b.Property<bool>("HaveFixedPrice")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentTypeId");

                    b.ToTable("WorkTypes");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.Equipment", b =>
                {
                    b.HasOne("Ginkoya.MaintenanceManager.Core.Entities.Customer", "Customer")
                        .WithMany("Equipments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Ginkoya.MaintenanceManager.Core.Entities.EquipmentType", "Type")
                        .WithMany("Equipments")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.Work", b =>
                {
                    b.HasOne("Ginkoya.MaintenanceManager.Core.Entities.Equipment", "Equipment")
                        .WithMany("Works")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Ginkoya.MaintenanceManager.Core.Entities.WorkType", "WorkType")
                        .WithMany("Works")
                        .HasForeignKey("WorkTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("WorkType");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.WorkChangedPart", b =>
                {
                    b.HasOne("Ginkoya.MaintenanceManager.Core.Entities.CatalogProduct", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Ginkoya.MaintenanceManager.Core.Entities.Work", "Work")
                        .WithMany("WorkChangedParts")
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Work");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.WorkType", b =>
                {
                    b.HasOne("Ginkoya.MaintenanceManager.Core.Entities.EquipmentType", "EquipmentType")
                        .WithMany("WorkTypes")
                        .HasForeignKey("EquipmentTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("EquipmentType");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.Customer", b =>
                {
                    b.Navigation("Equipments");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.Equipment", b =>
                {
                    b.Navigation("Works");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.EquipmentType", b =>
                {
                    b.Navigation("Equipments");

                    b.Navigation("WorkTypes");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.Work", b =>
                {
                    b.Navigation("WorkChangedParts");
                });

            modelBuilder.Entity("Ginkoya.MaintenanceManager.Core.Entities.WorkType", b =>
                {
                    b.Navigation("Works");
                });
#pragma warning restore 612, 618
        }
    }
}