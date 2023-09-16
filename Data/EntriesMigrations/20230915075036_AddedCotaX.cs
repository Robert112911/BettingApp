using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BettingApp.Data.EntriesMigrations
{
    public partial class AddedCotaX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CotaX",
                table: "Matches",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CotaX",
                table: "Matches");
        }
    }
}
