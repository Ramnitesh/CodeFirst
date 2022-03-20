using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproach.Migrations
{
    public partial class dummy1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK___MyEFMigrationsHistory",
                schema: "Company",
                table: "__MyEFMigrationsHistory");

            migrationBuilder.DropColumn(
                name: "CountryCode",
                schema: "Company",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "__MyEFMigrationsHistory",
                schema: "Company",
                newName: "__EFMigrationsHistory",
                newSchema: "Company");

            migrationBuilder.AddPrimaryKey(
                name: "PK___EFMigrationsHistory",
                schema: "Company",
                table: "__EFMigrationsHistory",
                column: "MigrationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK___EFMigrationsHistory",
                schema: "Company",
                table: "__EFMigrationsHistory");

            migrationBuilder.RenameTable(
                name: "__EFMigrationsHistory",
                schema: "Company",
                newName: "__MyEFMigrationsHistory",
                newSchema: "Company");

            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                schema: "Company",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK___MyEFMigrationsHistory",
                schema: "Company",
                table: "__MyEFMigrationsHistory",
                column: "MigrationId");
        }
    }
}
