using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgameAnalytics.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsGeologist = table.Column<bool>(type: "bit", nullable: false),
                    IsEngineer = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmiral = table.Column<bool>(type: "bit", nullable: false),
                    IsTechnocrat = table.Column<bool>(type: "bit", nullable: false),
                    IsCommander = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
