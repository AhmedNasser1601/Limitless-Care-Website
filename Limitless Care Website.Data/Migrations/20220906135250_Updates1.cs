using Microsoft.EntityFrameworkCore.Migrations;

namespace Limitless_Care_Website.Data.Migrations
{
    public partial class Updates1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerStatisfactionInArabic",
                table: "carts",
                newName: "NameofSection5_Ar");

            migrationBuilder.RenameColumn(
                name: "CustomerStatisfaction",
                table: "carts",
                newName: "NameofSection5");

            migrationBuilder.RenameColumn(
                name: "AcurrateFrequnentInArabic",
                table: "carts",
                newName: "NameofSection4_Ar");

            migrationBuilder.RenameColumn(
                name: "AcurrateFrequnent",
                table: "carts",
                newName: "NameofSection4");

            migrationBuilder.AddColumn<string>(
                name: "NameofSection1",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameofSection1_Ar",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameofSection2",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameofSection2_Ar",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameofSection3",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameofSection3_Ar",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Section1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cart_id = table.Column<int>(type: "int", nullable: false),
                    DetailInArabic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Section1_carts_Cart_id",
                        column: x => x.Cart_id,
                        principalTable: "carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Section4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cart_id = table.Column<int>(type: "int", nullable: false),
                    DetailInArabic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section4", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Section4_carts_Cart_id",
                        column: x => x.Cart_id,
                        principalTable: "carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Section1_Cart_id",
                table: "Section1",
                column: "Cart_id");

            migrationBuilder.CreateIndex(
                name: "IX_Section4_Cart_id",
                table: "Section4",
                column: "Cart_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Section1");

            migrationBuilder.DropTable(
                name: "Section4");

            migrationBuilder.DropColumn(
                name: "NameofSection1",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "NameofSection1_Ar",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "NameofSection2",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "NameofSection2_Ar",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "NameofSection3",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "NameofSection3_Ar",
                table: "carts");

            migrationBuilder.RenameColumn(
                name: "NameofSection5_Ar",
                table: "carts",
                newName: "CustomerStatisfactionInArabic");

            migrationBuilder.RenameColumn(
                name: "NameofSection5",
                table: "carts",
                newName: "CustomerStatisfaction");

            migrationBuilder.RenameColumn(
                name: "NameofSection4_Ar",
                table: "carts",
                newName: "AcurrateFrequnentInArabic");

            migrationBuilder.RenameColumn(
                name: "NameofSection4",
                table: "carts",
                newName: "AcurrateFrequnent");
        }
    }
}
