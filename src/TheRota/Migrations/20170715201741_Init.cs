using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheRota.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonRole_Persons_PersonId",
                table: "PersonRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonRole",
                table: "PersonRole");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "PersonRole",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonRoles",
                table: "PersonRole",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonRoles_Persons_PersonId",
                table: "PersonRole",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameIndex(
                name: "IX_PersonRole_PersonId",
                table: "PersonRole",
                newName: "IX_PersonRoles_PersonId");

            migrationBuilder.RenameTable(
                name: "PersonRole",
                newName: "PersonRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonRoles_Persons_PersonId",
                table: "PersonRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonRoles",
                table: "PersonRoles");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "PersonRoles",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonRole",
                table: "PersonRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonRole_Persons_PersonId",
                table: "PersonRoles",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameIndex(
                name: "IX_PersonRoles_PersonId",
                table: "PersonRoles",
                newName: "IX_PersonRole_PersonId");

            migrationBuilder.RenameTable(
                name: "PersonRoles",
                newName: "PersonRole");
        }
    }
}
