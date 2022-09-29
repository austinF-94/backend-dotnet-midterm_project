using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace midterm_project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dragons",
                columns: table => new
                {
                    DragonId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    dragonName = table.Column<string>(type: "TEXT", nullable: false),
                    dragonImage = table.Column<string>(type: "TEXT", nullable: false),
                    dragonDescription = table.Column<string>(type: "TEXT", nullable: false),
                    dragonDetails = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dragons", x => x.DragonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dragons");
        }
    }
}
