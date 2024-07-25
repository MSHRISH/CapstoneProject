using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class AdminDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 1, "Shrish@gmail.com", "Shrish" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "About", "Name" },
                values: new object[,]
                {
                    { 1, "Great Actor.", "Brad Pitt" },
                    { 2, "Great Actor.", "Edward Norton" },
                    { 3, "Great Director.", "David Fincher" }
                });

            migrationBuilder.InsertData(
                table: "AdminAuths",
                columns: new[] { "Id", "AdminId", "PasswordHash", "PasswordHashKey" },
                values: new object[] { 1, 1, new byte[] { 79, 222, 62, 66, 151, 71, 106, 62, 89, 235, 148, 50, 245, 128, 101, 152, 103, 68, 245, 72, 116, 13, 59, 41, 232, 25, 23, 6, 255, 205, 13, 71, 86, 4, 205, 246, 3, 222, 236, 42, 160, 252, 74, 129, 206, 5, 153, 216, 121, 69, 159, 98, 176, 174, 153, 103, 123, 28, 109, 12, 161, 89, 20, 229 }, new byte[] { 82, 253, 16, 102, 249, 252, 236, 250, 79, 70, 239, 153, 111, 199, 89, 189, 234, 30, 15, 41, 39, 220, 245, 84, 70, 236, 31, 117, 56, 245, 82, 193, 64, 132, 191, 16, 122, 112, 59, 134, 135, 75, 205, 124, 149, 78, 118, 148, 176, 54, 172, 7, 84, 12, 106, 188, 249, 111, 110, 13, 171, 118, 69, 141, 40, 12, 41, 12, 46, 83, 42, 187, 120, 152, 254, 188, 85, 146, 55, 61, 114, 126, 156, 27, 87, 174, 13, 145, 217, 221, 46, 222, 103, 115, 144, 31, 70, 163, 200, 31, 131, 237, 201, 106, 219, 77, 130, 203, 119, 72, 212, 98, 140, 29, 177, 196, 54, 8, 150, 254, 42, 106, 233, 150, 245, 157, 130, 208 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
