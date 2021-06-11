using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRProject.Migrations
{
    public partial class addednewcolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "StructureTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "StructureTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Structures",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Structures",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "StaffUnits",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "StaffUnits",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "StaffTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "StaffTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Specialities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Specialities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Skills",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Skills",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "RelationshipTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "RelationshipTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Privileges",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Privileges",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Positions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Positions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationStructures",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationStructures",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "MartialStatuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "MartialStatuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Localities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Localities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Languages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KnowledgeLevels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "KnowledgeLevels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "IssuedOrganizations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "IssuedOrganizations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "EducationLevels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "EducationLevels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "EducationInstitutes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "EducationInstitutes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "DocumentTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "DocumentTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "DismissalTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "DismissalTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Countries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Countries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ContactTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ContactTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Companies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Companies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Branches",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branches",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Transports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transports", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transports");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "WorkTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "WorkTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "StructureTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "StructureTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Structures");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Structures");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "StaffUnits");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "StaffUnits");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "StaffTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "StaffTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Specialities");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Specialities");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "RelationshipTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "RelationshipTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Privileges");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Privileges");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OrganizationStructures");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "OrganizationStructures");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MartialStatuses");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "MartialStatuses");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Localities");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Localities");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KnowledgeLevels");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "KnowledgeLevels");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "IssuedOrganizations");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "IssuedOrganizations");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "EducationLevels");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "EducationLevels");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "EducationInstitutes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "EducationInstitutes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DocumentTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "DocumentTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DismissalTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "DismissalTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ContactTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ContactTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Branches");
        }
    }
}
