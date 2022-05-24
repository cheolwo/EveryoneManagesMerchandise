using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations.JournalDb
{
    public partial class InitJournal : Migration
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
                name: "JournalCenter",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    b_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    start_dt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_nm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_nm_phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    p_nm2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    b_nm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enus_bnm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePageAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    corp_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxOffice = table.Column<int>(type: "int", nullable: false),
                    b_sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    b_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    invoice_apply_dt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tax_type_change_dt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    utcc_yn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end_dt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tax_type_cd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsValidate = table.Column<bool>(type: "bit", nullable: false),
                    tax_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    b_stt_cd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    b_stt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHead = table.Column<bool>(type: "bit", nullable: false),
                    HeadOfficeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadOfficeBunge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadOfficeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadOfficeFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterCards = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterMacAddresses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterIPAddresses = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalCenter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournalCenter_Center_Id",
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
                name: "JCommodity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CommodityNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Journals = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JournalCenterId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JCommodity_Commodity_Id",
                        column: x => x.Id,
                        principalTable: "Commodity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JCommodity_JournalCenter_JournalCenterId",
                        column: x => x.JournalCenterId,
                        principalTable: "JournalCenter",
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

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CenterId",
                table: "Commodity",
                column: "CenterId");

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
                name: "IX_JCommodity_JournalCenterId",
                table: "JCommodity",
                column: "JournalCenterId");

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
                name: "EStatus");

            migrationBuilder.DropTable(
                name: "JCommodity");

            migrationBuilder.DropTable(
                name: "MStatus");

            migrationBuilder.DropTable(
                name: "JournalCenter");

            migrationBuilder.DropTable(
                name: "SStatus");

            migrationBuilder.DropTable(
                name: "Commodity");

            migrationBuilder.DropTable(
                name: "Center");
        }
    }
}
