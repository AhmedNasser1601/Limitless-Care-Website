using Microsoft.EntityFrameworkCore.Migrations;

namespace Limitless_Care_Website.Data.Migrations
{
    public partial class inita1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Benefit_Id",
                table: "SpecialBenefits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Benefit_Id",
                table: "outPatients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Benefit_Id",
                table: "Others",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Benefit_Id",
                table: "inPatients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SpecialBenefits_Benefit_Id",
                table: "SpecialBenefits",
                column: "Benefit_Id");

            migrationBuilder.CreateIndex(
                name: "IX_outPatients_Benefit_Id",
                table: "outPatients",
                column: "Benefit_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Others_Benefit_Id",
                table: "Others",
                column: "Benefit_Id");

            migrationBuilder.CreateIndex(
                name: "IX_inPatients_Benefit_Id",
                table: "inPatients",
                column: "Benefit_Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_SpecialBenefits_Benefit_Id",
                table: "SpecialBenefits");

            migrationBuilder.DropIndex(
                name: "IX_outPatients_Benefit_Id",
                table: "outPatients");

            migrationBuilder.DropIndex(
                name: "IX_Others_Benefit_Id",
                table: "Others");

            migrationBuilder.DropIndex(
                name: "IX_inPatients_Benefit_Id",
                table: "inPatients");

            migrationBuilder.DropColumn(
                name: "Benefit_Id",
                table: "SpecialBenefits");

            migrationBuilder.DropColumn(
                name: "Benefit_Id",
                table: "outPatients");

            migrationBuilder.DropColumn(
                name: "Benefit_Id",
                table: "Others");

            migrationBuilder.DropColumn(
                name: "Benefit_Id",
                table: "inPatients");
        }
    }
}
