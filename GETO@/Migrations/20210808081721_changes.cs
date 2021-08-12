using Microsoft.EntityFrameworkCore.Migrations;

namespace GETO_.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlasmaAdd",
                table: "ApiKeyModel");

            migrationBuilder.AddColumn<bool>(
                name: "GetO2Data",
                table: "ApiKeyModel",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GetO2Data",
                table: "ApiKeyModel");

            migrationBuilder.AddColumn<bool>(
                name: "PlasmaAdd",
                table: "ApiKeyModel",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
