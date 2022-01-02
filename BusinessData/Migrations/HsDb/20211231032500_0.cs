using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations.HsDb
{
    public partial class _0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
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
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgreetMent",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoutryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.PrimaryKey("PK_AgreetMent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgreetMent_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HsCodePart",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CountryId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.PrimaryKey("PK_HsCodePart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HsCodePart_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubPartofHsCode",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HsCodePartId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.PrimaryKey("PK_SubPartofHsCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubPartofHsCode_HsCodePart_HsCodePartId",
                        column: x => x.HsCodePartId,
                        principalTable: "HsCodePart",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PracticalHsCode",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HsCodePartId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SubPartofHsCodeId = table.Column<string>(type: "nvarchar(30)", nullable: true),
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
                    table.PrimaryKey("PK_PracticalHsCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PracticalHsCode_HsCodePart_HsCodePartId",
                        column: x => x.HsCodePartId,
                        principalTable: "HsCodePart",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PracticalHsCode_SubPartofHsCode_SubPartofHsCodeId",
                        column: x => x.SubPartofHsCodeId,
                        principalTable: "SubPartofHsCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClarnaceInfoofHsCode",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BasicTaxRate = table.Column<int>(type: "int", nullable: false),
                    FVN1 = table.Column<int>(type: "int", nullable: false),
                    FIN1 = table.Column<int>(type: "int", nullable: false),
                    FAS1 = table.Column<int>(type: "int", nullable: false),
                    FUS1 = table.Column<int>(type: "int", nullable: false),
                    FEU1 = table.Column<int>(type: "int", nullable: false),
                    FCN1 = table.Column<int>(type: "int", nullable: false),
                    E1 = table.Column<int>(type: "int", nullable: false),
                    WTO = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ClarnaceInfoofHsCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClarnaceInfoofHsCode_PracticalHsCode_HsCode",
                        column: x => x.HsCode,
                        principalTable: "PracticalHsCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Confirmationbythecustomsofficer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ClassificationofImportAndExport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RelatedLaws = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequirementConfirmationDocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Confirmationbythecustomsofficer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Confirmationbythecustomsofficer_PracticalHsCode_HsCode",
                        column: x => x.HsCode,
                        principalTable: "PracticalHsCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgreetMent_CountryId",
                table: "AgreetMent",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ClarnaceInfoofHsCode_HsCode",
                table: "ClarnaceInfoofHsCode",
                column: "HsCode",
                unique: true,
                filter: "[HsCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Confirmationbythecustomsofficer_HsCode",
                table: "Confirmationbythecustomsofficer",
                column: "HsCode",
                unique: true,
                filter: "[HsCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HsCodePart_CountryId",
                table: "HsCodePart",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticalHsCode_HsCodePartId",
                table: "PracticalHsCode",
                column: "HsCodePartId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticalHsCode_SubPartofHsCodeId",
                table: "PracticalHsCode",
                column: "SubPartofHsCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubPartofHsCode_HsCodePartId",
                table: "SubPartofHsCode",
                column: "HsCodePartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgreetMent");

            migrationBuilder.DropTable(
                name: "ClarnaceInfoofHsCode");

            migrationBuilder.DropTable(
                name: "Confirmationbythecustomsofficer");

            migrationBuilder.DropTable(
                name: "PracticalHsCode");

            migrationBuilder.DropTable(
                name: "SubPartofHsCode");

            migrationBuilder.DropTable(
                name: "HsCodePart");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
