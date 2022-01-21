using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna.Migrations
{
    public partial class creatcat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Portfolios_PortfolioId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "PortfolioId",
                table: "Categories",
                newName: "PortfolioCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_PortfolioId",
                table: "Categories",
                newName: "IX_Categories_PortfolioCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Portfolios_PortfolioCategoryId",
                table: "Categories",
                column: "PortfolioCategoryId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Portfolios_PortfolioCategoryId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "PortfolioCategoryId",
                table: "Categories",
                newName: "PortfolioId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_PortfolioCategoryId",
                table: "Categories",
                newName: "IX_Categories_PortfolioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Portfolios_PortfolioId",
                table: "Categories",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
