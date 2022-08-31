using Microsoft.EntityFrameworkCore.Migrations;

namespace Limitless_Care_Website.Data.Migrations
{
    public partial class inita5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flexibility_carts_cart_id",
                table: "flexibility");

            migrationBuilder.DropIndex(
                name: "IX_flexibility_cart_id",
                table: "flexibility");

            migrationBuilder.AlterColumn<string>(
                name: "Detail",
                table: "flexibility",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartsId",
                table: "flexibility",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_flexibility_CartsId",
                table: "flexibility",
                column: "CartsId");

            migrationBuilder.AddForeignKey(
                name: "FK_flexibility_carts_CartsId",
                table: "flexibility",
                column: "CartsId",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flexibility_carts_CartsId",
                table: "flexibility");

            migrationBuilder.DropIndex(
                name: "IX_flexibility_CartsId",
                table: "flexibility");

            migrationBuilder.DropColumn(
                name: "CartsId",
                table: "flexibility");

            migrationBuilder.AlterColumn<string>(
                name: "Detail",
                table: "flexibility",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_flexibility_cart_id",
                table: "flexibility",
                column: "cart_id");

            migrationBuilder.AddForeignKey(
                name: "FK_flexibility_carts_cart_id",
                table: "flexibility",
                column: "cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
