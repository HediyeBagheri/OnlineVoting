using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineVoting.InfraSturacture.Migrations
{
    public partial class decompress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "CompressName",
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
                name: "CompressName",
                table: "Condidate",
                type: "NVarChar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "NVarChar(64)",
                oldMaxLength: 64);
        }
    }
}
