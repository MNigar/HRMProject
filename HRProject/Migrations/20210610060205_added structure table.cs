using Microsoft.EntityFrameworkCore.Migrations;

namespace HRProject.Migrations
{
    public partial class addedstructuretable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StructureDTO_StructureTypes_StructureTypeId",
                table: "StructureDTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StructureDTO",
                table: "StructureDTO");

            migrationBuilder.RenameTable(
                name: "StructureDTO",
                newName: "Structures");

            migrationBuilder.RenameIndex(
                name: "IX_StructureDTO_StructureTypeId",
                table: "Structures",
                newName: "IX_Structures_StructureTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Structures",
                table: "Structures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Structures_StructureTypes_StructureTypeId",
                table: "Structures",
                column: "StructureTypeId",
                principalTable: "StructureTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Structures_StructureTypes_StructureTypeId",
                table: "Structures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Structures",
                table: "Structures");

            migrationBuilder.RenameTable(
                name: "Structures",
                newName: "StructureDTO");

            migrationBuilder.RenameIndex(
                name: "IX_Structures_StructureTypeId",
                table: "StructureDTO",
                newName: "IX_StructureDTO_StructureTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StructureDTO",
                table: "StructureDTO",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StructureDTO_StructureTypes_StructureTypeId",
                table: "StructureDTO",
                column: "StructureTypeId",
                principalTable: "StructureTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
