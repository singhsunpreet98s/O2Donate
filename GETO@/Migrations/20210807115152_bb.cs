using Microsoft.EntityFrameworkCore.Migrations;

namespace GETO_.Migrations
{
    public partial class bb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "PlasmaDonor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "PlasmaDonor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "PlasmaDonor",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "PlasmaDonor");

            migrationBuilder.DropColumn(
                name: "City",
                table: "PlasmaDonor");

            migrationBuilder.DropColumn(
                name: "State",
                table: "PlasmaDonor");
        }
    }
}
