using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations.HsDb
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Confirmationbythecustomsofficer_DetailPracticalHsCode_HsCode",
                table: "Confirmationbythecustomsofficer");

            migrationBuilder.DropTable(
                name: "ClarnaceInfoofHsCode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Confirmationbythecustomsofficer",
                table: "Confirmationbythecustomsofficer");

            migrationBuilder.RenameTable(
                name: "Confirmationbythecustomsofficer",
                newName: "ConfirmationByTheCustomsOfficer");

            migrationBuilder.RenameIndex(
                name: "IX_Confirmationbythecustomsofficer_HsCode",
                table: "ConfirmationByTheCustomsOfficer",
                newName: "IX_ConfirmationByTheCustomsOfficer_HsCode");

            migrationBuilder.AddColumn<string>(
                name: "KoName",
                table: "DetailPracticalHsCode",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsName",
                table: "DetailPracticalHsCode",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConfirmationByTheCustomsOfficer",
                table: "ConfirmationByTheCustomsOfficer",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ClearanceInfoofHsCode",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BasicTaxRate = table.Column<int>(type: "int", nullable: false),
                    AgreetMentTaxRates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HsCode = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.PrimaryKey("PK_ClearanceInfoofHsCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClearanceInfoofHsCode_DetailPracticalHsCode_HsCode",
                        column: x => x.HsCode,
                        principalTable: "DetailPracticalHsCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClearanceInfoofHsCode_HsCode",
                table: "ClearanceInfoofHsCode",
                column: "HsCode",
                unique: true,
                filter: "[HsCode] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfirmationByTheCustomsOfficer_DetailPracticalHsCode_HsCode",
                table: "ConfirmationByTheCustomsOfficer",
                column: "HsCode",
                principalTable: "DetailPracticalHsCode",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfirmationByTheCustomsOfficer_DetailPracticalHsCode_HsCode",
                table: "ConfirmationByTheCustomsOfficer");

            migrationBuilder.DropTable(
                name: "ClearanceInfoofHsCode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConfirmationByTheCustomsOfficer",
                table: "ConfirmationByTheCustomsOfficer");

            migrationBuilder.DropColumn(
                name: "KoName",
                table: "DetailPracticalHsCode");

            migrationBuilder.DropColumn(
                name: "UsName",
                table: "DetailPracticalHsCode");

            migrationBuilder.RenameTable(
                name: "ConfirmationByTheCustomsOfficer",
                newName: "Confirmationbythecustomsofficer");

            migrationBuilder.RenameIndex(
                name: "IX_ConfirmationByTheCustomsOfficer_HsCode",
                table: "Confirmationbythecustomsofficer",
                newName: "IX_Confirmationbythecustomsofficer_HsCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Confirmationbythecustomsofficer",
                table: "Confirmationbythecustomsofficer",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ClarnaceInfoofHsCode",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HsCode = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    AgreetMentTaxRates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicTaxRate = table.Column<int>(type: "int", nullable: false),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClarnaceInfoofHsCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClarnaceInfoofHsCode_DetailPracticalHsCode_HsCode",
                        column: x => x.HsCode,
                        principalTable: "DetailPracticalHsCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClarnaceInfoofHsCode_HsCode",
                table: "ClarnaceInfoofHsCode",
                column: "HsCode",
                unique: true,
                filter: "[HsCode] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Confirmationbythecustomsofficer_DetailPracticalHsCode_HsCode",
                table: "Confirmationbythecustomsofficer",
                column: "HsCode",
                principalTable: "DetailPracticalHsCode",
                principalColumn: "Id");
        }
    }
}
