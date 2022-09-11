using Microsoft.EntityFrameworkCore.Migrations;

namespace Limitless_Care_Website.Data.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abaad671-77a5-477f-8f2d-ad5e58133da3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e14635b-47b6-4194-a2c5-6cc4cac61445", "be929822-989b-4b93-8775-7d7df987b57d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e14635b-47b6-4194-a2c5-6cc4cac61445");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abaad671-77a5-477f-8f2d-ad5e58133da3", "901141a8-1ce0-4772-9617-d844949099fb", "Admin", "ADMIN" });
        }
    }
}
