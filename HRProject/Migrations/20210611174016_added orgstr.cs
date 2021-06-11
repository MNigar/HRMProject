using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRProject.Migrations
{
    public partial class addedorgstr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrganizationStructures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganizationStructureId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StructureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationStructures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationStructures_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizationStructures_Branches_ParentBranchId",
                        column: x => x.ParentBranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganizationStructures_OrganizationStructures_OrganizationStructureId",
                        column: x => x.OrganizationStructureId,
                        principalTable: "OrganizationStructures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganizationStructures_Structures_StructureId",
                        column: x => x.StructureId,
                        principalTable: "Structures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaffTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VacationDayLimit = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganizationStructureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NeedCount = table.Column<int>(type: "int", nullable: true),
                    SalaryMin = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SalaryMax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OrderNum = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffUnits_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StaffUnits_StaffTypes_StaffTypeId",
                        column: x => x.StaffTypeId,
                        principalTable: "StaffTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationStructures_BranchId",
                table: "OrganizationStructures",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationStructures_OrganizationStructureId",
                table: "OrganizationStructures",
                column: "OrganizationStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationStructures_ParentBranchId",
                table: "OrganizationStructures",
                column: "ParentBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationStructures_StructureId",
                table: "OrganizationStructures",
                column: "StructureId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffUnits_BranchId",
                table: "StaffUnits",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffUnits_StaffTypeId",
                table: "StaffUnits",
                column: "StaffTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizationStructures");

            migrationBuilder.DropTable(
                name: "StaffUnits");

            migrationBuilder.DropTable(
                name: "StaffTypes");
        }
    }
}
