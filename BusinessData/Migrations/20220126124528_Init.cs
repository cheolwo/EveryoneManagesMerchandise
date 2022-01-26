using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderCenter",
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
                    table.PrimaryKey("PK_OrderCenter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OCommodity_OrderCenter_OrderCenterId",
                        column: x => x.OrderCenterId,
                        principalTable: "OrderCenter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SOCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QualityTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Incorterms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    OrderCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SOCommodity_OCommodity_OCommodityId",
                        column: x => x.OCommodityId,
                        principalTable: "OCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SOCommodity_OrderCenter_OrderCenterId",
                        column: x => x.OrderCenterId,
                        principalTable: "OrderCenter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MOCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SOCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    OCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    OrderCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MOCommodity_OCommodity_OCommodityId",
                        column: x => x.OCommodityId,
                        principalTable: "OCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MOCommodity_OrderCenter_OrderCenterId",
                        column: x => x.OrderCenterId,
                        principalTable: "OrderCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MOCommodity_SOCommodity_SOCommodityId",
                        column: x => x.SOCommodityId,
                        principalTable: "SOCommodity",
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
                    EOCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    MOCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    OCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SOCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                        name: "FK_Center_MOCommodity_MOCommodityId",
                        column: x => x.MOCommodityId,
                        principalTable: "MOCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Center_OCommodity_OCommodityId",
                        column: x => x.OCommodityId,
                        principalTable: "OCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Center_SOCommodity_SOCommodityId",
                        column: x => x.SOCommodityId,
                        principalTable: "SOCommodity",
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
                    EOCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    MOCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SOCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                        name: "FK_Commodity_MOCommodity_MOCommodityId",
                        column: x => x.MOCommodityId,
                        principalTable: "MOCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Commodity_SOCommodity_SOCommodityId",
                        column: x => x.SOCommodityId,
                        principalTable: "SOCommodity",
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
                name: "EOCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OutgoingQuantity = table.Column<int>(type: "int", nullable: false),
                    MOCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    OCommodityId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    OrderCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EOCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EOCommodity_EStatus_Id",
                        column: x => x.Id,
                        principalTable: "EStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EOCommodity_MOCommodity_MOCommodityId",
                        column: x => x.MOCommodityId,
                        principalTable: "MOCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EOCommodity_OCommodity_OCommodityId",
                        column: x => x.OCommodityId,
                        principalTable: "OCommodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EOCommodity_OrderCenter_OrderCenterId",
                        column: x => x.OrderCenterId,
                        principalTable: "OrderCenter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Center_EOCommodityId",
                table: "Center",
                column: "EOCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_MOCommodityId",
                table: "Center",
                column: "MOCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_OCommodityId",
                table: "Center",
                column: "OCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_SOCommodityId",
                table: "Center",
                column: "SOCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CenterId",
                table: "Commodity",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_EOCommodityId",
                table: "Commodity",
                column: "EOCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_MOCommodityId",
                table: "Commodity",
                column: "MOCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_SOCommodityId",
                table: "Commodity",
                column: "SOCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_EOCommodity_MOCommodityId",
                table: "EOCommodity",
                column: "MOCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_EOCommodity_OCommodityId",
                table: "EOCommodity",
                column: "OCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_EOCommodity_OrderCenterId",
                table: "EOCommodity",
                column: "OrderCenterId");

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
                name: "IX_MOCommodity_OCommodityId",
                table: "MOCommodity",
                column: "OCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_MOCommodity_OrderCenterId",
                table: "MOCommodity",
                column: "OrderCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_MOCommodity_SOCommodityId",
                table: "MOCommodity",
                column: "SOCommodityId");

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
                name: "IX_OCommodity_OrderCenterId",
                table: "OCommodity",
                column: "OrderCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SOCommodity_OCommodityId",
                table: "SOCommodity",
                column: "OCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_SOCommodity_OrderCenterId",
                table: "SOCommodity",
                column: "OrderCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SStatus_CenterId",
                table: "SStatus",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SStatus_CommodityId",
                table: "SStatus",
                column: "CommodityId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderCenter_Center_Id",
                table: "OrderCenter",
                column: "Id",
                principalTable: "Center",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OCommodity_Commodity_Id",
                table: "OCommodity",
                column: "Id",
                principalTable: "Commodity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SOCommodity_SStatus_Id",
                table: "SOCommodity",
                column: "Id",
                principalTable: "SStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MOCommodity_MStatus_Id",
                table: "MOCommodity",
                column: "Id",
                principalTable: "MStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Center_EOCommodity_EOCommodityId",
                table: "Center",
                column: "EOCommodityId",
                principalTable: "EOCommodity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_EOCommodity_EOCommodityId",
                table: "Commodity",
                column: "EOCommodityId",
                principalTable: "EOCommodity",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EOCommodity_EStatus_Id",
                table: "EOCommodity");

            migrationBuilder.DropForeignKey(
                name: "FK_MOCommodity_MStatus_Id",
                table: "MOCommodity");

            migrationBuilder.DropForeignKey(
                name: "FK_SOCommodity_SStatus_Id",
                table: "SOCommodity");

            migrationBuilder.DropForeignKey(
                name: "FK_OCommodity_Commodity_Id",
                table: "OCommodity");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_EOCommodity_EOCommodityId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_MOCommodity_MOCommodityId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_SOCommodity_SOCommodityId",
                table: "Center");

            migrationBuilder.DropForeignKey(
                name: "FK_Center_OCommodity_OCommodityId",
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
                name: "EOCommodity");

            migrationBuilder.DropTable(
                name: "MOCommodity");

            migrationBuilder.DropTable(
                name: "SOCommodity");

            migrationBuilder.DropTable(
                name: "OCommodity");

            migrationBuilder.DropTable(
                name: "OrderCenter");

            migrationBuilder.DropTable(
                name: "Center");
        }
    }
}
