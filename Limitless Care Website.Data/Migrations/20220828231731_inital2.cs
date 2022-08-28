using Microsoft.EntityFrameworkCore.Migrations;

namespace Limitless_Care_Website.Data.Migrations
{
    public partial class inital2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerStatisfaction",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Digitalization_ID",
                table: "carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Flexibility_ID",
                table: "carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Providers_ID",
                table: "carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_carts_Digitalization_ID",
                table: "carts",
                column: "Digitalization_ID");

            migrationBuilder.CreateIndex(
                name: "IX_carts_Flexibility_ID",
                table: "carts",
                column: "Flexibility_ID");

            migrationBuilder.CreateIndex(
                name: "IX_carts_Providers_ID",
                table: "carts",
                column: "Providers_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_digitalizations_Digitalization_ID",
                table: "carts",
                column: "Digitalization_ID",
                principalTable: "digitalizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_carts_flexibility_Flexibility_ID",
                table: "carts",
                column: "Flexibility_ID",
                principalTable: "flexibility",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_carts_Providers_Providers_ID",
                table: "carts",
                column: "Providers_ID",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_digitalizations_Digitalization_ID",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK_carts_flexibility_Flexibility_ID",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK_carts_Providers_Providers_ID",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_carts_Digitalization_ID",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_carts_Flexibility_ID",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_carts_Providers_ID",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "CustomerStatisfaction",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "Digitalization_ID",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "Flexibility_ID",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "Providers_ID",
                table: "carts");
        }
    }
}
