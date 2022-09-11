using Microsoft.EntityFrameworkCore.Migrations;

namespace Limitless_Care_Website.Data.Migrations
{
    public partial class Admin1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abaad671-77a5-477f-8f2d-ad5e58133da3", "901141a8-1ce0-4772-9617-d844949099fb", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abaad671-77a5-477f-8f2d-ad5e58133da3");
        }
    }
}
