﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210905214607_AddShopingCart")]
    partial class AddShopingCart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.BarcodeScanners", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CbBrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CbModelId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentNumber")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CbBrandId");

                    b.HasIndex("CbModelId");

                    b.ToTable("BarcodeScanners");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.CbBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CbEquipmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CbEquipmentId");

                    b.ToTable("CbBrand");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.CbEquipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CbEquipment");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.CbLabels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CbLabels");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.CbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CbBrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CbBrandId");

                    b.ToTable("CbModel");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.CbRibbons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CbRibbons");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.EquipmentService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CbBrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CbEquipmentId")
                        .HasColumnType("int");

                    b.Property<int?>("CbModelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MalfunctionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpareParts")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CbBrandId");

                    b.HasIndex("CbEquipmentId");

                    b.HasIndex("CbModelId");

                    b.ToTable("EquipmentService");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.Labels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CbLabelsId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentNumber")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CbLabelsId");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.MobileComputers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CbBrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CbModelId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentNumber")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CbBrandId");

                    b.HasIndex("CbModelId");

                    b.ToTable("MobileComputers");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.Ribbons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CbRibbonsId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentNumber")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CbRibbonsId");

                    b.ToTable("Ribbons");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CbBrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CbModelId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ThermalPrintersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CbBrandId");

                    b.HasIndex("CbModelId");

                    b.HasIndex("ThermalPrintersId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.ThermalPrinters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CbBrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CbModelId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentNumber")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dpi")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CbBrandId");

                    b.HasIndex("CbModelId");

                    b.ToTable("ThermalPrinters");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ZebraconProdaja.Models.BarcodeScanners", b =>
                {
                    b.HasOne("ZebraconProdaja.Models.CbBrand", "CbBrand")
                        .WithMany("BarcodeScanners")
                        .HasForeignKey("CbBrandId");

                    b.HasOne("ZebraconProdaja.Models.CbModel", "CbModel")
                        .WithMany("BarcodeScanners")
                        .HasForeignKey("CbModelId");

                    b.Navigation("CbBrand");

                    b.Navigation("CbModel");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.CbBrand", b =>
                {
                    b.HasOne("ZebraconProdaja.Models.CbEquipment", "CbEquipment")
                        .WithMany("CbBrand")
                        .HasForeignKey("CbEquipmentId");

                    b.Navigation("CbEquipment");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.CbModel", b =>
                {
                    b.HasOne("ZebraconProdaja.Models.CbBrand", "CbBrand")
                        .WithMany()
                        .HasForeignKey("CbBrandId");

                    b.Navigation("CbBrand");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.EquipmentService", b =>
                {
                    b.HasOne("ZebraconProdaja.Models.CbBrand", "CbBrand")
                        .WithMany()
                        .HasForeignKey("CbBrandId");

                    b.HasOne("ZebraconProdaja.Models.CbEquipment", "CbEquipment")
                        .WithMany("EquipmentService")
                        .HasForeignKey("CbEquipmentId");

                    b.HasOne("ZebraconProdaja.Models.CbModel", "CbModel")
                        .WithMany()
                        .HasForeignKey("CbModelId");

                    b.Navigation("CbBrand");

                    b.Navigation("CbEquipment");

                    b.Navigation("CbModel");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.Labels", b =>
                {
                    b.HasOne("ZebraconProdaja.Models.CbLabels", "CbLabels")
                        .WithMany("Labels")
                        .HasForeignKey("CbLabelsId");

                    b.Navigation("CbLabels");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.MobileComputers", b =>
                {
                    b.HasOne("ZebraconProdaja.Models.CbBrand", "CbBrand")
                        .WithMany("MobileComputers")
                        .HasForeignKey("CbBrandId");

                    b.HasOne("ZebraconProdaja.Models.CbModel", "CbModel")
                        .WithMany("MobileComputers")
                        .HasForeignKey("CbModelId");

                    b.Navigation("CbBrand");

                    b.Navigation("CbModel");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.Ribbons", b =>
                {
                    b.HasOne("ZebraconProdaja.Models.CbRibbons", "CbRibbons")
                        .WithMany("Ribbons")
                        .HasForeignKey("CbRibbonsId");

                    b.Navigation("CbRibbons");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ZebraconProdaja.Models.CbBrand", "CbBrand")
                        .WithMany()
                        .HasForeignKey("CbBrandId");

                    b.HasOne("ZebraconProdaja.Models.CbModel", "CbModel")
                        .WithMany()
                        .HasForeignKey("CbModelId");

                    b.HasOne("ZebraconProdaja.Models.ThermalPrinters", "ThermalPrinters")
                        .WithMany()
                        .HasForeignKey("ThermalPrintersId");

                    b.Navigation("CbBrand");

                    b.Navigation("CbModel");

                    b.Navigation("ThermalPrinters");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.ThermalPrinters", b =>
                {
                    b.HasOne("ZebraconProdaja.Models.CbBrand", "CbBrand")
                        .WithMany("TermalPrinters")
                        .HasForeignKey("CbBrandId");

                    b.HasOne("ZebraconProdaja.Models.CbModel", "CbModel")
                        .WithMany("TermalPrinters")
                        .HasForeignKey("CbModelId");

                    b.Navigation("CbBrand");

                    b.Navigation("CbModel");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.CbBrand", b =>
                {
                    b.Navigation("BarcodeScanners");

                    b.Navigation("MobileComputers");

                    b.Navigation("TermalPrinters");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.CbEquipment", b =>
                {
                    b.Navigation("CbBrand");

                    b.Navigation("EquipmentService");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.CbLabels", b =>
                {
                    b.Navigation("Labels");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.CbModel", b =>
                {
                    b.Navigation("BarcodeScanners");

                    b.Navigation("MobileComputers");

                    b.Navigation("TermalPrinters");
                });

            modelBuilder.Entity("ZebraconProdaja.Models.CbRibbons", b =>
                {
                    b.Navigation("Ribbons");
                });
#pragma warning restore 612, 618
        }
    }
}
