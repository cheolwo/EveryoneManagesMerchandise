using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations.KAptDb
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KAptBasicInfo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Viliage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateofApprovalForUse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberofApt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberofHouseHolds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Managementmethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Housemanager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Managementmanagementmethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Generalmanagementpersonnel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardManagement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numberofparkingspaces = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numberofundergroundparkingspaces = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagementOfficeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagementOfficePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagementOfficeFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WelfareFacility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KAptBasicInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KAptBasicInfo");
        }
    }
}
