using Microsoft.EntityFrameworkCore.Migrations;

namespace GETO_.Migrations
{
    public partial class passwordfieldremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "PlasmaDonor");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "OxyDonator");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "PlasmaDonor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "OxyDonator",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
