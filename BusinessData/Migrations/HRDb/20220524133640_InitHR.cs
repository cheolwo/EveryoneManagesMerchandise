using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations.HRDb
{
    public partial class InitHR : Migration
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpponentBusinessUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "HRCenter",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    JournalCenterId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterCards = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterMacAddresses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterIPAddresses = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HRCenter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HRCenter_Center_Id",
                        column: x => x.Id,
                        principalTable: "Center",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                name: "HRBusinessPart",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PartName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HRCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.PrimaryKey("PK_HRBusinessPart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HRBusinessPart_HRCenter_HRCenterId",
                        column: x => x.HRCenterId,
                        principalTable: "HRCenter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HREmployee",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    InTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HRCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.PrimaryKey("PK_HREmployee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HREmployee_HRCenter_HRCenterId",
                        column: x => x.HRCenterId,
                        principalTable: "HRCenter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HRRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DetailName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HRCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.PrimaryKey("PK_HRRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HRRole_HRCenter_HRCenterId",
                        column: x => x.HRCenterId,
                        principalTable: "HRCenter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SStatusId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                name: "EmployeeRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HRRoleId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    HRBusinessPartId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    HREmployeeId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    HRCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    TempId = table.Column<int>(type: "int", nullable: false),
                    TempId1 = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_EmployeeRole", x => x.Id);
                    table.UniqueConstraint("AK_EmployeeRole_TempId", x => x.TempId);
                    table.UniqueConstraint("AK_EmployeeRole_TempId1", x => x.TempId1);
                    table.ForeignKey(
                        name: "FK_EmployeeRole_HRBusinessPart_HRBusinessPartId",
                        column: x => x.HRBusinessPartId,
                        principalTable: "HRBusinessPart",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeRole_HRCenter_HRCenterId",
                        column: x => x.HRCenterId,
                        principalTable: "HRCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeRole_HREmployee_HREmployeeId",
                        column: x => x.HREmployeeId,
                        principalTable: "HREmployee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeRole_HRRole_HRRoleId",
                        column: x => x.HRRoleId,
                        principalTable: "HRRole",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MStatusId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CenterId",
                table: "Commodity",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRole_HRBusinessPartId",
                table: "EmployeeRole",
                column: "HRBusinessPartId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRole_HRCenterId",
                table: "EmployeeRole",
                column: "HRCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRole_HREmployeeId",
                table: "EmployeeRole",
                column: "HREmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRole_HRRoleId",
                table: "EmployeeRole",
                column: "HRRoleId");

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
                name: "IX_HRBusinessPart_HRCenterId",
                table: "HRBusinessPart",
                column: "HRCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_HREmployee_HRCenterId",
                table: "HREmployee",
                column: "HRCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_HRRole_HRCenterId",
                table: "HRRole",
                column: "HRCenterId");

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
                name: "EmployeeRole");

            migrationBuilder.DropTable(
                name: "EStatus");

            migrationBuilder.DropTable(
                name: "HRBusinessPart");

            migrationBuilder.DropTable(
                name: "HREmployee");

            migrationBuilder.DropTable(
                name: "HRRole");

            migrationBuilder.DropTable(
                name: "MStatus");

            migrationBuilder.DropTable(
                name: "HRCenter");

            migrationBuilder.DropTable(
                name: "SStatus");

            migrationBuilder.DropTable(
                name: "Commodity");

            migrationBuilder.DropTable(
                name: "Center");
        }
    }
}
