using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ow2LoreCIDM3312FinalProj.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeroLore",
                columns: table => new
                {
                    LoreID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HeroName = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    HeroAge = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<char>(type: "TEXT", nullable: false),
                    Allegiance = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroLore", x => x.LoreID);
                });

            migrationBuilder.CreateTable(
                name: "Playing",
                columns: table => new
                {
                    InGameId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HeroRole = table.Column<string>(type: "TEXT", nullable: false),
                    Weapon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playing", x => x.InGameId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroLore");

            migrationBuilder.DropTable(
                name: "Playing");
        }
    }
}
