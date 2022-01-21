using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Portfolios_PortfolioId",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_PortfolioId",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "Ddate",
                table: "Portfolios",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "PortfolioId",
                table: "Categories",
                newName: "PortCatId");

            migrationBuilder.AddColumn<int>(
                name: "PortfolioCategoryId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_PortfolioCategoryId",
                table: "Categories",
                column: "PortfolioCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Portfolios_PortfolioCategoryId",
                table: "Categories",
                column: "PortfolioCategoryId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Portfolios_PortfolioCategoryId",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_PortfolioCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PortfolioCategoryId",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Portfolios",
                newName: "Ddate");

            migrationBuilder.RenameColumn(
                name: "PortCatId",
                table: "Category",
                newName: "PortfolioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Category_PortfolioId",
                table: "Category",
                column: "PortfolioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Portfolios_PortfolioId",
                table: "Category",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
