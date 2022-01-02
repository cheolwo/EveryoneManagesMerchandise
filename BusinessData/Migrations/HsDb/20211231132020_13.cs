using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations.HsDb
{
    public partial class _13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClarnaceInfoofHsCode_PracticalHsCode_HsCode",
                table: "ClarnaceInfoofHsCode");

            migrationBuilder.DropForeignKey(
                name: "FK_Confirmationbythecustomsofficer_PracticalHsCode_HsCode",
                table: "Confirmationbythecustomsofficer");

            migrationBuilder.DropForeignKey(
                name: "FK_PracticalHsCode_HsCodePart_HsCodePartId",
                table: "PracticalHsCode");

            migrationBuilder.DropColumn(
                name: "E1",
                table: "ClarnaceInfoofHsCode");

            migrationBuilder.DropColumn(
                name: "FAS1",
                table: "ClarnaceInfoofHsCode");

            migrationBuilder.DropColumn(
                name: "FCN1",
                table: "ClarnaceInfoofHsCode");

            migrationBuilder.DropColumn(
                name: "FEU1",
                table: "ClarnaceInfoofHsCode");

            migrationBuilder.DropColumn(
                name: "FIN1",
                table: "ClarnaceInfoofHsCode");

            migrationBuilder.DropColumn(
                name: "FUS1",
                table: "ClarnaceInfoofHsCode");

            migrationBuilder.DropColumn(
                name: "FVN1",
                table: "ClarnaceInfoofHsCode");

            migrationBuilder.DropColumn(
                name: "WTO",
                table: "ClarnaceInfoofHsCode");

            migrationBuilder.RenameColumn(
                name: "HsCodePartId",
                table: "PracticalHsCode",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_PracticalHsCode_HsCodePartId",
                table: "PracticalHsCode",
                newName: "IX_PracticalHsCode_CountryId");

            migrationBuilder.AddColumn<string>(
                name: "CountryId",
                table: "SubPartofHsCode",
                type: "nvarchar(30)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KoName",
                table: "PracticalHsCode",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AgreetMentTaxRates",
                table: "ClarnaceInfoofHsCode",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DetailPracticalHsCode",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    QuantityUnits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightUnits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PracticalHsCodeId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.PrimaryKey("PK_DetailPracticalHsCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailPracticalHsCode_PracticalHsCode_PracticalHsCodeId",
                        column: x => x.PracticalHsCodeId,
                        principalTable: "PracticalHsCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubPartofHsCode_CountryId",
                table: "SubPartofHsCode",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailPracticalHsCode_PracticalHsCodeId",
                table: "DetailPracticalHsCode",
                column: "PracticalHsCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClarnaceInfoofHsCode_DetailPracticalHsCode_HsCode",
                table: "ClarnaceInfoofHsCode",
                column: "HsCode",
                principalTable: "DetailPracticalHsCode",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Confirmationbythecustomsofficer_DetailPracticalHsCode_HsCode",
                table: "Confirmationbythecustomsofficer",
                column: "HsCode",
                principalTable: "DetailPracticalHsCode",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PracticalHsCode_Country_CountryId",
                table: "PracticalHsCode",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubPartofHsCode_Country_CountryId",
                table: "SubPartofHsCode",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClarnaceInfoofHsCode_DetailPracticalHsCode_HsCode",
                table: "ClarnaceInfoofHsCode");

            migrationBuilder.DropForeignKey(
                name: "FK_Confirmationbythecustomsofficer_DetailPracticalHsCode_HsCode",
                table: "Confirmationbythecustomsofficer");

            migrationBuilder.DropForeignKey(
                name: "FK_PracticalHsCode_Country_CountryId",
                table: "PracticalHsCode");

            migrationBuilder.DropForeignKey(
                name: "FK_SubPartofHsCode_Country_CountryId",
                table: "SubPartofHsCode");

            migrationBuilder.DropTable(
                name: "DetailPracticalHsCode");

            migrationBuilder.DropIndex(
                name: "IX_SubPartofHsCode_CountryId",
                table: "SubPartofHsCode");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "SubPartofHsCode");

            migrationBuilder.DropColumn(
                name: "KoName",
                table: "PracticalHsCode");

            migrationBuilder.DropColumn(
                name: "AgreetMentTaxRates",
                table: "ClarnaceInfoofHsCode");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "PracticalHsCode",
                newName: "HsCodePartId");

            migrationBuilder.RenameIndex(
                name: "IX_PracticalHsCode_CountryId",
                table: "PracticalHsCode",
                newName: "IX_PracticalHsCode_HsCodePartId");

            migrationBuilder.AddColumn<int>(
                name: "E1",
                table: "ClarnaceInfoofHsCode",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FAS1",
                table: "ClarnaceInfoofHsCode",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FCN1",
                table: "ClarnaceInfoofHsCode",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FEU1",
                table: "ClarnaceInfoofHsCode",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FIN1",
                table: "ClarnaceInfoofHsCode",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FUS1",
                table: "ClarnaceInfoofHsCode",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FVN1",
                table: "ClarnaceInfoofHsCode",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WTO",
                table: "ClarnaceInfoofHsCode",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ClarnaceInfoofHsCode_PracticalHsCode_HsCode",
                table: "ClarnaceInfoofHsCode",
                column: "HsCode",
                principalTable: "PracticalHsCode",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Confirmationbythecustomsofficer_PracticalHsCode_HsCode",
                table: "Confirmationbythecustomsofficer",
                column: "HsCode",
                principalTable: "PracticalHsCode",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PracticalHsCode_HsCodePart_HsCodePartId",
                table: "PracticalHsCode",
                column: "HsCodePartId",
                principalTable: "HsCodePart",
                principalColumn: "Id");
        }
    }
}
