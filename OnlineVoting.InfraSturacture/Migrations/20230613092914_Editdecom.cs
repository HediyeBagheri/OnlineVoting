﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineVoting.InfraSturacture.Migrations
{
    public partial class Editdecom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Condidate",
                type: "NVarChar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVarChar(128)",
                oldMaxLength: 128);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Condidate",
                type: "NVarChar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVarChar(64)",
                oldMaxLength: 64);
        }
    }
}