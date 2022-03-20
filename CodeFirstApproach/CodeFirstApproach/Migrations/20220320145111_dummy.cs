using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproach.Migrations
{
    public partial class dummy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "__MyEFMigrationsHistory",
                schema: "Company",
                columns: table => new
                {
                    MigrationId = table.Column<string>(nullable: false),
                    ProductVersion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK___MyEFMigrationsHistory", x => x.MigrationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__MyEFMigrationsHistory",
                schema: "Company");
        }
    }
}
