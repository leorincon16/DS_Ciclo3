using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TallerMecanica.App.Persistencia.Migrations
{
    public partial class Se : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaIngreso",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaIngreso",
                table: "Cliente");
        }
    }
}
