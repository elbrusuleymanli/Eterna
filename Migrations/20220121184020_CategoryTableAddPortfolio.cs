using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna.Migrations
{
    public partial class CategoryTableAddPortfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Portfolioimages_PortfolioimageId",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_PortfolioimageId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "PortfolioimageId",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.AddColumn<int>(
                name: "PortfolioimageId",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Category_PortfolioimageId",
                table: "Category",
                column: "PortfolioimageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Portfolioimages_PortfolioimageId",
                table: "Category",
                column: "PortfolioimageId",
                principalTable: "Portfolioimages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
