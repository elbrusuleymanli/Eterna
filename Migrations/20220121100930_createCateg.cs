using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna.Migrations
{
    public partial class createCateg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PortCatId",
                table: "Categories",
                newName: "ImageId");

            migrationBuilder.AddColumn<int>(
                name: "PortfolioimageId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_PortfolioimageId",
                table: "Categories",
                column: "PortfolioimageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Portfolioimages_PortfolioimageId",
                table: "Categories",
                column: "PortfolioimageId",
                principalTable: "Portfolioimages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Portfolioimages_PortfolioimageId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_PortfolioimageId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PortfolioimageId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "Categories",
                newName: "PortCatId");
        }
    }
}
