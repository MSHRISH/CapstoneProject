using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class LayoutUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 60, 159, 175, 11, 202, 212, 233, 225, 203, 94, 227, 212, 219, 14, 27, 72, 135, 133, 52, 55, 141, 113, 229, 154, 253, 38, 127, 168, 208, 227, 26, 97, 222, 129, 13, 225, 226, 43, 123, 138, 179, 234, 168, 239, 75, 173, 106, 201, 66, 236, 22, 114, 70, 89, 137, 157, 138, 196, 167, 109, 232, 129, 192, 17 }, new byte[] { 240, 120, 113, 179, 10, 167, 16, 108, 30, 243, 223, 183, 83, 222, 223, 104, 177, 231, 24, 208, 146, 173, 252, 161, 245, 24, 149, 82, 169, 135, 113, 185, 89, 79, 130, 7, 96, 39, 61, 77, 135, 9, 15, 222, 11, 143, 247, 121, 132, 142, 206, 138, 214, 78, 231, 25, 70, 96, 246, 37, 59, 78, 219, 240, 245, 17, 194, 183, 176, 114, 209, 240, 59, 206, 200, 188, 43, 71, 96, 12, 232, 40, 195, 12, 252, 248, 247, 131, 209, 127, 81, 165, 216, 2, 62, 41, 153, 56, 77, 37, 20, 251, 74, 26, 121, 191, 255, 152, 138, 21, 128, 13, 83, 152, 104, 141, 98, 150, 28, 180, 150, 129, 175, 43, 252, 246, 71, 107 } });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Column", "Row" },
                values: new object[] { 16, 1 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 17,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 18,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 19,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 20,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 21,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 6, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 23,
                column: "Column",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 25,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 26,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 27,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 28,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 29,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 30,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 2 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Column", "Row" },
                values: new object[] { 16, 2 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 33,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 34,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 35,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 36,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 5, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 6, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 41,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 42,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 43,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 44,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 45,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 3 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 3 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Column", "Row" },
                values: new object[] { 16, 3 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 49,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 50,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 51,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 4, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 5, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 54,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 57,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 58,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 59,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 60,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 4 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 4 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 4 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Column", "Row" },
                values: new object[] { 16, 4 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 65,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 66,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 3, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 4, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 69,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 70,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 73,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 74,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 75,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Column", "Row" },
                values: new object[] { 16, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 81,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 2, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 3, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 84,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 85,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 86,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 89,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 90,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Column", "Row" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Column", "Row" },
                values: new object[] { 16, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 1, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 2, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 99,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 100,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 101,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 102,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 105,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Column", "Row" },
                values: new object[] { 10, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Column", "Row" },
                values: new object[] { 11, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 16, true, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 1, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 114,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 115,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 116,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 117,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 118,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Column", "Row" },
                values: new object[] { 9, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Column", "Row" },
                values: new object[] { 10, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Column", "Row" },
                values: new object[] { 11, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 15, true, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 16, true, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 129,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 130,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 131,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 132,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 133,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 134,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Column", "Row" },
                values: new object[] { 8, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 9, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 10, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 11, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 12, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 13, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 14, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 15, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 16, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 145,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 146,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 147,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 148,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 149,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 150,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Column", "Row" },
                values: new object[] { 7, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Column", "Row" },
                values: new object[] { 8, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Column", "Row" },
                values: new object[] { 9, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Column", "Row" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Column", "Row" },
                values: new object[] { 11, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Column", "Row" },
                values: new object[] { 16, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 161,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 162,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 163,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 164,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 165,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 6, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 7, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 8, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 9, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 10, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 11, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 14, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 15, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 16, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 177,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 178,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 179,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 180,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Column", "Row" },
                values: new object[] { 5, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Column", "Row" },
                values: new object[] { 6, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 7, false, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 8, false, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Column", "Row" },
                values: new object[] { 9, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Column", "Row" },
                values: new object[] { 10, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 11, true, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 12, true, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Column", "Row" },
                values: new object[] { 16, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 193,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 194,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 195,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Column", "Row" },
                values: new object[] { 4, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Column", "Row" },
                values: new object[] { 5, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Column", "Row" },
                values: new object[] { 6, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 7, false, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 8, false, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Column", "Row" },
                values: new object[] { 9, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 10, true, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 11, true, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Column", "Row" },
                values: new object[] { 16, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 209,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 210,
                column: "Column",
                value: 2);

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 211, 3, true, 100f, 14, 1 },
                    { 212, 4, true, 100f, 14, 1 },
                    { 213, 5, true, 100f, 14, 1 },
                    { 214, 6, true, 100f, 14, 1 },
                    { 215, 7, false, 100f, 14, 1 },
                    { 216, 8, false, 100f, 14, 1 },
                    { 217, 9, true, 100f, 14, 1 },
                    { 218, 10, true, 100f, 14, 1 },
                    { 219, 11, true, 100f, 14, 1 },
                    { 220, 12, true, 100f, 14, 1 },
                    { 221, 13, true, 100f, 14, 1 },
                    { 222, 14, true, 100f, 14, 1 },
                    { 223, 15, true, 100f, 14, 1 },
                    { 224, 16, true, 100f, 14, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 225, 1, true, 100f, 15, 1 },
                    { 226, 2, true, 100f, 15, 1 },
                    { 227, 3, true, 100f, 15, 1 },
                    { 228, 4, true, 100f, 15, 1 },
                    { 229, 5, true, 100f, 15, 1 },
                    { 230, 6, true, 100f, 15, 1 },
                    { 231, 7, false, 100f, 15, 1 },
                    { 232, 8, false, 100f, 15, 1 },
                    { 233, 9, true, 100f, 15, 1 },
                    { 234, 10, true, 100f, 15, 1 },
                    { 235, 11, true, 100f, 15, 1 },
                    { 236, 12, true, 100f, 15, 1 },
                    { 237, 13, true, 100f, 15, 1 },
                    { 238, 14, true, 100f, 15, 1 },
                    { 239, 15, true, 100f, 15, 1 },
                    { 240, 16, true, 100f, 15, 1 }
                });

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 146, 112, 72, 181, 5, 227, 189, 203, 215, 101, 105, 224, 8, 78, 137, 248, 114, 151, 168, 222, 3, 211, 4, 207, 40, 23, 153, 101, 17, 84, 128, 152, 45, 69, 52, 190, 163, 75, 91, 211, 102, 255, 20, 65, 130, 159, 164, 99, 14, 75, 45, 239, 254, 102, 181, 47, 22, 116, 86, 127, 28, 56, 53, 173 }, new byte[] { 94, 19, 83, 82, 239, 190, 167, 188, 101, 5, 229, 39, 249, 58, 156, 148, 143, 93, 119, 120, 232, 34, 42, 123, 148, 38, 30, 115, 122, 196, 212, 192, 74, 28, 214, 237, 175, 180, 29, 237, 22, 241, 78, 194, 22, 232, 245, 53, 82, 168, 165, 31, 82, 210, 144, 248, 62, 124, 249, 168, 113, 40, 156, 233, 149, 79, 201, 109, 4, 194, 180, 163, 29, 152, 227, 107, 228, 61, 117, 110, 90, 140, 54, 97, 74, 243, 242, 150, 149, 128, 22, 119, 144, 102, 34, 249, 225, 192, 20, 232, 140, 177, 232, 159, 11, 200, 203, 163, 96, 198, 36, 63, 122, 137, 167, 254, 92, 113, 125, 208, 117, 178, 142, 108, 63, 11, 36, 150 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 162, 57, 31, 178, 132, 40, 148, 187, 185, 249, 99, 216, 34, 147, 150, 40, 64, 40, 197, 129, 20, 122, 154, 184, 205, 28, 55, 44, 22, 76, 201, 138, 171, 43, 147, 250, 213, 24, 175, 113, 184, 81, 203, 237, 54, 211, 195, 227, 155, 75, 197, 44, 245, 218, 137, 24, 167, 108, 147, 201, 133, 199, 59, 100 }, new byte[] { 172, 13, 60, 16, 90, 91, 20, 106, 49, 157, 66, 105, 14, 29, 209, 196, 111, 25, 40, 90, 233, 102, 224, 23, 106, 105, 140, 210, 72, 1, 249, 22, 173, 23, 77, 183, 83, 72, 188, 201, 230, 98, 95, 117, 179, 98, 55, 124, 198, 233, 125, 126, 107, 148, 132, 142, 91, 245, 40, 69, 242, 117, 135, 126, 0, 146, 154, 137, 3, 41, 123, 162, 20, 90, 58, 109, 58, 23, 110, 86, 102, 111, 187, 196, 219, 169, 241, 206, 183, 153, 181, 129, 232, 38, 26, 44, 81, 43, 220, 140, 100, 166, 225, 24, 212, 87, 180, 163, 8, 84, 178, 189, 150, 133, 54, 174, 90, 208, 125, 50, 174, 211, 29, 111, 21, 17, 101, 52 } });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Column", "Row" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 17,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 18,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 19,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 20,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 21,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 23,
                column: "Column",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 9, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 25,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 26,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 27,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 28,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 29,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 30,
                column: "Column",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Column", "Row" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Column", "Row" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 33,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 34,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 35,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 36,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 9, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 10, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 41,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 42,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 43,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 44,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 45,
                column: "Column",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Column", "Row" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Column", "Row" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Column", "Row" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 49,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 50,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 51,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 54,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 10, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 11, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 57,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 58,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 59,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 60,
                column: "Column",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Column", "Row" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Column", "Row" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Column", "Row" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Column", "Row" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 65,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 66,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 69,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 70,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 11, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 12, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 73,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 74,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 75,
                column: "Column",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Column", "Row" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Column", "Row" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Column", "Row" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Column", "Row" },
                values: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Column", "Row" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 81,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 84,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 85,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 86,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 12, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 13, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 89,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 90,
                column: "Column",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Column", "Row" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Column", "Row" },
                values: new object[] { 2, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Column", "Row" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Column", "Row" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Column", "Row" },
                values: new object[] { 5, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Column", "Row" },
                values: new object[] { 6, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 99,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 100,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 101,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 102,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 13, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 14, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 105,
                column: "Column",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Column", "Row" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Column", "Row" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Column", "Row" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Column", "Row" },
                values: new object[] { 4, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Column", "Row" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Column", "Row" },
                values: new object[] { 6, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 7, false, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 114,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 115,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 116,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 117,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 118,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 14, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 15, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Column", "Row" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Column", "Row" },
                values: new object[] { 2, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Column", "Row" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Column", "Row" },
                values: new object[] { 4, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Column", "Row" },
                values: new object[] { 5, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Column", "Row" },
                values: new object[] { 6, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 7, false, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 8, false, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 129,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 130,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 131,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 132,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 133,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 134,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 15, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Column", "Row" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 2, false, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 3, false, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 4, false, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 5, false, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 6, false, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 7, false, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 8, false, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 9, false, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 145,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 146,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 147,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 148,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 149,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 150,
                column: "Column",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Column", "Row" },
                values: new object[] { 1, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Column", "Row" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Column", "Row" },
                values: new object[] { 3, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Column", "Row" },
                values: new object[] { 4, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Column", "Row" },
                values: new object[] { 5, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Column", "Row" },
                values: new object[] { 6, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Column", "Row" },
                values: new object[] { 7, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Column", "Row" },
                values: new object[] { 8, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Column", "Row" },
                values: new object[] { 9, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Column", "Row" },
                values: new object[] { 10, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 161,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 162,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 163,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 164,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 165,
                column: "Column",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 1, true, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 2, true, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 3, true, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 4, true, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 5, true, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 6, true, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Column", "Row" },
                values: new object[] { 7, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Column", "Row" },
                values: new object[] { 8, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 9, true, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 10, true, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 11, true, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 177,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 178,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 179,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 180,
                column: "Column",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Column", "Row" },
                values: new object[] { 1, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Column", "Row" },
                values: new object[] { 2, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 3, true, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 4, true, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Column", "Row" },
                values: new object[] { 5, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Column", "Row" },
                values: new object[] { 6, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 7, false, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 8, false, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Column", "Row" },
                values: new object[] { 9, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Column", "Row" },
                values: new object[] { 10, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Column", "Row" },
                values: new object[] { 11, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 193,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 194,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 195,
                column: "Column",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Column", "Row" },
                values: new object[] { 1, 14 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Column", "Row" },
                values: new object[] { 2, 14 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Column", "Row" },
                values: new object[] { 3, 14 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 4, true, 14 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 5, true, 14 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Column", "Row" },
                values: new object[] { 6, 14 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 7, false, 14 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 8, false, 14 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Column", "Row" },
                values: new object[] { 9, 14 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Column", "Row" },
                values: new object[] { 10, 14 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Column", "Row" },
                values: new object[] { 11, 14 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 14 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 14 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 209,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 210,
                column: "Column",
                value: 15);

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 59, 39, 114, 191, 192, 17, 255, 134, 187, 215, 18, 179, 131, 77, 129, 100, 88, 187, 70, 243, 26, 11, 19, 94, 240, 111, 37, 100, 232, 10, 64, 183, 198, 252, 237, 170, 64, 184, 135, 198, 178, 163, 35, 220, 198, 61, 5, 222, 65, 211, 164, 193, 102, 120, 159, 151, 177, 222, 39, 109, 175, 44, 188, 83 }, new byte[] { 139, 243, 14, 7, 112, 127, 61, 87, 36, 62, 133, 198, 192, 73, 0, 19, 64, 211, 199, 139, 77, 51, 222, 40, 237, 172, 121, 106, 187, 238, 225, 94, 29, 70, 221, 184, 205, 178, 169, 37, 216, 200, 125, 50, 103, 88, 102, 238, 180, 79, 48, 164, 80, 172, 17, 58, 216, 218, 129, 141, 208, 169, 185, 136, 175, 189, 142, 98, 9, 16, 253, 198, 141, 77, 102, 252, 157, 231, 233, 185, 218, 101, 204, 204, 210, 0, 11, 127, 102, 194, 157, 33, 135, 252, 55, 157, 24, 219, 20, 40, 9, 149, 85, 48, 121, 255, 167, 103, 237, 213, 48, 65, 120, 92, 13, 76, 191, 184, 45, 143, 123, 187, 97, 145, 138, 132, 17, 63 } });
        }
    }
}
