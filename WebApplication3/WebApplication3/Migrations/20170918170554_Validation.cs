using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication3.Migrations
{
    public partial class Validation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Album",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Album",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);
        }
    }
}
