using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineVoting.InfraSturacture.Migrations
{
    public partial class compress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompressName",
                table: "Condidate",
                type: "NVarChar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompressName",
                table: "Condidate");
        }
    }
}
