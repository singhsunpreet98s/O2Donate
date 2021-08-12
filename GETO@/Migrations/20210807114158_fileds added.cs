using Microsoft.EntityFrameworkCore.Migrations;

namespace GETO_.Migrations
{
    public partial class filedsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "OxyDonator",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "OxyDonator",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "OxyDonator");

            migrationBuilder.DropColumn(
                name: "State",
                table: "OxyDonator");
        }
    }
}
