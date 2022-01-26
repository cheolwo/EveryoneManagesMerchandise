using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations.BusinessUserDb
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CoutryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogisticsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JournalSetting",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Credits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalSetting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournalSetting_BusinessUser_BusinessUserId",
                        column: x => x.BusinessUserId,
                        principalTable: "BusinessUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PayService",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DetailServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayService_BusinessUser_BusinessUserId",
                        column: x => x.BusinessUserId,
                        principalTable: "BusinessUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TableSetting",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RelationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagedMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetColumnsSelected = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailColumnsSelected = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableSetting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableSetting_BusinessUser_BusinessUserId",
                        column: x => x.BusinessUserId,
                        principalTable: "BusinessUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_JournalSetting_BusinessUserId",
                table: "JournalSetting",
                column: "BusinessUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PayService_BusinessUserId",
                table: "PayService",
                column: "BusinessUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TableSetting_BusinessUserId",
                table: "TableSetting",
                column: "BusinessUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JournalSetting");

            migrationBuilder.DropTable(
                name: "PayService");

            migrationBuilder.DropTable(
                name: "TableSetting");

            migrationBuilder.DropTable(
                name: "BusinessUser");
        }
    }
}
