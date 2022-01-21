using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna.Migrations
{
    public partial class categor : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "PortfolioId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_PortfolioId",
                table: "Categories",
                column: "PortfolioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Portfolios_PortfolioId",
                table: "Categories",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Portfolios_PortfolioId",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_PortfolioId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
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
