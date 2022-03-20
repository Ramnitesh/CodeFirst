using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproach.Migrations
{
    public partial class PhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                schema: "Company",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HistoryRow",
                schema: "Company",
                columns: table => new
                {
                    Migration_ID = table.Column<string>(nullable: false),
                    ProductVersion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryRow", x => x.Migration_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryRow",
                schema: "Company");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                schema: "Company",
                table: "Users");
        }
    }
}
