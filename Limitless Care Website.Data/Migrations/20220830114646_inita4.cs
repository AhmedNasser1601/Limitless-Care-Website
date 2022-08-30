using Microsoft.EntityFrameworkCore.Migrations;

namespace Limitless_Care_Website.Data.Migrations
{
    public partial class inita4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inPatients_Benefits_Benefit_Id",
                table: "inPatients");

            migrationBuilder.DropForeignKey(
                name: "FK_Others_Benefits_Benefit_Id",
                table: "Others");

            migrationBuilder.DropForeignKey(
                name: "FK_outPatients_Benefits_Benefit_Id",
                table: "outPatients");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecialBenefits_Benefits_Benefit_Id",
                table: "SpecialBenefits");

            migrationBuilder.DropTable(
                name: "Benefits");

            migrationBuilder.RenameColumn(
                name: "Benefit_Id",
                table: "SpecialBenefits",
                newName: "cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_SpecialBenefits_Benefit_Id",
                table: "SpecialBenefits",
                newName: "IX_SpecialBenefits_cart_id");

            migrationBuilder.RenameColumn(
                name: "Benefit_Id",
                table: "outPatients",
                newName: "cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_outPatients_Benefit_Id",
                table: "outPatients",
                newName: "IX_outPatients_cart_id");

            migrationBuilder.RenameColumn(
                name: "Benefit_Id",
                table: "Others",
                newName: "cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_Others_Benefit_Id",
                table: "Others",
                newName: "IX_Others_cart_id");

            migrationBuilder.RenameColumn(
                name: "Benefit_Id",
                table: "inPatients",
                newName: "cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_inPatients_Benefit_Id",
                table: "inPatients",
                newName: "IX_inPatients_cart_id");

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
                name: "FK_SpecialBenefits_carts_cart_id",
                table: "SpecialBenefits",
                column: "cart_id",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_SpecialBenefits_carts_cart_id",
                table: "SpecialBenefits");

            migrationBuilder.RenameColumn(
                name: "cart_id",
                table: "SpecialBenefits",
                newName: "Benefit_Id");

            migrationBuilder.RenameIndex(
                name: "IX_SpecialBenefits_cart_id",
                table: "SpecialBenefits",
                newName: "IX_SpecialBenefits_Benefit_Id");

            migrationBuilder.RenameColumn(
                name: "cart_id",
                table: "outPatients",
                newName: "Benefit_Id");

            migrationBuilder.RenameIndex(
                name: "IX_outPatients_cart_id",
                table: "outPatients",
                newName: "IX_outPatients_Benefit_Id");

            migrationBuilder.RenameColumn(
                name: "cart_id",
                table: "Others",
                newName: "Benefit_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Others_cart_id",
                table: "Others",
                newName: "IX_Others_Benefit_Id");

            migrationBuilder.RenameColumn(
                name: "cart_id",
                table: "inPatients",
                newName: "Benefit_Id");

            migrationBuilder.RenameIndex(
                name: "IX_inPatients_cart_id",
                table: "inPatients",
                newName: "IX_inPatients_Benefit_Id");

            migrationBuilder.CreateTable(
                name: "Benefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cart_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Benefits_carts_cart_id",
                        column: x => x.cart_id,
                        principalTable: "carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Benefits_cart_id",
                table: "Benefits",
                column: "cart_id");

            migrationBuilder.AddForeignKey(
                name: "FK_inPatients_Benefits_Benefit_Id",
                table: "inPatients",
                column: "Benefit_Id",
                principalTable: "Benefits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Others_Benefits_Benefit_Id",
                table: "Others",
                column: "Benefit_Id",
                principalTable: "Benefits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_outPatients_Benefits_Benefit_Id",
                table: "outPatients",
                column: "Benefit_Id",
                principalTable: "Benefits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecialBenefits_Benefits_Benefit_Id",
                table: "SpecialBenefits",
                column: "Benefit_Id",
                principalTable: "Benefits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
