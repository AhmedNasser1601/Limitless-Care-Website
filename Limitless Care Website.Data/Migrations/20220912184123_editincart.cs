using Microsoft.EntityFrameworkCore.Migrations;

namespace Limitless_Care_Website.Data.Migrations
{
    public partial class editincart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9347eec9-1fbb-44bb-b930-819db8ae4654");

            migrationBuilder.AddColumn<string>(
                name: "IconPath",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57aa6af5-bff0-4e10-836a-a03a36694b42", "b95a36a6-b7e3-4cf5-9883-32d71d8fb363", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57aa6af5-bff0-4e10-836a-a03a36694b42");

            migrationBuilder.DropColumn(
                name: "IconPath",
                table: "carts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9347eec9-1fbb-44bb-b930-819db8ae4654", "8a15486a-3f99-4e85-b012-fb646416224b", "Admin", "ADMIN" });
        }
    }
}
