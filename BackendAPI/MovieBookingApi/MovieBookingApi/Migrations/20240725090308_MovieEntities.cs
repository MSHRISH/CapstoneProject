using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class MovieEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "CertificateType" },
                values: new object[,]
                {
                    { 1, "U" },
                    { 2, "U/A" },
                    { 3, "A" }
                });

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "Id",
                keyValue: 1,
                column: "FormatName",
                value: "2D");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "Id",
                keyValue: 2,
                column: "FormatName",
                value: "3D");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "Id",
                keyValue: 3,
                column: "FormatName",
                value: "IMAX");

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "LanguageName" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "Tamil" },
                    { 3, "Hindi" },
                    { 4, "Japanese" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "Id",
                keyValue: 1,
                column: "FormatName",
                value: "U");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "Id",
                keyValue: 2,
                column: "FormatName",
                value: "U/A");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "Id",
                keyValue: 3,
                column: "FormatName",
                value: "A");
        }
    }
}
