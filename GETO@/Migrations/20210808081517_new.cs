using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GETO_.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApiKeyModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    PlasmaAdd = table.Column<bool>(nullable: false),
                    O2Add = table.Column<bool>(nullable: false),
                    GetPlasmaData = table.Column<bool>(nullable: false),
                    AddPlasmaData = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiKeyModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiKeyModel");
        }
    }
}
