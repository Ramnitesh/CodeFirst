using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproach.Migrations
{
    public partial class HistoryTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("select * into [Company].[__EFMigrationsHistory] from [dbo].[__EFMigrationsHistory]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
