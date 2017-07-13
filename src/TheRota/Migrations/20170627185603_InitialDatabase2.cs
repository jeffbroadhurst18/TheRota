using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheRota.Migrations
{
    public partial class InitialDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stops_Persons_PersonId",
                table: "Stops");

            migrationBuilder.DropForeignKey(
                name: "FK_Rotas_Stops_RoleId",
                table: "Rotas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stops",
                table: "Stops");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Stops",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Persons_PersonId",
                table: "Stops",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rotas_Roles_RoleId",
                table: "Rotas",
                column: "RoleId",
                principalTable: "Stops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameIndex(
                name: "IX_Stops_PersonId",
                table: "Stops",
                newName: "IX_Roles_PersonId");

            migrationBuilder.RenameTable(
                name: "Stops",
                newName: "Roles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Persons_PersonId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Rotas_Roles_RoleId",
                table: "Rotas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stops",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stops_Persons_PersonId",
                table: "Roles",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rotas_Stops_RoleId",
                table: "Rotas",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameIndex(
                name: "IX_Roles_PersonId",
                table: "Roles",
                newName: "IX_Stops_PersonId");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Stops");
        }
    }
}
