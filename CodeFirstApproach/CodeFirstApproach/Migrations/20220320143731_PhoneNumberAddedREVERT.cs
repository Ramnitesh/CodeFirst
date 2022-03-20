using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproach.Migrations
{
    public partial class PhoneNumberAddedREVERT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryRow",
                schema: "Company");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoryRow",
                schema: "Company",
                columns: table => new
                {
                    Migration_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductVersion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryRow", x => x.Migration_ID);
                });
        }
    }
}
