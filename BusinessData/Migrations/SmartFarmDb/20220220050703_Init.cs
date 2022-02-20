using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessData.Migrations.SmartFarmDb
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpponentBusinessUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EFarmCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    MFarmCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SFarmCommodityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PCommodityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmartFarmId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MStatusId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FarmCommodtiyId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SmartFarmId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        name: "FK_EStatus_Commodity_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EStatus_Commodity_FarmCommodtiyId",
                        column: x => x.FarmCommodtiyId,
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FarmController",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ControllerCommodtiyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmartFarmId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.PrimaryKey("PK_FarmController", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ControllerCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FarmCommodtiyId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ControllerCommodityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ControllerCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControllerCommodity_Commodity_FarmCommodtiyId",
                        column: x => x.FarmCommodtiyId,
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControllerCommodity_FarmController_FarmCommodtiyId",
                        column: x => x.FarmCommodtiyId,
                        principalTable: "FarmController",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EControllerValue",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Temperature = table.Column<float>(type: "real", nullable: false),
                    Humidity = table.Column<float>(type: "real", nullable: false),
                    AirPressure = table.Column<float>(type: "real", nullable: false),
                    WindSpeed = table.Column<float>(type: "real", nullable: false),
                    EFarmCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ControllerCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.PrimaryKey("PK_EControllerValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EControllerValue_ControllerCommodity_ControllerCommodityId",
                        column: x => x.ControllerCommodityId,
                        principalTable: "ControllerCommodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EControllerValue_EStatus_EFarmCommodityId",
                        column: x => x.EFarmCommodityId,
                        principalTable: "EStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SStatusId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FarmCommodtiyId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SmartFarmId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        name: "FK_MStatus_Commodity_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MStatus_Commodity_FarmCommodtiyId",
                        column: x => x.FarmCommodtiyId,
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MControllerValue",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Temperature = table.Column<float>(type: "real", nullable: false),
                    Humidity = table.Column<float>(type: "real", nullable: false),
                    AirPressure = table.Column<float>(type: "real", nullable: false),
                    WindSpeed = table.Column<float>(type: "real", nullable: false),
                    MFarmCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ControllerCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.PrimaryKey("PK_MControllerValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MControllerValue_ControllerCommodity_ControllerCommodityId",
                        column: x => x.ControllerCommodityId,
                        principalTable: "ControllerCommodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MControllerValue_MStatus_MFarmCommodityId",
                        column: x => x.MFarmCommodityId,
                        principalTable: "MStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FarmCommodtiyId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SmartFarmId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                        name: "FK_SStatus_Commodity_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SStatus_Commodity_FarmCommodtiyId",
                        column: x => x.FarmCommodtiyId,
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EFarmCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    FarmCommodtiyId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    FarmControllerId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    MFarmCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SFarmCommodityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductLendId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterMacAddresses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterIPAddresses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Center", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Center_Commodity_FarmCommodtiyId",
                        column: x => x.FarmCommodtiyId,
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Center_EStatus_EFarmCommodityId",
                        column: x => x.EFarmCommodityId,
                        principalTable: "EStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Center_FarmController_FarmControllerId",
                        column: x => x.FarmControllerId,
                        principalTable: "FarmController",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Center_MStatus_MFarmCommodityId",
                        column: x => x.MFarmCommodityId,
                        principalTable: "MStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Center_SStatus_SFarmCommodityId",
                        column: x => x.SFarmCommodityId,
                        principalTable: "SStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SControllerValue",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Temperature = table.Column<float>(type: "real", nullable: false),
                    Humidity = table.Column<float>(type: "real", nullable: false),
                    AirPressure = table.Column<float>(type: "real", nullable: false),
                    WindSpeed = table.Column<float>(type: "real", nullable: false),
                    SFarmCommodityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ControllerCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.PrimaryKey("PK_SControllerValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SControllerValue_ControllerCommodity_ControllerCommodityId",
                        column: x => x.ControllerCommodityId,
                        principalTable: "ControllerCommodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SControllerValue_SStatus_SFarmCommodityId",
                        column: x => x.SFarmCommodityId,
                        principalTable: "SStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Center_EFarmCommodityId",
                table: "Center",
                column: "EFarmCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_FarmCommodtiyId",
                table: "Center",
                column: "FarmCommodtiyId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_FarmControllerId",
                table: "Center",
                column: "FarmControllerId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_MFarmCommodityId",
                table: "Center",
                column: "MFarmCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_SFarmCommodityId",
                table: "Center",
                column: "SFarmCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CenterId",
                table: "Commodity",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_EFarmCommodityId",
                table: "Commodity",
                column: "EFarmCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_MFarmCommodityId",
                table: "Commodity",
                column: "MFarmCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_SFarmCommodityId",
                table: "Commodity",
                column: "SFarmCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_SmartFarmId",
                table: "Commodity",
                column: "SmartFarmId");

            migrationBuilder.CreateIndex(
                name: "IX_ControllerCommodity_FarmCommodtiyId",
                table: "ControllerCommodity",
                column: "FarmCommodtiyId",
                unique: true,
                filter: "[FarmCommodtiyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EControllerValue_ControllerCommodityId",
                table: "EControllerValue",
                column: "ControllerCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_EControllerValue_EFarmCommodityId",
                table: "EControllerValue",
                column: "EFarmCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_EStatus_CenterId",
                table: "EStatus",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_EStatus_CommodityId",
                table: "EStatus",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_EStatus_FarmCommodtiyId",
                table: "EStatus",
                column: "FarmCommodtiyId");

            migrationBuilder.CreateIndex(
                name: "IX_EStatus_MStatusId",
                table: "EStatus",
                column: "MStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EStatus_SmartFarmId",
                table: "EStatus",
                column: "SmartFarmId");

            migrationBuilder.CreateIndex(
                name: "IX_FarmController_SmartFarmId",
                table: "FarmController",
                column: "SmartFarmId");

            migrationBuilder.CreateIndex(
                name: "IX_MControllerValue_ControllerCommodityId",
                table: "MControllerValue",
                column: "ControllerCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_MControllerValue_MFarmCommodityId",
                table: "MControllerValue",
                column: "MFarmCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_MStatus_CenterId",
                table: "MStatus",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_MStatus_CommodityId",
                table: "MStatus",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_MStatus_FarmCommodtiyId",
                table: "MStatus",
                column: "FarmCommodtiyId");

            migrationBuilder.CreateIndex(
                name: "IX_MStatus_SmartFarmId",
                table: "MStatus",
                column: "SmartFarmId");

            migrationBuilder.CreateIndex(
                name: "IX_MStatus_SStatusId",
                table: "MStatus",
                column: "SStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SControllerValue_ControllerCommodityId",
                table: "SControllerValue",
                column: "ControllerCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_SControllerValue_SFarmCommodityId",
                table: "SControllerValue",
                column: "SFarmCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_SStatus_CenterId",
                table: "SStatus",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SStatus_CommodityId",
                table: "SStatus",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_SStatus_FarmCommodtiyId",
                table: "SStatus",
                column: "FarmCommodtiyId");

            migrationBuilder.CreateIndex(
                name: "IX_SStatus_SmartFarmId",
                table: "SStatus",
                column: "SmartFarmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_Center_CenterId",
                table: "Commodity",
                column: "CenterId",
                principalTable: "Center",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_Center_SmartFarmId",
                table: "Commodity",
                column: "SmartFarmId",
                principalTable: "Center",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_EStatus_EFarmCommodityId",
                table: "Commodity",
                column: "EFarmCommodityId",
                principalTable: "EStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_MStatus_MFarmCommodityId",
                table: "Commodity",
                column: "MFarmCommodityId",
                principalTable: "MStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_SStatus_SFarmCommodityId",
                table: "Commodity",
                column: "SFarmCommodityId",
                principalTable: "SStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EStatus_Center_CenterId",
                table: "EStatus",
                column: "CenterId",
                principalTable: "Center",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EStatus_Center_SmartFarmId",
                table: "EStatus",
                column: "SmartFarmId",
                principalTable: "Center",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EStatus_MStatus_MStatusId",
                table: "EStatus",
                column: "MStatusId",
                principalTable: "MStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FarmController_Center_SmartFarmId",
                table: "FarmController",
                column: "SmartFarmId",
                principalTable: "Center",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MStatus_Center_CenterId",
                table: "MStatus",
                column: "CenterId",
                principalTable: "Center",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MStatus_Center_SmartFarmId",
                table: "MStatus",
                column: "SmartFarmId",
                principalTable: "Center",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MStatus_SStatus_SStatusId",
                table: "MStatus",
                column: "SStatusId",
                principalTable: "SStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SStatus_Center_CenterId",
                table: "SStatus",
                column: "CenterId",
                principalTable: "Center",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SStatus_Center_SmartFarmId",
                table: "SStatus",
                column: "SmartFarmId",
                principalTable: "Center",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Center_Commodity_FarmCommodtiyId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_EStatus_Commodity_CommodityId",
                table: "EStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_EStatus_Commodity_FarmCommodtiyId",
                table: "EStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MStatus_Commodity_CommodityId",
                table: "MStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MStatus_Commodity_FarmCommodtiyId",
                table: "MStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_SStatus_Commodity_CommodityId",
                table: "SStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_SStatus_Commodity_FarmCommodtiyId",
                table: "SStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_EStatus_EFarmCommodityId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_FarmController_FarmControllerId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_MStatus_MFarmCommodityId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_SStatus_SFarmCommodityId",
                table: "Center");

            migrationBuilder.DropTable(
                name: "EControllerValue");

            migrationBuilder.DropTable(
                name: "MControllerValue");

            migrationBuilder.DropTable(
                name: "SControllerValue");

            migrationBuilder.DropTable(
                name: "ControllerCommodity");

            migrationBuilder.DropTable(
                name: "Commodity");

            migrationBuilder.DropTable(
                name: "EStatus");

            migrationBuilder.DropTable(
                name: "FarmController");

            migrationBuilder.DropTable(
                name: "MStatus");

            migrationBuilder.DropTable(
                name: "SStatus");

            migrationBuilder.DropTable(
                name: "Center");
        }
    }
}
