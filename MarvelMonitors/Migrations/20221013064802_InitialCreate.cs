using Microsoft.EntityFrameworkCore.Migrations;

namespace MarvelMonitors.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monitor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(nullable: true),
                    PanelTechnology = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    ScreenSize = table.Column<string>(nullable: true),
                    RefreshRate = table.Column<string>(nullable: true),
                    Resolution = table.Column<string>(nullable: true),
                    Features = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitor", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monitor");
        }
    }
}
