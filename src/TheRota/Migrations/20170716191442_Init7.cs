using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TheRota.Migrations
{
    public partial class Init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonRoles_Persons_PersonId",
                table: "PersonRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonRoles_Roles_RoleId",
                table: "PersonRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Rotas_Persons_PersonId",
                table: "Rotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Rotas_Roles_RoleId",
                table: "Rotas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonRoles",
                table: "PersonRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Roles",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Persons",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personroles",
                table: "PersonRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_personroles_persons_PersonId",
                table: "PersonRoles",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_personroles_roles_RoleId",
                table: "PersonRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rotas_persons_PersonId",
                table: "Rotas",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rotas_roles_RoleId",
                table: "Rotas",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameIndex(
                name: "IX_PersonRoles_RoleId",
                table: "PersonRoles",
                newName: "IX_personroles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonRoles_PersonId",
                table: "PersonRoles",
                newName: "IX_personroles_PersonId");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "roles");

            migrationBuilder.RenameTable(
                name: "PersonRoles",
                newName: "personroles");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "persons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personroles_persons_PersonId",
                table: "personroles");

            migrationBuilder.DropForeignKey(
                name: "FK_personroles_roles_RoleId",
                table: "personroles");

            migrationBuilder.DropForeignKey(
                name: "FK_Rotas_persons_PersonId",
                table: "Rotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Rotas_roles_RoleId",
                table: "Rotas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_roles",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_personroles",
                table: "personroles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_persons",
                table: "persons");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "roles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "persons");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "roles",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "persons",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "roles",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonRoles",
                table: "personroles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "persons",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonRoles_Persons_PersonId",
                table: "personroles",
                column: "PersonId",
                principalTable: "persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonRoles_Roles_RoleId",
                table: "personroles",
                column: "RoleId",
                principalTable: "roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rotas_Persons_PersonId",
                table: "Rotas",
                column: "PersonId",
                principalTable: "persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rotas_Roles_RoleId",
                table: "Rotas",
                column: "RoleId",
                principalTable: "roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameIndex(
                name: "IX_personroles_RoleId",
                table: "personroles",
                newName: "IX_PersonRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_personroles_PersonId",
                table: "personroles",
                newName: "IX_PersonRoles_PersonId");

            migrationBuilder.RenameTable(
                name: "roles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "personroles",
                newName: "PersonRoles");

            migrationBuilder.RenameTable(
                name: "persons",
                newName: "Persons");
        }
    }
}
