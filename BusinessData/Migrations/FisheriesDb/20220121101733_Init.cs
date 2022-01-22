using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations.FisheriesDb
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Copartnership",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Copartnership", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fisheries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CopartnershipId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fisheries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fisheries_Copartnership_CopartnershipId",
                        column: x => x.CopartnershipId,
                        principalTable: "Copartnership",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FishCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CopartnershipId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    FisheriesId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FishCommodity_Copartnership_CopartnershipId",
                        column: x => x.CopartnershipId,
                        principalTable: "Copartnership",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FishCommodity_Fisheries_FisheriesId",
                        column: x => x.FisheriesId,
                        principalTable: "Fisheries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EFishCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FishCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    FisheriesId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EFishCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EFishCommodity_FishCommodity_FishCommodityId",
                        column: x => x.FishCommodityId,
                        principalTable: "FishCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EFishCommodity_Fisheries_FisheriesId",
                        column: x => x.FisheriesId,
                        principalTable: "Fisheries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MFishCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FishCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    FisheriesId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MFishCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MFishCommodity_FishCommodity_FishCommodityId",
                        column: x => x.FishCommodityId,
                        principalTable: "FishCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MFishCommodity_Fisheries_FisheriesId",
                        column: x => x.FisheriesId,
                        principalTable: "Fisheries",
                        principalColumn: "Id");
                });

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
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cvv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EFishCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    FishCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    MFishCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SFishCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    TempId10 = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Center", x => x.Id);
                    table.UniqueConstraint("AK_Center_TempId10", x => x.TempId10);
                    table.ForeignKey(
                        name: "FK_Center_EFishCommodity_EFishCommodityId",
                        column: x => x.EFishCommodityId,
                        principalTable: "EFishCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Center_FishCommodity_FishCommodityId",
                        column: x => x.FishCommodityId,
                        principalTable: "FishCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Center_MFishCommodity_MFishCommodityId",
                        column: x => x.MFishCommodityId,
                        principalTable: "MFishCommodity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Commodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    EFishCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    MFishCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SFishCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Commodity_EFishCommodity_EFishCommodityId",
                        column: x => x.EFishCommodityId,
                        principalTable: "EFishCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Commodity_MFishCommodity_MFishCommodityId",
                        column: x => x.MFishCommodityId,
                        principalTable: "MFishCommodity",
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
                    CenterId = table.Column<string>(type: "nvarchar(30)", nullable: true)
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
                    CenterId = table.Column<string>(type: "nvarchar(30)", nullable: true)
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
                name: "SFishCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FishCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    FisheriesId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SFishCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SFishCommodity_FishCommodity_FishCommodityId",
                        column: x => x.FishCommodityId,
                        principalTable: "FishCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SFishCommodity_Fisheries_FisheriesId",
                        column: x => x.FisheriesId,
                        principalTable: "Fisheries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SFishCommodity_SStatus_Id",
                        column: x => x.Id,
                        principalTable: "SStatus",
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
                    CenterId = table.Column<string>(type: "nvarchar(30)", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_Center_EFishCommodityId",
                table: "Center",
                column: "EFishCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_FishCommodityId",
                table: "Center",
                column: "FishCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_MFishCommodityId",
                table: "Center",
                column: "MFishCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_SFishCommodityId",
                table: "Center",
                column: "SFishCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CenterId",
                table: "Commodity",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_EFishCommodityId",
                table: "Commodity",
                column: "EFishCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_MFishCommodityId",
                table: "Commodity",
                column: "MFishCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_SFishCommodityId",
                table: "Commodity",
                column: "SFishCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_EFishCommodity_FishCommodityId",
                table: "EFishCommodity",
                column: "FishCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_EFishCommodity_FisheriesId",
                table: "EFishCommodity",
                column: "FisheriesId");

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
                name: "IX_FishCommodity_CopartnershipId",
                table: "FishCommodity",
                column: "CopartnershipId");

            migrationBuilder.CreateIndex(
                name: "IX_FishCommodity_FisheriesId",
                table: "FishCommodity",
                column: "FisheriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Fisheries_CopartnershipId",
                table: "Fisheries",
                column: "CopartnershipId");

            migrationBuilder.CreateIndex(
                name: "IX_MFishCommodity_FishCommodityId",
                table: "MFishCommodity",
                column: "FishCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_MFishCommodity_FisheriesId",
                table: "MFishCommodity",
                column: "FisheriesId");

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
                name: "IX_SFishCommodity_FishCommodityId",
                table: "SFishCommodity",
                column: "FishCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_SFishCommodity_FisheriesId",
                table: "SFishCommodity",
                column: "FisheriesId");

            migrationBuilder.CreateIndex(
                name: "IX_SStatus_CenterId",
                table: "SStatus",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SStatus_CommodityId",
                table: "SStatus",
                column: "CommodityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fisheries_Center_Id",
                table: "Fisheries",
                column: "Id",
                principalTable: "Center",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FishCommodity_Commodity_Id",
                table: "FishCommodity",
                column: "Id",
                principalTable: "Commodity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EFishCommodity_EStatus_Id",
                table: "EFishCommodity",
                column: "Id",
                principalTable: "EStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MFishCommodity_MStatus_Id",
                table: "MFishCommodity",
                column: "Id",
                principalTable: "MStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Center_SFishCommodity_SFishCommodityId",
                table: "Center",
                column: "SFishCommodityId",
                principalTable: "SFishCommodity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_SFishCommodity_SFishCommodityId",
                table: "Commodity",
                column: "SFishCommodityId",
                principalTable: "SFishCommodity",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EFishCommodity_EStatus_Id",
                table: "EFishCommodity");

            migrationBuilder.DropForeignKey(
                name: "FK_MFishCommodity_MStatus_Id",
                table: "MFishCommodity");

            migrationBuilder.DropForeignKey(
                name: "FK_SFishCommodity_SStatus_Id",
                table: "SFishCommodity");

            migrationBuilder.DropForeignKey(
                name: "FK_FishCommodity_Commodity_Id",
                table: "FishCommodity");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_EFishCommodity_EFishCommodityId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_MFishCommodity_MFishCommodityId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_SFishCommodity_SFishCommodityId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_FishCommodity_FishCommodityId",
                table: "Center");

            migrationBuilder.DropTable(
                name: "EStatus");

            migrationBuilder.DropTable(
                name: "MStatus");

            migrationBuilder.DropTable(
                name: "SStatus");

            migrationBuilder.DropTable(
                name: "Commodity");

            migrationBuilder.DropTable(
                name: "EFishCommodity");

            migrationBuilder.DropTable(
                name: "MFishCommodity");

            migrationBuilder.DropTable(
                name: "SFishCommodity");

            migrationBuilder.DropTable(
                name: "FishCommodity");

            migrationBuilder.DropTable(
                name: "Fisheries");

            migrationBuilder.DropTable(
                name: "Center");

            migrationBuilder.DropTable(
                name: "Copartnership");
        }
    }
}
