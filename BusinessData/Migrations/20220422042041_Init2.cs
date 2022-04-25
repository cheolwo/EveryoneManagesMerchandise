using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessData.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CenterIPAddresses",
                table: "Warehose");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CenterIPAddresses",
                table: "Warehose",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
