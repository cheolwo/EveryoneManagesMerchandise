using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations.ProductDb
{
    public partial class InitProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Center",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LoginId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FailLogin = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Center", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpponentBusinessUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commodity_Center_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Center",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductCenter",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CoprNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterCards = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterMacAddresses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterIPAddresses = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCenter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCenter_Center_Id",
                        column: x => x.Id,
                        principalTable: "Center",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    CenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SStatus_Center_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Center",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SStatus_Commodity_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Producter",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ProductCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterCards = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterMacAddresses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterIPAddresses = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producter_Center_Id",
                        column: x => x.Id,
                        principalTable: "Center",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Producter_ProductCenter_ProductCenterId",
                        column: x => x.ProductCenterId,
                        principalTable: "ProductCenter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SStatusId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    CenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MStatus_Center_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Center",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MStatus_Commodity_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MStatus_SStatus_SStatusId",
                        column: x => x.SStatusId,
                        principalTable: "SStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductLand",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LandCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaofProductLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaofRestProductLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlantationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaofPlantation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandBookCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProducterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProductCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductLand_ProductCenter_ProductCenterId",
                        column: x => x.ProductCenterId,
                        principalTable: "ProductCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductLand_Producter_ProducterId",
                        column: x => x.ProducterId,
                        principalTable: "Producter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MStatusId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    CenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EStatus_Center_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Center",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EStatus_Commodity_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EStatus_MStatus_MStatusId",
                        column: x => x.MStatusId,
                        principalTable: "MStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductLandId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProducterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProductCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCommodity_Commodity_Id",
                        column: x => x.Id,
                        principalTable: "Commodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PCommodity_ProductCenter_ProductCenterId",
                        column: x => x.ProductCenterId,
                        principalTable: "ProductCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PCommodity_Producter_ProducterId",
                        column: x => x.ProducterId,
                        principalTable: "Producter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PCommodity_ProductLand_ProductLandId",
                        column: x => x.ProductLandId,
                        principalTable: "ProductLand",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SPCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StartedTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnticipatingEndedTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnticipatingQuantity = table.Column<float>(type: "real", nullable: false),
                    IsTablable = table.Column<bool>(type: "bit", nullable: false),
                    PCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProductLandId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProducterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProductCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SPCommodity_PCommodity_PCommodityId",
                        column: x => x.PCommodityId,
                        principalTable: "PCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SPCommodity_ProductCenter_ProductCenterId",
                        column: x => x.ProductCenterId,
                        principalTable: "ProductCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SPCommodity_Producter_ProducterId",
                        column: x => x.ProducterId,
                        principalTable: "Producter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SPCommodity_ProductLand_ProductLandId",
                        column: x => x.ProductLandId,
                        principalTable: "ProductLand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SPCommodity_SStatus_Id",
                        column: x => x.Id,
                        principalTable: "SStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MPCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProductLandId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProducterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SPCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProductCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MPCommodity_MStatus_Id",
                        column: x => x.Id,
                        principalTable: "MStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MPCommodity_PCommodity_PCommodityId",
                        column: x => x.PCommodityId,
                        principalTable: "PCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MPCommodity_ProductCenter_ProductCenterId",
                        column: x => x.ProductCenterId,
                        principalTable: "ProductCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MPCommodity_Producter_ProducterId",
                        column: x => x.ProducterId,
                        principalTable: "Producter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MPCommodity_ProductLand_ProductLandId",
                        column: x => x.ProductLandId,
                        principalTable: "ProductLand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MPCommodity_SPCommodity_SPCommodityId",
                        column: x => x.SPCommodityId,
                        principalTable: "SPCommodity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EPCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProductLandId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProducterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    MPCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProductCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EPCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EPCommodity_EStatus_Id",
                        column: x => x.Id,
                        principalTable: "EStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EPCommodity_MPCommodity_MPCommodityId",
                        column: x => x.MPCommodityId,
                        principalTable: "MPCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EPCommodity_PCommodity_PCommodityId",
                        column: x => x.PCommodityId,
                        principalTable: "PCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EPCommodity_ProductCenter_ProductCenterId",
                        column: x => x.ProductCenterId,
                        principalTable: "ProductCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EPCommodity_Producter_ProducterId",
                        column: x => x.ProducterId,
                        principalTable: "Producter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EPCommodity_ProductLand_ProductLandId",
                        column: x => x.ProductLandId,
                        principalTable: "ProductLand",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CenterId",
                table: "Commodity",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_EPCommodity_MPCommodityId",
                table: "EPCommodity",
                column: "MPCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_EPCommodity_PCommodityId",
                table: "EPCommodity",
                column: "PCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_EPCommodity_ProductCenterId",
                table: "EPCommodity",
                column: "ProductCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_EPCommodity_ProducterId",
                table: "EPCommodity",
                column: "ProducterId");

            migrationBuilder.CreateIndex(
                name: "IX_EPCommodity_ProductLandId",
                table: "EPCommodity",
                column: "ProductLandId");

            migrationBuilder.CreateIndex(
                name: "IX_EStatus_CenterId",
                table: "EStatus",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_EStatus_CommodityId",
                table: "EStatus",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_EStatus_MStatusId",
                table: "EStatus",
                column: "MStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MPCommodity_PCommodityId",
                table: "MPCommodity",
                column: "PCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_MPCommodity_ProductCenterId",
                table: "MPCommodity",
                column: "ProductCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_MPCommodity_ProducterId",
                table: "MPCommodity",
                column: "ProducterId");

            migrationBuilder.CreateIndex(
                name: "IX_MPCommodity_ProductLandId",
                table: "MPCommodity",
                column: "ProductLandId");

            migrationBuilder.CreateIndex(
                name: "IX_MPCommodity_SPCommodityId",
                table: "MPCommodity",
                column: "SPCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_MStatus_CenterId",
                table: "MStatus",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_MStatus_CommodityId",
                table: "MStatus",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_MStatus_SStatusId",
                table: "MStatus",
                column: "SStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PCommodity_ProductCenterId",
                table: "PCommodity",
                column: "ProductCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_PCommodity_ProducterId",
                table: "PCommodity",
                column: "ProducterId");

            migrationBuilder.CreateIndex(
                name: "IX_PCommodity_ProductLandId",
                table: "PCommodity",
                column: "ProductLandId");

            migrationBuilder.CreateIndex(
                name: "IX_Producter_ProductCenterId",
                table: "Producter",
                column: "ProductCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLand_ProductCenterId",
                table: "ProductLand",
                column: "ProductCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLand_ProducterId",
                table: "ProductLand",
                column: "ProducterId");

            migrationBuilder.CreateIndex(
                name: "IX_SPCommodity_PCommodityId",
                table: "SPCommodity",
                column: "PCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_SPCommodity_ProductCenterId",
                table: "SPCommodity",
                column: "ProductCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SPCommodity_ProducterId",
                table: "SPCommodity",
                column: "ProducterId");

            migrationBuilder.CreateIndex(
                name: "IX_SPCommodity_ProductLandId",
                table: "SPCommodity",
                column: "ProductLandId");

            migrationBuilder.CreateIndex(
                name: "IX_SStatus_CenterId",
                table: "SStatus",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SStatus_CommodityId",
                table: "SStatus",
                column: "CommodityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EPCommodity");

            migrationBuilder.DropTable(
                name: "EStatus");

            migrationBuilder.DropTable(
                name: "MPCommodity");

            migrationBuilder.DropTable(
                name: "MStatus");

            migrationBuilder.DropTable(
                name: "SPCommodity");

            migrationBuilder.DropTable(
                name: "PCommodity");

            migrationBuilder.DropTable(
                name: "SStatus");

            migrationBuilder.DropTable(
                name: "ProductLand");

            migrationBuilder.DropTable(
                name: "Commodity");

            migrationBuilder.DropTable(
                name: "Producter");

            migrationBuilder.DropTable(
                name: "ProductCenter");

            migrationBuilder.DropTable(
                name: "Center");
        }
    }
}
