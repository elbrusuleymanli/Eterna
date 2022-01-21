using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna.Migrations
{
    public partial class AddPortfolioCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PortfolioId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.DropIndex(
                name: "IX_Categories_PortfolioId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
                table: "Categories");
        }
    }
}
