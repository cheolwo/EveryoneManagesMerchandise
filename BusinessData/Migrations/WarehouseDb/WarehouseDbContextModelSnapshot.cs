﻿// <auto-generated />
using System;
using BusinessData.ofWarehouse.ofDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessData.Migrations.WarehouseDb
{
    [DbContext(typeof(WarehouseDbContext))]
    partial class WarehouseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, (int)1L, 1);

            modelBuilder.Entity("BusinessData.Center", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cvv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DividedTagId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DotBarcodeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EWCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("FailLogin")
                        .HasColumnType("int");

                    b.Property<string>("FaxNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncomingTagId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoadFrameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MWCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SWCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("WorkingDeskId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("DividedTagId");

                    b.HasIndex("DotBarcodeId");

                    b.HasIndex("EWCommodityId");

                    b.HasIndex("IncomingTagId");

                    b.HasIndex("LoadFrameId");

                    b.HasIndex("MWCommodityId");

                    b.HasIndex("SWCommodityId");

                    b.HasIndex("WCommodityId");

                    b.HasIndex("WorkingDeskId");

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

                    b.Property<string>("EWCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("HsCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MWCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SWCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("EWCommodityId");

                    b.HasIndex("MWCommodityId");

                    b.HasIndex("SWCommodityId");

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

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.DividedTag", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Attached")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("IncomingTagId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("IncomingTagId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("DividedTags");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.DotBarcode", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("WarehouseId");

                    b.ToTable("DotBarcodes");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.IncomingTag", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SWCommodityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("WareohuseId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("WarehouseId");

                    b.ToTable("IncomingTags");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.LoadFrame", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("WarehouseId");

                    b.ToTable("LoadFrames");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.WorkingDesk", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("WarehouseId");

                    b.ToTable("WorkingDesks");
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

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("CommodityId");

                    b.ToTable("SStatus");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.EWCommodity", b =>
                {
                    b.HasBaseType("BusinessData.EStatus");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MWCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("OutgoingQuantity")
                        .HasColumnType("int");

                    b.Property<string>("WCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(30)");

                    b.HasIndex("MWCommodityId");

                    b.HasIndex("WCommodityId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("EWCommodity", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.MWCommodity", b =>
                {
                    b.HasBaseType("BusinessData.MStatus");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoadFrameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SWCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("WCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(30)");

                    b.HasIndex("LoadFrameId");

                    b.HasIndex("SWCommodityId");

                    b.HasIndex("WCommodityId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("MWCommodity", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.SWCommodity", b =>
                {
                    b.HasBaseType("BusinessData.SStatus");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IncomingQuantity")
                        .HasColumnType("int");

                    b.Property<string>("IncomingTagId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(30)");

                    b.HasIndex("WCommodityId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("SWCommodity", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.Warehouse", b =>
                {
                    b.HasBaseType("BusinessData.Center");

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

                    b.ToTable("Warehose", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.WCommodity", b =>
                {
                    b.HasBaseType("BusinessData.Commodity");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MCommodityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PakcingBarcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("TCommodityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<double?>("Width")
                        .HasColumnType("float");

                    b.Property<double?>("height")
                        .HasColumnType("float");

                    b.Property<double?>("length")
                        .HasColumnType("float");

                    b.HasIndex("WarehouseId");

                    b.ToTable("WCommodity", (string)null);
                });

            modelBuilder.Entity("BusinessData.Center", b =>
                {
                    b.HasOne("BusinessData.ofWarehouse.Model.DividedTag", null)
                        .WithMany("Warehouse")
                        .HasForeignKey("DividedTagId");

                    b.HasOne("BusinessData.ofWarehouse.Model.DotBarcode", null)
                        .WithMany("Warehouse")
                        .HasForeignKey("DotBarcodeId");

                    b.HasOne("BusinessData.ofWarehouse.Model.EWCommodity", null)
                        .WithMany("Warehouse")
                        .HasForeignKey("EWCommodityId");

                    b.HasOne("BusinessData.ofWarehouse.Model.IncomingTag", null)
                        .WithMany("Warehouse")
                        .HasForeignKey("IncomingTagId");

                    b.HasOne("BusinessData.ofWarehouse.Model.LoadFrame", null)
                        .WithMany("Warehouse")
                        .HasForeignKey("LoadFrameId");

                    b.HasOne("BusinessData.ofWarehouse.Model.MWCommodity", null)
                        .WithMany("Warehouse")
                        .HasForeignKey("MWCommodityId");

                    b.HasOne("BusinessData.ofWarehouse.Model.SWCommodity", null)
                        .WithMany("Warehouse")
                        .HasForeignKey("SWCommodityId");

                    b.HasOne("BusinessData.ofWarehouse.Model.WCommodity", null)
                        .WithMany("Warehouse")
                        .HasForeignKey("WCommodityId");

                    b.HasOne("BusinessData.ofWarehouse.Model.WorkingDesk", null)
                        .WithMany("Warehouse")
                        .HasForeignKey("WorkingDeskId");
                });

            modelBuilder.Entity("BusinessData.Commodity", b =>
                {
                    b.HasOne("BusinessData.Center", "Center")
                        .WithMany("Commodities")
                        .HasForeignKey("CenterId");

                    b.HasOne("BusinessData.ofWarehouse.Model.EWCommodity", null)
                        .WithMany("WCommodity")
                        .HasForeignKey("EWCommodityId");

                    b.HasOne("BusinessData.ofWarehouse.Model.MWCommodity", null)
                        .WithMany("WCommodity")
                        .HasForeignKey("MWCommodityId");

                    b.HasOne("BusinessData.ofWarehouse.Model.SWCommodity", null)
                        .WithMany("WCommodity")
                        .HasForeignKey("SWCommodityId");

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

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.DividedTag", b =>
                {
                    b.HasOne("BusinessData.ofWarehouse.Model.IncomingTag", "IncomingTag")
                        .WithMany("DividedTags")
                        .HasForeignKey("IncomingTagId");

                    b.HasOne("BusinessData.ofWarehouse.Model.Warehouse", null)
                        .WithMany("DividedTags")
                        .HasForeignKey("WarehouseId");

                    b.Navigation("IncomingTag");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.DotBarcode", b =>
                {
                    b.HasOne("BusinessData.ofWarehouse.Model.Warehouse", null)
                        .WithMany("DotBarcodes")
                        .HasForeignKey("WarehouseId");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.IncomingTag", b =>
                {
                    b.HasOne("BusinessData.ofWarehouse.Model.Warehouse", null)
                        .WithMany("IncomingTags")
                        .HasForeignKey("WarehouseId");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.LoadFrame", b =>
                {
                    b.HasOne("BusinessData.ofWarehouse.Model.Warehouse", null)
                        .WithMany("LoadFrames")
                        .HasForeignKey("WarehouseId");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.WorkingDesk", b =>
                {
                    b.HasOne("BusinessData.ofWarehouse.Model.Warehouse", null)
                        .WithMany("WorkingDesks")
                        .HasForeignKey("WarehouseId");
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

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.EWCommodity", b =>
                {
                    b.HasOne("BusinessData.EStatus", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofWarehouse.Model.EWCommodity", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BusinessData.ofWarehouse.Model.MWCommodity", "MWCommodity")
                        .WithMany("EWCommodities")
                        .HasForeignKey("MWCommodityId");

                    b.HasOne("BusinessData.ofWarehouse.Model.WCommodity", null)
                        .WithMany("EWCommodities")
                        .HasForeignKey("WCommodityId");

                    b.HasOne("BusinessData.ofWarehouse.Model.Warehouse", null)
                        .WithMany("EWCommodities")
                        .HasForeignKey("WarehouseId");

                    b.Navigation("MWCommodity");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.MWCommodity", b =>
                {
                    b.HasOne("BusinessData.MStatus", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofWarehouse.Model.MWCommodity", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BusinessData.ofWarehouse.Model.LoadFrame", "LoadFrame")
                        .WithMany("MWCommodities")
                        .HasForeignKey("LoadFrameId");

                    b.HasOne("BusinessData.ofWarehouse.Model.SWCommodity", "SWCommodity")
                        .WithMany("MWCommodities")
                        .HasForeignKey("SWCommodityId");

                    b.HasOne("BusinessData.ofWarehouse.Model.WCommodity", null)
                        .WithMany("MWCommodities")
                        .HasForeignKey("WCommodityId");

                    b.HasOne("BusinessData.ofWarehouse.Model.Warehouse", null)
                        .WithMany("MWCommodities")
                        .HasForeignKey("WarehouseId");

                    b.Navigation("LoadFrame");

                    b.Navigation("SWCommodity");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.SWCommodity", b =>
                {
                    b.HasOne("BusinessData.SStatus", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofWarehouse.Model.SWCommodity", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BusinessData.ofWarehouse.Model.WCommodity", null)
                        .WithMany("SWCommodities")
                        .HasForeignKey("WCommodityId");

                    b.HasOne("BusinessData.ofWarehouse.Model.Warehouse", null)
                        .WithMany("SWCommodities")
                        .HasForeignKey("WarehouseId");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.Warehouse", b =>
                {
                    b.HasOne("BusinessData.Center", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofWarehouse.Model.Warehouse", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.WCommodity", b =>
                {
                    b.HasOne("BusinessData.Commodity", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofWarehouse.Model.WCommodity", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BusinessData.ofWarehouse.Model.Warehouse", null)
                        .WithMany("WCommodities")
                        .HasForeignKey("WarehouseId");
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

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.DividedTag", b =>
                {
                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.DotBarcode", b =>
                {
                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.IncomingTag", b =>
                {
                    b.Navigation("DividedTags");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.LoadFrame", b =>
                {
                    b.Navigation("MWCommodities");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.WorkingDesk", b =>
                {
                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("BusinessData.SStatus", b =>
                {
                    b.Navigation("MStatuses");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.EWCommodity", b =>
                {
                    b.Navigation("WCommodity");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.MWCommodity", b =>
                {
                    b.Navigation("EWCommodities");

                    b.Navigation("WCommodity");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.SWCommodity", b =>
                {
                    b.Navigation("MWCommodities");

                    b.Navigation("WCommodity");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.Warehouse", b =>
                {
                    b.Navigation("DividedTags");

                    b.Navigation("DotBarcodes");

                    b.Navigation("EWCommodities");

                    b.Navigation("IncomingTags");

                    b.Navigation("LoadFrames");

                    b.Navigation("MWCommodities");

                    b.Navigation("SWCommodities");

                    b.Navigation("WCommodities");

                    b.Navigation("WorkingDesks");
                });

            modelBuilder.Entity("BusinessData.ofWarehouse.Model.WCommodity", b =>
                {
                    b.Navigation("EWCommodities");

                    b.Navigation("MWCommodities");

                    b.Navigation("SWCommodities");

                    b.Navigation("Warehouse");
                });
#pragma warning restore 612, 618
        }
    }
}