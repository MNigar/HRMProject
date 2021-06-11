using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRProject.Migrations
{
    public partial class newcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ExcludedDays",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ExcludedDays",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ExcludedDays");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ExcludedDays");
        }
    }
}
