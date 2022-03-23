using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations.WarehouseDb
{
    public partial class Init : Migration
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
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cvv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DividedTagId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DotBarcodeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EWCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    IncomingTagId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadFrameId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MWCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SWCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    WCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    WorkingDeskId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                name: "Warehose",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterMacAddresses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterIPAddresses = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehose", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehose_Center_Id",
                        column: x => x.Id,
                        principalTable: "Center",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DotBarcodes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WarehouseId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DotBarcodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DotBarcodes_Warehose_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehose",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IncomingTags",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SWCommodityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WareohuseId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomingTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncomingTags_Warehose_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehose",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LoadFrames",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WarehouseId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoadFrames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoadFrames_Warehose_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehose",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkingDesks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    WarehouseId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingDesks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkingDesks_Warehose_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehose",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DividedTags",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Attached = table.Column<bool>(type: "bit", nullable: false),
                    IncomingTagId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WarehouseId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DividedTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DividedTags_IncomingTags_IncomingTagId",
                        column: x => x.IncomingTagId,
                        principalTable: "IncomingTags",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DividedTags_Warehose_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehose",
                        principalColumn: "Id");
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
                    EWCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    MWCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SWCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                name: "SStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "WCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PakcingBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<double>(type: "float", nullable: true),
                    height = table.Column<double>(type: "float", nullable: true),
                    length = table.Column<double>(type: "float", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    MCommodityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCommodityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WCommodity_Commodity_Id",
                        column: x => x.Id,
                        principalTable: "Commodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WCommodity_Warehose_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehose",
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
                name: "SWCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IncomingQuantity = table.Column<int>(type: "int", nullable: false),
                    IncomingTagId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    WarehouseId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SWCommodity_SStatus_Id",
                        column: x => x.Id,
                        principalTable: "SStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SWCommodity_Warehose_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehose",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SWCommodity_WCommodity_WCommodityId",
                        column: x => x.WCommodityId,
                        principalTable: "WCommodity",
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

            migrationBuilder.CreateTable(
                name: "MWCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LoadFrameId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SWCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    WCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    WarehouseId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MWCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MWCommodity_LoadFrames_LoadFrameId",
                        column: x => x.LoadFrameId,
                        principalTable: "LoadFrames",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MWCommodity_MStatus_Id",
                        column: x => x.Id,
                        principalTable: "MStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MWCommodity_SWCommodity_SWCommodityId",
                        column: x => x.SWCommodityId,
                        principalTable: "SWCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MWCommodity_Warehose_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehose",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MWCommodity_WCommodity_WCommodityId",
                        column: x => x.WCommodityId,
                        principalTable: "WCommodity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EWCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OutgoingQuantity = table.Column<int>(type: "int", nullable: false),
                    MWCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    WCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    WarehouseId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EWCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EWCommodity_EStatus_Id",
                        column: x => x.Id,
                        principalTable: "EStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EWCommodity_MWCommodity_MWCommodityId",
                        column: x => x.MWCommodityId,
                        principalTable: "MWCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EWCommodity_Warehose_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehose",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EWCommodity_WCommodity_WCommodityId",
                        column: x => x.WCommodityId,
                        principalTable: "WCommodity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Center_DividedTagId",
                table: "Center",
                column: "DividedTagId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_DotBarcodeId",
                table: "Center",
                column: "DotBarcodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_EWCommodityId",
                table: "Center",
                column: "EWCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_IncomingTagId",
                table: "Center",
                column: "IncomingTagId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_LoadFrameId",
                table: "Center",
                column: "LoadFrameId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_MWCommodityId",
                table: "Center",
                column: "MWCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_SWCommodityId",
                table: "Center",
                column: "SWCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_WCommodityId",
                table: "Center",
                column: "WCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_WorkingDeskId",
                table: "Center",
                column: "WorkingDeskId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CenterId",
                table: "Commodity",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_EWCommodityId",
                table: "Commodity",
                column: "EWCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_MWCommodityId",
                table: "Commodity",
                column: "MWCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_SWCommodityId",
                table: "Commodity",
                column: "SWCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_DividedTags_IncomingTagId",
                table: "DividedTags",
                column: "IncomingTagId");

            migrationBuilder.CreateIndex(
                name: "IX_DividedTags_WarehouseId",
                table: "DividedTags",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_DotBarcodes_WarehouseId",
                table: "DotBarcodes",
                column: "WarehouseId");

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
                name: "IX_EWCommodity_MWCommodityId",
                table: "EWCommodity",
                column: "MWCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_EWCommodity_WarehouseId",
                table: "EWCommodity",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_EWCommodity_WCommodityId",
                table: "EWCommodity",
                column: "WCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomingTags_WarehouseId",
                table: "IncomingTags",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadFrames_WarehouseId",
                table: "LoadFrames",
                column: "WarehouseId");

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
                name: "IX_MWCommodity_LoadFrameId",
                table: "MWCommodity",
                column: "LoadFrameId");

            migrationBuilder.CreateIndex(
                name: "IX_MWCommodity_SWCommodityId",
                table: "MWCommodity",
                column: "SWCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_MWCommodity_WarehouseId",
                table: "MWCommodity",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_MWCommodity_WCommodityId",
                table: "MWCommodity",
                column: "WCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_SStatus_CenterId",
                table: "SStatus",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SStatus_CommodityId",
                table: "SStatus",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_SWCommodity_WarehouseId",
                table: "SWCommodity",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_SWCommodity_WCommodityId",
                table: "SWCommodity",
                column: "WCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_WCommodity_WarehouseId",
                table: "WCommodity",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkingDesks_WarehouseId",
                table: "WorkingDesks",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Center_DividedTags_DividedTagId",
                table: "Center",
                column: "DividedTagId",
                principalTable: "DividedTags",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Center_DotBarcodes_DotBarcodeId",
                table: "Center",
                column: "DotBarcodeId",
                principalTable: "DotBarcodes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Center_EWCommodity_EWCommodityId",
                table: "Center",
                column: "EWCommodityId",
                principalTable: "EWCommodity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Center_IncomingTags_IncomingTagId",
                table: "Center",
                column: "IncomingTagId",
                principalTable: "IncomingTags",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Center_LoadFrames_LoadFrameId",
                table: "Center",
                column: "LoadFrameId",
                principalTable: "LoadFrames",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Center_MWCommodity_MWCommodityId",
                table: "Center",
                column: "MWCommodityId",
                principalTable: "MWCommodity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Center_SWCommodity_SWCommodityId",
                table: "Center",
                column: "SWCommodityId",
                principalTable: "SWCommodity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Center_WCommodity_WCommodityId",
                table: "Center",
                column: "WCommodityId",
                principalTable: "WCommodity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Center_WorkingDesks_WorkingDeskId",
                table: "Center",
                column: "WorkingDeskId",
                principalTable: "WorkingDesks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_EWCommodity_EWCommodityId",
                table: "Commodity",
                column: "EWCommodityId",
                principalTable: "EWCommodity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_MWCommodity_MWCommodityId",
                table: "Commodity",
                column: "MWCommodityId",
                principalTable: "MWCommodity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_SWCommodity_SWCommodityId",
                table: "Commodity",
                column: "SWCommodityId",
                principalTable: "SWCommodity",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Center_DividedTags_DividedTagId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_DotBarcodes_DotBarcodeId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_EWCommodity_EWCommodityId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Commodity_EWCommodity_EWCommodityId",
                table: "Commodity");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_IncomingTags_IncomingTagId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_LoadFrames_LoadFrameId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_MWCommodity_LoadFrames_LoadFrameId",
                table: "MWCommodity");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_MWCommodity_MWCommodityId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Commodity_MWCommodity_MWCommodityId",
                table: "Commodity");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_SWCommodity_SWCommodityId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Commodity_SWCommodity_SWCommodityId",
                table: "Commodity");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_WCommodity_WCommodityId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_WorkingDesks_WorkingDeskId",
                table: "Center");

            migrationBuilder.DropTable(
                name: "DividedTags");

            migrationBuilder.DropTable(
                name: "DotBarcodes");

            migrationBuilder.DropTable(
                name: "EWCommodity");

            migrationBuilder.DropTable(
                name: "EStatus");

            migrationBuilder.DropTable(
                name: "IncomingTags");

            migrationBuilder.DropTable(
                name: "LoadFrames");

            migrationBuilder.DropTable(
                name: "MWCommodity");

            migrationBuilder.DropTable(
                name: "MStatus");

            migrationBuilder.DropTable(
                name: "SWCommodity");

            migrationBuilder.DropTable(
                name: "SStatus");

            migrationBuilder.DropTable(
                name: "WCommodity");

            migrationBuilder.DropTable(
                name: "Commodity");

            migrationBuilder.DropTable(
                name: "WorkingDesks");

            migrationBuilder.DropTable(
                name: "Warehose");

            migrationBuilder.DropTable(
                name: "Center");
        }
    }
}
