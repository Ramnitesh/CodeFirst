using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproach.Migrations
{
    public partial class UpdatedTableUsersBuilder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Company");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Users",
                newSchema: "Company");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Company",
                table: "Users",
                type: "ntext",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_Customers",
                schema: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CustomerName = table.Column<string>(maxLength: 50, nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Customers_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Company",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Customers_UserId",
                schema: "Company",
                table: "Tbl_Customers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Customers",
                schema: "Company");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "Company",
                newName: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldMaxLength: 20,
                oldNullable: true);
        }
    }
}
