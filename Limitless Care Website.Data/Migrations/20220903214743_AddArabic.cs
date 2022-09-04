using Microsoft.EntityFrameworkCore.Migrations;

namespace Limitless_Care_Website.Data.Migrations
{
    public partial class AddArabic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BriefInArabic",
                table: "Updates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoumentionInArabic",
                table: "Updates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailInArabic",
                table: "SpecialBenefits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailInArabic",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameInArabic",
                table: "Peoples",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoleInArabic",
                table: "Peoples",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailInArabic",
                table: "outPatients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailInArabic",
                table: "Others",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailInArabic",
                table: "inPatients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailInArabic",
                table: "flexibility",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BriefInArabic",
                table: "digitalizations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailInArabic",
                table: "DigitalizationDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AcurrateFrequnentInArabic",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BriefInArabic",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerStatisfactionInArabic",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoumentionInArabic",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameInArabic",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BriefInArabic",
                table: "Updates");

            migrationBuilder.DropColumn(
                name: "DoumentionInArabic",
                table: "Updates");

            migrationBuilder.DropColumn(
                name: "DetailInArabic",
                table: "SpecialBenefits");

            migrationBuilder.DropColumn(
                name: "DetailInArabic",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "NameInArabic",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "RoleInArabic",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "DetailInArabic",
                table: "outPatients");

            migrationBuilder.DropColumn(
                name: "DetailInArabic",
                table: "Others");

            migrationBuilder.DropColumn(
                name: "DetailInArabic",
                table: "inPatients");

            migrationBuilder.DropColumn(
                name: "DetailInArabic",
                table: "flexibility");

            migrationBuilder.DropColumn(
                name: "BriefInArabic",
                table: "digitalizations");

            migrationBuilder.DropColumn(
                name: "DetailInArabic",
                table: "DigitalizationDetails");

            migrationBuilder.DropColumn(
                name: "AcurrateFrequnentInArabic",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "BriefInArabic",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "CustomerStatisfactionInArabic",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "DoumentionInArabic",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "NameInArabic",
                table: "carts");
        }
    }
}
