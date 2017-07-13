using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TheRota.Migrations
{
    public partial class InitialDatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Persons_PersonId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_PersonId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Roles");

            migrationBuilder.CreateTable(
                name: "PersonRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonRole_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonRole_PersonId",
                table: "PersonRole",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonRole");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Roles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_PersonId",
                table: "Roles",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Persons_PersonId",
                table: "Roles",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
