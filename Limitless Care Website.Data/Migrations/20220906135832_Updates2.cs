using Microsoft.EntityFrameworkCore.Migrations;

namespace Limitless_Care_Website.Data.Migrations
{
    public partial class Updates2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DigitalizationDetails_digitalizations_Digitalization_ID",
                table: "DigitalizationDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_digitalizations_carts_Cart_id",
                table: "digitalizations");

            migrationBuilder.DropForeignKey(
                name: "FK_flexibility_carts_Cart_id",
                table: "flexibility");

            migrationBuilder.DropForeignKey(
                name: "FK_Providers_carts_Cart_id",
                table: "Providers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Providers",
                table: "Providers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_flexibility",
                table: "flexibility");

            migrationBuilder.DropPrimaryKey(
                name: "PK_digitalizations",
                table: "digitalizations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DigitalizationDetails",
                table: "DigitalizationDetails");

            migrationBuilder.RenameTable(
                name: "Providers",
                newName: "Section3");

            migrationBuilder.RenameTable(
                name: "flexibility",
                newName: "Section2");

            migrationBuilder.RenameTable(
                name: "digitalizations",
                newName: "Section5");

            migrationBuilder.RenameTable(
                name: "DigitalizationDetails",
                newName: "Section5Details");

            migrationBuilder.RenameIndex(
                name: "IX_Providers_Cart_id",
                table: "Section3",
                newName: "IX_Section3_Cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_flexibility_Cart_id",
                table: "Section2",
                newName: "IX_Section2_Cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_digitalizations_Cart_id",
                table: "Section5",
                newName: "IX_Section5_Cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_DigitalizationDetails_Digitalization_ID",
                table: "Section5Details",
                newName: "IX_Section5Details_Digitalization_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section3",
                table: "Section3",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section2",
                table: "Section2",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section5",
                table: "Section5",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section5Details",
                table: "Section5Details",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Section2_carts_Cart_id",
                table: "Section2",
                column: "Cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Section3_carts_Cart_id",
                table: "Section3",
                column: "Cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Section5_carts_Cart_id",
                table: "Section5",
                column: "Cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Section5Details_Section5_Digitalization_ID",
                table: "Section5Details",
                column: "Digitalization_ID",
                principalTable: "Section5",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section2_carts_Cart_id",
                table: "Section2");

            migrationBuilder.DropForeignKey(
                name: "FK_Section3_carts_Cart_id",
                table: "Section3");

            migrationBuilder.DropForeignKey(
                name: "FK_Section5_carts_Cart_id",
                table: "Section5");

            migrationBuilder.DropForeignKey(
                name: "FK_Section5Details_Section5_Digitalization_ID",
                table: "Section5Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section5Details",
                table: "Section5Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section5",
                table: "Section5");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section3",
                table: "Section3");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section2",
                table: "Section2");

            migrationBuilder.RenameTable(
                name: "Section5Details",
                newName: "DigitalizationDetails");

            migrationBuilder.RenameTable(
                name: "Section5",
                newName: "digitalizations");

            migrationBuilder.RenameTable(
                name: "Section3",
                newName: "Providers");

            migrationBuilder.RenameTable(
                name: "Section2",
                newName: "flexibility");

            migrationBuilder.RenameIndex(
                name: "IX_Section5Details_Digitalization_ID",
                table: "DigitalizationDetails",
                newName: "IX_DigitalizationDetails_Digitalization_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Section5_Cart_id",
                table: "digitalizations",
                newName: "IX_digitalizations_Cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_Section3_Cart_id",
                table: "Providers",
                newName: "IX_Providers_Cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_Section2_Cart_id",
                table: "flexibility",
                newName: "IX_flexibility_Cart_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DigitalizationDetails",
                table: "DigitalizationDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_digitalizations",
                table: "digitalizations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Providers",
                table: "Providers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_flexibility",
                table: "flexibility",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DigitalizationDetails_digitalizations_Digitalization_ID",
                table: "DigitalizationDetails",
                column: "Digitalization_ID",
                principalTable: "digitalizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_digitalizations_carts_Cart_id",
                table: "digitalizations",
                column: "Cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_flexibility_carts_Cart_id",
                table: "flexibility",
                column: "Cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Providers_carts_Cart_id",
                table: "Providers",
                column: "Cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
