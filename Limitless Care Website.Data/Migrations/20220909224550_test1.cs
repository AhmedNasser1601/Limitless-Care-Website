using Microsoft.EntityFrameworkCore.Migrations;

namespace Limitless_Care_Website.Data.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e14635b-47b6-4194-a2c5-6cc4cac61445");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9347eec9-1fbb-44bb-b930-819db8ae4654", "8a15486a-3f99-4e85-b012-fb646416224b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9347eec9-1fbb-44bb-b930-819db8ae4654");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e14635b-47b6-4194-a2c5-6cc4cac61445", "be929822-989b-4b93-8775-7d7df987b57d", "Admin", "ADMIN" });
        }
    }
}
