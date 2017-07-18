using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheRota.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonRoles_Persons_PersonId",
                table: "PersonRoles");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "PersonRoles",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "PersonRoles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonRoles_RoleId",
                table: "PersonRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonRoles_Persons_PersonId",
                table: "PersonRoles",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonRoles_Roles_RoleId",
                table: "PersonRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonRoles_Persons_PersonId",
                table: "PersonRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonRoles_Roles_RoleId",
                table: "PersonRoles");

            migrationBuilder.DropIndex(
                name: "IX_PersonRoles_RoleId",
                table: "PersonRoles");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "PersonRoles",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "PersonRoles",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonRoles_Persons_PersonId",
                table: "PersonRoles",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
