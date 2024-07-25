using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class FormatAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Formats",
                columns: new[] { "Id", "FormatName" },
                values: new object[] { 1, "U" });

            migrationBuilder.InsertData(
                table: "Formats",
                columns: new[] { "Id", "FormatName" },
                values: new object[] { 2, "U/A" });

            migrationBuilder.InsertData(
                table: "Formats",
                columns: new[] { "Id", "FormatName" },
                values: new object[] { 3, "A" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
