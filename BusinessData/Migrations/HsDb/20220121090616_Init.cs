using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations.HsDb
{
    public partial class Init : Migration
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
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CountryId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPartofHsCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubPartofHsCode_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
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
                    KoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubPartofHsCodeId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    CountryId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticalHsCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PracticalHsCode_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PracticalHsCode_SubPartofHsCode_SubPartofHsCodeId",
                        column: x => x.SubPartofHsCodeId,
                        principalTable: "SubPartofHsCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubPracticalHsCode",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PracticalHsCodeId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPracticalHsCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubPracticalHsCode_PracticalHsCode_PracticalHsCodeId",
                        column: x => x.PracticalHsCodeId,
                        principalTable: "PracticalHsCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DetailPracticalHsCode",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityUnits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightUnits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubPracticalHsCodeId = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailPracticalHsCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailPracticalHsCode_SubPracticalHsCode_SubPracticalHsCodeId",
                        column: x => x.SubPracticalHsCodeId,
                        principalTable: "SubPracticalHsCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClearanceInfoofHsCode",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BasicTaxRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgreetMentTaxRates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HsCode = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "ConfirmationByTheCustomsOfficer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ClassificationofImportAndExport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RelatedLaws = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequirementConfirmationDocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HsCode = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfirmationByTheCustomsOfficer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfirmationByTheCustomsOfficer_DetailPracticalHsCode_HsCode",
                        column: x => x.HsCode,
                        principalTable: "DetailPracticalHsCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgreetMent_CountryId",
                table: "AgreetMent",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ClearanceInfoofHsCode_HsCode",
                table: "ClearanceInfoofHsCode",
                column: "HsCode",
                unique: true,
                filter: "[HsCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ConfirmationByTheCustomsOfficer_HsCode",
                table: "ConfirmationByTheCustomsOfficer",
                column: "HsCode",
                unique: true,
                filter: "[HsCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailPracticalHsCode_SubPracticalHsCodeId",
                table: "DetailPracticalHsCode",
                column: "SubPracticalHsCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_HsCodePart_CountryId",
                table: "HsCodePart",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticalHsCode_CountryId",
                table: "PracticalHsCode",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticalHsCode_SubPartofHsCodeId",
                table: "PracticalHsCode",
                column: "SubPartofHsCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubPartofHsCode_CountryId",
                table: "SubPartofHsCode",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubPartofHsCode_HsCodePartId",
                table: "SubPartofHsCode",
                column: "HsCodePartId");

            migrationBuilder.CreateIndex(
                name: "IX_SubPracticalHsCode_PracticalHsCodeId",
                table: "SubPracticalHsCode",
                column: "PracticalHsCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgreetMent");

            migrationBuilder.DropTable(
                name: "ClearanceInfoofHsCode");

            migrationBuilder.DropTable(
                name: "ConfirmationByTheCustomsOfficer");

            migrationBuilder.DropTable(
                name: "DetailPracticalHsCode");

            migrationBuilder.DropTable(
                name: "SubPracticalHsCode");

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
