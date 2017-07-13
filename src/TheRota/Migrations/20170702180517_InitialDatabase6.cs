using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheRota.Migrations
{
    public partial class InitialDatabase6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Persons");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Persons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Persons");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Persons",
                nullable: true);
        }
    }
}
