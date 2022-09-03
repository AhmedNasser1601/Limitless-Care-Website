using Microsoft.EntityFrameworkCore.Migrations;

namespace Limitless_Care_Website.Data.Migrations
{
    public partial class intial12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_digitalizations_carts_cart_id",
                table: "digitalizations");

            migrationBuilder.DropForeignKey(
                name: "FK_flexibility_carts_cart_id",
                table: "flexibility");

            migrationBuilder.DropForeignKey(
                name: "FK_inPatients_carts_cart_id",
                table: "inPatients");

            migrationBuilder.DropForeignKey(
                name: "FK_Others_carts_cart_id",
                table: "Others");

            migrationBuilder.DropForeignKey(
                name: "FK_outPatients_carts_cart_id",
                table: "outPatients");

            migrationBuilder.DropForeignKey(
                name: "FK_Providers_carts_cart_id",
                table: "Providers");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecialBenefits_carts_cart_id",
                table: "SpecialBenefits");

            migrationBuilder.RenameColumn(
                name: "cart_id",
                table: "SpecialBenefits",
                newName: "Cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_SpecialBenefits_cart_id",
                table: "SpecialBenefits",
                newName: "IX_SpecialBenefits_Cart_id");

            migrationBuilder.RenameColumn(
                name: "cart_id",
                table: "Providers",
                newName: "Cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_Providers_cart_id",
                table: "Providers",
                newName: "IX_Providers_Cart_id");

            migrationBuilder.RenameColumn(
                name: "cart_id",
                table: "outPatients",
                newName: "Cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_outPatients_cart_id",
                table: "outPatients",
                newName: "IX_outPatients_Cart_id");

            migrationBuilder.RenameColumn(
                name: "cart_id",
                table: "Others",
                newName: "Cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_Others_cart_id",
                table: "Others",
                newName: "IX_Others_Cart_id");

            migrationBuilder.RenameColumn(
                name: "cart_id",
                table: "inPatients",
                newName: "Cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_inPatients_cart_id",
                table: "inPatients",
                newName: "IX_inPatients_Cart_id");

            migrationBuilder.RenameColumn(
                name: "cart_id",
                table: "flexibility",
                newName: "Cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_flexibility_cart_id",
                table: "flexibility",
                newName: "IX_flexibility_Cart_id");

            migrationBuilder.RenameColumn(
                name: "cart_id",
                table: "digitalizations",
                newName: "Cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_digitalizations_cart_id",
                table: "digitalizations",
                newName: "IX_digitalizations_Cart_id");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "requests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

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
                name: "FK_inPatients_carts_Cart_id",
                table: "inPatients",
                column: "Cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Others_carts_Cart_id",
                table: "Others",
                column: "Cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_outPatients_carts_Cart_id",
                table: "outPatients",
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

            migrationBuilder.AddForeignKey(
                name: "FK_SpecialBenefits_carts_Cart_id",
                table: "SpecialBenefits",
                column: "Cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_digitalizations_carts_Cart_id",
                table: "digitalizations");

            migrationBuilder.DropForeignKey(
                name: "FK_flexibility_carts_Cart_id",
                table: "flexibility");

            migrationBuilder.DropForeignKey(
                name: "FK_inPatients_carts_Cart_id",
                table: "inPatients");

            migrationBuilder.DropForeignKey(
                name: "FK_Others_carts_Cart_id",
                table: "Others");

            migrationBuilder.DropForeignKey(
                name: "FK_outPatients_carts_Cart_id",
                table: "outPatients");

            migrationBuilder.DropForeignKey(
                name: "FK_Providers_carts_Cart_id",
                table: "Providers");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecialBenefits_carts_Cart_id",
                table: "SpecialBenefits");

            migrationBuilder.RenameColumn(
                name: "Cart_id",
                table: "SpecialBenefits",
                newName: "cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_SpecialBenefits_Cart_id",
                table: "SpecialBenefits",
                newName: "IX_SpecialBenefits_cart_id");

            migrationBuilder.RenameColumn(
                name: "Cart_id",
                table: "Providers",
                newName: "cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_Providers_Cart_id",
                table: "Providers",
                newName: "IX_Providers_cart_id");

            migrationBuilder.RenameColumn(
                name: "Cart_id",
                table: "outPatients",
                newName: "cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_outPatients_Cart_id",
                table: "outPatients",
                newName: "IX_outPatients_cart_id");

            migrationBuilder.RenameColumn(
                name: "Cart_id",
                table: "Others",
                newName: "cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_Others_Cart_id",
                table: "Others",
                newName: "IX_Others_cart_id");

            migrationBuilder.RenameColumn(
                name: "Cart_id",
                table: "inPatients",
                newName: "cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_inPatients_Cart_id",
                table: "inPatients",
                newName: "IX_inPatients_cart_id");

            migrationBuilder.RenameColumn(
                name: "Cart_id",
                table: "flexibility",
                newName: "cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_flexibility_Cart_id",
                table: "flexibility",
                newName: "IX_flexibility_cart_id");

            migrationBuilder.RenameColumn(
                name: "Cart_id",
                table: "digitalizations",
                newName: "cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_digitalizations_Cart_id",
                table: "digitalizations",
                newName: "IX_digitalizations_cart_id");

            migrationBuilder.AlterColumn<long>(
                name: "Phone",
                table: "requests",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_digitalizations_carts_cart_id",
                table: "digitalizations",
                column: "cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_flexibility_carts_cart_id",
                table: "flexibility",
                column: "cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_inPatients_carts_cart_id",
                table: "inPatients",
                column: "cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Others_carts_cart_id",
                table: "Others",
                column: "cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_outPatients_carts_cart_id",
                table: "outPatients",
                column: "cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Providers_carts_cart_id",
                table: "Providers",
                column: "cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecialBenefits_carts_cart_id",
                table: "SpecialBenefits",
                column: "cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
