﻿// <auto-generated />
using System;
using BusinessData.ofProduct.ofDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessData.Migrations.ProductDb
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BusinessData.Center", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FailLogin")
                        .HasColumnType("int");

                    b.Property<string>("FaxNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Center");
                });

            modelBuilder.Entity("BusinessData.Commodity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Barcode")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("HsCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OpponentBusinessUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.ToTable("Commodity");
                });

            modelBuilder.Entity("BusinessData.EStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MStatusId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("CommodityId");

                    b.HasIndex("MStatusId");

                    b.ToTable("EStatus");
                });

            modelBuilder.Entity("BusinessData.MStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SStatusId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("CommodityId");

                    b.HasIndex("SStatusId");

                    b.ToTable("MStatus");
                });

            modelBuilder.Entity("BusinessData.ofProduct.ProductLand", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AreaofPlantation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AreaofProductLand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AreaofRestProductLand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandBookCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProducterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductCenterId");

                    b.HasIndex("ProducterId");

                    b.ToTable("ProductLand");
                });

            modelBuilder.Entity("BusinessData.SStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("CommodityId");

                    b.ToTable("SStatus");
                });

            modelBuilder.Entity("BusinessData.ofProduct.EPCommodity", b =>
                {
                    b.HasBaseType("BusinessData.EStatus");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MPCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProductCenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProductLandId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProducterId")
                        .HasColumnType("nvarchar(30)");

                    b.HasIndex("MPCommodityId");

                    b.HasIndex("PCommodityId");

                    b.HasIndex("ProductCenterId");

                    b.HasIndex("ProductLandId");

                    b.HasIndex("ProducterId");

                    b.ToTable("EPCommodity", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofProduct.MPCommodity", b =>
                {
                    b.HasBaseType("BusinessData.MStatus");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProductCenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProductLandId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProducterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SPCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.HasIndex("PCommodityId");

                    b.HasIndex("ProductCenterId");

                    b.HasIndex("ProductLandId");

                    b.HasIndex("ProducterId");

                    b.HasIndex("SPCommodityId");

                    b.ToTable("MPCommodity", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofProduct.PCommodity", b =>
                {
                    b.HasBaseType("BusinessData.Commodity");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProductLandId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProducterId")
                        .HasColumnType("nvarchar(30)");

                    b.HasIndex("ProductCenterId");

                    b.HasIndex("ProductLandId");

                    b.HasIndex("ProducterId");

                    b.ToTable("PCommodity", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofProduct.ProductCenter", b =>
                {
                    b.HasBaseType("BusinessData.Center");

                    b.Property<string>("CenterCards")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CenterIPAddresses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CenterMacAddresses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoprNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("ProductCenter", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofProduct.Producter", b =>
                {
                    b.HasBaseType("BusinessData.Center");

                    b.Property<string>("CenterCards")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CenterIPAddresses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CenterMacAddresses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCenterId")
                        .HasColumnType("nvarchar(30)");

                    b.HasIndex("ProductCenterId");

                    b.ToTable("Producter", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofProduct.SPCommodity", b =>
                {
                    b.HasBaseType("BusinessData.SStatus");

                    b.Property<string>("AnticipatingEndedTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("AnticipatingQuantity")
                        .HasColumnType("real");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTablable")
                        .HasColumnType("bit");

                    b.Property<string>("PCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProductCenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProductLandId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProducterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("StartedTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("PCommodityId");

                    b.HasIndex("ProductCenterId");

                    b.HasIndex("ProductLandId");

                    b.HasIndex("ProducterId");

                    b.ToTable("SPCommodity", (string)null);
                });

            modelBuilder.Entity("BusinessData.Commodity", b =>
                {
                    b.HasOne("BusinessData.Center", "Center")
                        .WithMany("Commodities")
                        .HasForeignKey("CenterId");

                    b.Navigation("Center");
                });

            modelBuilder.Entity("BusinessData.EStatus", b =>
                {
                    b.HasOne("BusinessData.Center", "Center")
                        .WithMany("EStatuses")
                        .HasForeignKey("CenterId");

                    b.HasOne("BusinessData.Commodity", "Commodity")
                        .WithMany("EStatuses")
                        .HasForeignKey("CommodityId");

                    b.HasOne("BusinessData.MStatus", "MStatus")
                        .WithMany("EStatuses")
                        .HasForeignKey("MStatusId");

                    b.Navigation("Center");

                    b.Navigation("Commodity");

                    b.Navigation("MStatus");
                });

            modelBuilder.Entity("BusinessData.MStatus", b =>
                {
                    b.HasOne("BusinessData.Center", "Center")
                        .WithMany("MStatuses")
                        .HasForeignKey("CenterId");

                    b.HasOne("BusinessData.Commodity", "Commodity")
                        .WithMany("MStatuses")
                        .HasForeignKey("CommodityId");

                    b.HasOne("BusinessData.SStatus", "SStatus")
                        .WithMany("MStatuses")
                        .HasForeignKey("SStatusId");

                    b.Navigation("Center");

                    b.Navigation("Commodity");

                    b.Navigation("SStatus");
                });

            modelBuilder.Entity("BusinessData.ofProduct.ProductLand", b =>
                {
                    b.HasOne("BusinessData.ofProduct.ProductCenter", null)
                        .WithMany("ProductLands")
                        .HasForeignKey("ProductCenterId");

                    b.HasOne("BusinessData.ofProduct.Producter", "Producter")
                        .WithMany()
                        .HasForeignKey("ProducterId");

                    b.Navigation("Producter");
                });

            modelBuilder.Entity("BusinessData.SStatus", b =>
                {
                    b.HasOne("BusinessData.Center", "Center")
                        .WithMany("SStatuses")
                        .HasForeignKey("CenterId");

                    b.HasOne("BusinessData.Commodity", "Commodity")
                        .WithMany("SStatuses")
                        .HasForeignKey("CommodityId");

                    b.Navigation("Center");

                    b.Navigation("Commodity");
                });

            modelBuilder.Entity("BusinessData.ofProduct.EPCommodity", b =>
                {
                    b.HasOne("BusinessData.EStatus", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofProduct.EPCommodity", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BusinessData.ofProduct.MPCommodity", "MPCommodity")
                        .WithMany("EPCommodities")
                        .HasForeignKey("MPCommodityId");

                    b.HasOne("BusinessData.ofProduct.PCommodity", "PCommodity")
                        .WithMany("EPCommodities")
                        .HasForeignKey("PCommodityId");

                    b.HasOne("BusinessData.ofProduct.ProductCenter", null)
                        .WithMany("EPCommodities")
                        .HasForeignKey("ProductCenterId");

                    b.HasOne("BusinessData.ofProduct.ProductLand", "ProductLand")
                        .WithMany("EPCommodities")
                        .HasForeignKey("ProductLandId");

                    b.HasOne("BusinessData.ofProduct.Producter", "Producter")
                        .WithMany("EPCommodity")
                        .HasForeignKey("ProducterId");

                    b.Navigation("MPCommodity");

                    b.Navigation("PCommodity");

                    b.Navigation("ProductLand");

                    b.Navigation("Producter");
                });

            modelBuilder.Entity("BusinessData.ofProduct.MPCommodity", b =>
                {
                    b.HasOne("BusinessData.MStatus", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofProduct.MPCommodity", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BusinessData.ofProduct.PCommodity", "PCommodity")
                        .WithMany("MPCommodities")
                        .HasForeignKey("PCommodityId");

                    b.HasOne("BusinessData.ofProduct.ProductCenter", null)
                        .WithMany("MPCommodities")
                        .HasForeignKey("ProductCenterId");

                    b.HasOne("BusinessData.ofProduct.ProductLand", "ProductLand")
                        .WithMany("MPCommodities")
                        .HasForeignKey("ProductLandId");

                    b.HasOne("BusinessData.ofProduct.Producter", "Producter")
                        .WithMany("MPCommodities")
                        .HasForeignKey("ProducterId");

                    b.HasOne("BusinessData.ofProduct.SPCommodity", "SPCommodity")
                        .WithMany("MPCommodities")
                        .HasForeignKey("SPCommodityId");

                    b.Navigation("PCommodity");

                    b.Navigation("ProductLand");

                    b.Navigation("Producter");

                    b.Navigation("SPCommodity");
                });

            modelBuilder.Entity("BusinessData.ofProduct.PCommodity", b =>
                {
                    b.HasOne("BusinessData.Commodity", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofProduct.PCommodity", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BusinessData.ofProduct.ProductCenter", null)
                        .WithMany("PCommodities")
                        .HasForeignKey("ProductCenterId");

                    b.HasOne("BusinessData.ofProduct.ProductLand", "ProductLand")
                        .WithMany("PCommodities")
                        .HasForeignKey("ProductLandId");

                    b.HasOne("BusinessData.ofProduct.Producter", "Producter")
                        .WithMany("PCommodity")
                        .HasForeignKey("ProducterId");

                    b.Navigation("ProductLand");

                    b.Navigation("Producter");
                });

            modelBuilder.Entity("BusinessData.ofProduct.ProductCenter", b =>
                {
                    b.HasOne("BusinessData.Center", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofProduct.ProductCenter", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusinessData.ofProduct.Producter", b =>
                {
                    b.HasOne("BusinessData.Center", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofProduct.Producter", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BusinessData.ofProduct.ProductCenter", "ProductCenter")
                        .WithMany("Producters")
                        .HasForeignKey("ProductCenterId");

                    b.Navigation("ProductCenter");
                });

            modelBuilder.Entity("BusinessData.ofProduct.SPCommodity", b =>
                {
                    b.HasOne("BusinessData.SStatus", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofProduct.SPCommodity", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BusinessData.ofProduct.PCommodity", "PCommodity")
                        .WithMany("SPCommodities")
                        .HasForeignKey("PCommodityId");

                    b.HasOne("BusinessData.ofProduct.ProductCenter", "ProductCenter")
                        .WithMany("SPCommodities")
                        .HasForeignKey("ProductCenterId");

                    b.HasOne("BusinessData.ofProduct.ProductLand", "ProductLand")
                        .WithMany("SPCommodities")
                        .HasForeignKey("ProductLandId");

                    b.HasOne("BusinessData.ofProduct.Producter", "Producter")
                        .WithMany("SPCommodity")
                        .HasForeignKey("ProducterId");

                    b.Navigation("PCommodity");

                    b.Navigation("ProductCenter");

                    b.Navigation("ProductLand");

                    b.Navigation("Producter");
                });

            modelBuilder.Entity("BusinessData.Center", b =>
                {
                    b.Navigation("Commodities");

                    b.Navigation("EStatuses");

                    b.Navigation("MStatuses");

                    b.Navigation("SStatuses");
                });

            modelBuilder.Entity("BusinessData.Commodity", b =>
                {
                    b.Navigation("EStatuses");

                    b.Navigation("MStatuses");

                    b.Navigation("SStatuses");
                });

            modelBuilder.Entity("BusinessData.MStatus", b =>
                {
                    b.Navigation("EStatuses");
                });

            modelBuilder.Entity("BusinessData.ofProduct.ProductLand", b =>
                {
                    b.Navigation("EPCommodities");

                    b.Navigation("MPCommodities");

                    b.Navigation("PCommodities");

                    b.Navigation("SPCommodities");
                });

            modelBuilder.Entity("BusinessData.SStatus", b =>
                {
                    b.Navigation("MStatuses");
                });

            modelBuilder.Entity("BusinessData.ofProduct.MPCommodity", b =>
                {
                    b.Navigation("EPCommodities");
                });

            modelBuilder.Entity("BusinessData.ofProduct.PCommodity", b =>
                {
                    b.Navigation("EPCommodities");

                    b.Navigation("MPCommodities");

                    b.Navigation("SPCommodities");
                });

            modelBuilder.Entity("BusinessData.ofProduct.ProductCenter", b =>
                {
                    b.Navigation("EPCommodities");

                    b.Navigation("MPCommodities");

                    b.Navigation("PCommodities");

                    b.Navigation("ProductLands");

                    b.Navigation("Producters");

                    b.Navigation("SPCommodities");
                });

            modelBuilder.Entity("BusinessData.ofProduct.Producter", b =>
                {
                    b.Navigation("EPCommodity");

                    b.Navigation("MPCommodities");

                    b.Navigation("PCommodity");

                    b.Navigation("SPCommodity");
                });

            modelBuilder.Entity("BusinessData.ofProduct.SPCommodity", b =>
                {
                    b.Navigation("MPCommodities");
                });
#pragma warning restore 612, 618
        }
    }
}
