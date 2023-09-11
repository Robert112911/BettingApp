using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BettingApp.Data.EntriesMigrations
{
    public partial class FirstMigration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cota1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cota2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score1 = table.Column<int>(type: "int", nullable: true),
                    Score2 = table.Column<int>(type: "int", nullable: true),
                    Winner = table.Column<int>(type: "int", nullable: true),
                    Draw = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
