﻿// <auto-generated />
using System;
using BusinessData.ofCommon.ofHsCode.ofDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessData.Migrations.HsDb
{
    [DbContext(typeof(HsDbContext))]
    partial class HsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, (int)1L, 1);

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.AgreetMent", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CoutryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("AgreetMent");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.ClearanceInfoofHsCode", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("AgreetMentTaxRates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BasicTaxRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HsCode")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HsCode")
                        .IsUnique()
                        .HasFilter("[HsCode] IS NOT NULL");

                    b.ToTable("ClearanceInfoofHsCode");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.ConfirmationByTheCustomsOfficer", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("ApplicationEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ApplicationStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassificationofImportAndExport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HsCode")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelatedLaws")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequirementConfirmationDocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HsCode")
                        .IsUnique()
                        .HasFilter("[HsCode] IS NOT NULL");

                    b.ToTable("ConfirmationByTheCustomsOfficer");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.Country", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.DetailPracticalHsCode", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuantityUnits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubPracticalHsCodeId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeightUnits")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SubPracticalHsCodeId");

                    b.ToTable("DetailPracticalHsCode");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.HsCodePart", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("HsCodePart");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.PracticalHsCode", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubPartofHsCodeId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("SubPartofHsCodeId");

                    b.ToTable("PracticalHsCode");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.SubPartofHsCode", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HsCodePartId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("HsCodePartId");

                    b.ToTable("SubPartofHsCode");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.SubPracticalHsCode", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracticalHsCodeId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PracticalHsCodeId");

                    b.ToTable("SubPracticalHsCode");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.AgreetMent", b =>
                {
                    b.HasOne("BusinessData.ofCommon.ofHsCode.Country", null)
                        .WithMany("AgreetMents")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.ClearanceInfoofHsCode", b =>
                {
                    b.HasOne("BusinessData.ofCommon.ofHsCode.DetailPracticalHsCode", "DetailPracticalHsCode")
                        .WithOne("ClearanceInfoofHsCode")
                        .HasForeignKey("BusinessData.ofCommon.ofHsCode.ClearanceInfoofHsCode", "HsCode");

                    b.Navigation("DetailPracticalHsCode");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.ConfirmationByTheCustomsOfficer", b =>
                {
                    b.HasOne("BusinessData.ofCommon.ofHsCode.DetailPracticalHsCode", "DetailPracticalHsCode")
                        .WithOne("Confirmationbythecustomsofficer")
                        .HasForeignKey("BusinessData.ofCommon.ofHsCode.ConfirmationByTheCustomsOfficer", "HsCode");

                    b.Navigation("DetailPracticalHsCode");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.DetailPracticalHsCode", b =>
                {
                    b.HasOne("BusinessData.ofCommon.ofHsCode.SubPracticalHsCode", "SubPracticalHsCode")
                        .WithMany("DetailPracticalHsCodes")
                        .HasForeignKey("SubPracticalHsCodeId");

                    b.Navigation("SubPracticalHsCode");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.HsCodePart", b =>
                {
                    b.HasOne("BusinessData.ofCommon.ofHsCode.Country", null)
                        .WithMany("HsCodePart")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.PracticalHsCode", b =>
                {
                    b.HasOne("BusinessData.ofCommon.ofHsCode.Country", null)
                        .WithMany("PracticalHsCode")
                        .HasForeignKey("CountryId");

                    b.HasOne("BusinessData.ofCommon.ofHsCode.SubPartofHsCode", "SubPartofHsCode")
                        .WithMany("PracticalHsCodes")
                        .HasForeignKey("SubPartofHsCodeId");

                    b.Navigation("SubPartofHsCode");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.SubPartofHsCode", b =>
                {
                    b.HasOne("BusinessData.ofCommon.ofHsCode.Country", null)
                        .WithMany("SubPartofHsCode")
                        .HasForeignKey("CountryId");

                    b.HasOne("BusinessData.ofCommon.ofHsCode.HsCodePart", "HsCodePart")
                        .WithMany("SubPartofHsCodes")
                        .HasForeignKey("HsCodePartId");

                    b.Navigation("HsCodePart");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.SubPracticalHsCode", b =>
                {
                    b.HasOne("BusinessData.ofCommon.ofHsCode.PracticalHsCode", "PracticalHsCode")
                        .WithMany("SubPracticalHsCodes")
                        .HasForeignKey("PracticalHsCodeId");

                    b.Navigation("PracticalHsCode");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.Country", b =>
                {
                    b.Navigation("AgreetMents");

                    b.Navigation("HsCodePart");

                    b.Navigation("PracticalHsCode");

                    b.Navigation("SubPartofHsCode");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.DetailPracticalHsCode", b =>
                {
                    b.Navigation("ClearanceInfoofHsCode");

                    b.Navigation("Confirmationbythecustomsofficer");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.HsCodePart", b =>
                {
                    b.Navigation("SubPartofHsCodes");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.PracticalHsCode", b =>
                {
                    b.Navigation("SubPracticalHsCodes");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.SubPartofHsCode", b =>
                {
                    b.Navigation("PracticalHsCodes");
                });

            modelBuilder.Entity("BusinessData.ofCommon.ofHsCode.SubPracticalHsCode", b =>
                {
                    b.Navigation("DetailPracticalHsCodes");
                });
#pragma warning restore 612, 618
        }
    }
}
