using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna.Migrations
{
    public partial class editCateg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Portfolios_PortfolioCategoryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_PortfolioCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PortfolioCategoryId",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PortfolioCategoryId",
                table: "Categories",
                type: "int",
                nullable: true);

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
    }
}
