using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMOproject.Data.Migrations
{
    public partial class createNewDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManufacturerList",
                columns: table => new
                {
                    CodeMan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturerList", x => x.CodeMan);
                });

            migrationBuilder.CreateTable(
                name: "MembersList",
                columns: table => new
                {
                    CodeMem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ill = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Recovery = table.Column<DateTime>(type: "datetime2", nullable: true),
                    countVac = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembersList", x => x.CodeMem);
                });

            migrationBuilder.CreateTable(
                name: "VaccinationList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfVaccination = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManufacturerCodeMan = table.Column<int>(type: "int", nullable: true),
                    CodeMan = table.Column<int>(type: "int", nullable: false),
                    MembersCodeMem = table.Column<int>(type: "int", nullable: true),
                    CodeMem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VaccinationList_ManufacturerList_ManufacturerCodeMan",
                        column: x => x.ManufacturerCodeMan,
                        principalTable: "ManufacturerList",
                        principalColumn: "CodeMan");
                    table.ForeignKey(
                        name: "FK_VaccinationList_MembersList_MembersCodeMem",
                        column: x => x.MembersCodeMem,
                        principalTable: "MembersList",
                        principalColumn: "CodeMem");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationList_ManufacturerCodeMan",
                table: "VaccinationList",
                column: "ManufacturerCodeMan");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationList_MembersCodeMem",
                table: "VaccinationList",
                column: "MembersCodeMem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VaccinationList");

            migrationBuilder.DropTable(
                name: "ManufacturerList");

            migrationBuilder.DropTable(
                name: "MembersList");
        }
    }
}
