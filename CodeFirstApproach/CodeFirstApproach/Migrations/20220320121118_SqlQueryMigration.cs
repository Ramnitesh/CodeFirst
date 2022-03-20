using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproach.Migrations
{
    public partial class SqlQueryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("grant select,insert, update, refrences on schema :: company to dbo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
