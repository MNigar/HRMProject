using Microsoft.EntityFrameworkCore.Migrations;

namespace HRProject.Migrations
{
    public partial class Addedlocalitiestable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocalitiesDTO_Countries_CountryId",
                table: "LocalitiesDTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocalitiesDTO",
                table: "LocalitiesDTO");

            migrationBuilder.RenameTable(
                name: "LocalitiesDTO",
                newName: "Localities");

            migrationBuilder.RenameIndex(
                name: "IX_LocalitiesDTO_CountryId",
                table: "Localities",
                newName: "IX_Localities_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Localities",
                table: "Localities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Localities_Countries_CountryId",
                table: "Localities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Localities_Countries_CountryId",
                table: "Localities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Localities",
                table: "Localities");

            migrationBuilder.RenameTable(
                name: "Localities",
                newName: "LocalitiesDTO");

            migrationBuilder.RenameIndex(
                name: "IX_Localities_CountryId",
                table: "LocalitiesDTO",
                newName: "IX_LocalitiesDTO_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocalitiesDTO",
                table: "LocalitiesDTO",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LocalitiesDTO_Countries_CountryId",
                table: "LocalitiesDTO",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
