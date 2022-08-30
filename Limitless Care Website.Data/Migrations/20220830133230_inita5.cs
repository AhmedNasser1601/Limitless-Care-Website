using Microsoft.EntityFrameworkCore.Migrations;

namespace Limitless_Care_Website.Data.Migrations
{
    public partial class inita5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartsId",
                table: "DigitalizationDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DigitalizationDetails_CartsId",
                table: "DigitalizationDetails",
                column: "CartsId");

            migrationBuilder.AddForeignKey(
                name: "FK_DigitalizationDetails_carts_CartsId",
                table: "DigitalizationDetails",
                column: "CartsId",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DigitalizationDetails_carts_CartsId",
                table: "DigitalizationDetails");

            migrationBuilder.DropIndex(
                name: "IX_DigitalizationDetails_CartsId",
                table: "DigitalizationDetails");

            migrationBuilder.DropColumn(
                name: "CartsId",
                table: "DigitalizationDetails");
        }
    }
}
