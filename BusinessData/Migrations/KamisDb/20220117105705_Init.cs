using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations.KamisDb
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KamisCountryAdministrationPart",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KamisCountryAdministrationPart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KamisGrade",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KamisGrade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KamisPart",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KamisPart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KamisMarket",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    KamisCountryAdministrationPartId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KamisMarket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KamisMarket_KamisCountryAdministrationPart_KamisCountryAdministrationPartId",
                        column: x => x.KamisCountryAdministrationPartId,
                        principalTable: "KamisCountryAdministrationPart",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KamisCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    KamisPartId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KamisCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KamisCommodity_KamisPart_KamisPartId",
                        column: x => x.KamisPartId,
                        principalTable: "KamisPart",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KamisKindofCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WholesaleShippingUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WholeSaleShippingUnizSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetailShippingUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetailShippingUnitSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EcoFriendlyAgriculturalProductShippingUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EcoFriendlyAgriculturalProductShippingUnitSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WholeSaleGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetailSaleGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EcoFriendlyGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KamisPartId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    KamisCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KamisKindofCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KamisKindofCommodity_KamisCommodity_KamisCommodityId",
                        column: x => x.KamisCommodityId,
                        principalTable: "KamisCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KamisKindofCommodity_KamisPart_KamisPartId",
                        column: x => x.KamisPartId,
                        principalTable: "KamisPart",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KamisRetailPrice",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    KamisMarketId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    KamisKindofCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    KamisGradeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KamisClsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KamisRetailPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KamisRetailPrice_KamisKindofCommodity_KamisKindofCommodityId",
                        column: x => x.KamisKindofCommodityId,
                        principalTable: "KamisKindofCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KamisRetailPrice_KamisMarket_KamisMarketId",
                        column: x => x.KamisMarketId,
                        principalTable: "KamisMarket",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KamisWholeSalePrice",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    KamisMarketId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    KamisKindofCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    KamisGradeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KamisClsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KamisWholeSalePrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KamisWholeSalePrice_KamisKindofCommodity_KamisKindofCommodityId",
                        column: x => x.KamisKindofCommodityId,
                        principalTable: "KamisKindofCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KamisWholeSalePrice_KamisMarket_KamisMarketId",
                        column: x => x.KamisMarketId,
                        principalTable: "KamisMarket",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_KamisCommodity_KamisPartId",
                table: "KamisCommodity",
                column: "KamisPartId");

            migrationBuilder.CreateIndex(
                name: "IX_KamisKindofCommodity_KamisCommodityId",
                table: "KamisKindofCommodity",
                column: "KamisCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_KamisKindofCommodity_KamisPartId",
                table: "KamisKindofCommodity",
                column: "KamisPartId");

            migrationBuilder.CreateIndex(
                name: "IX_KamisMarket_KamisCountryAdministrationPartId",
                table: "KamisMarket",
                column: "KamisCountryAdministrationPartId");

            migrationBuilder.CreateIndex(
                name: "IX_KamisRetailPrice_KamisKindofCommodityId",
                table: "KamisRetailPrice",
                column: "KamisKindofCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_KamisRetailPrice_KamisMarketId",
                table: "KamisRetailPrice",
                column: "KamisMarketId");

            migrationBuilder.CreateIndex(
                name: "IX_KamisWholeSalePrice_KamisKindofCommodityId",
                table: "KamisWholeSalePrice",
                column: "KamisKindofCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_KamisWholeSalePrice_KamisMarketId",
                table: "KamisWholeSalePrice",
                column: "KamisMarketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KamisGrade");

            migrationBuilder.DropTable(
                name: "KamisRetailPrice");

            migrationBuilder.DropTable(
                name: "KamisWholeSalePrice");

            migrationBuilder.DropTable(
                name: "KamisKindofCommodity");

            migrationBuilder.DropTable(
                name: "KamisMarket");

            migrationBuilder.DropTable(
                name: "KamisCommodity");

            migrationBuilder.DropTable(
                name: "KamisCountryAdministrationPart");

            migrationBuilder.DropTable(
                name: "KamisPart");
        }
    }
}
