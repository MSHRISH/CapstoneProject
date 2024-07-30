using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class GodKnowsWhat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Snacks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "SnackOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "SnackAmount",
                table: "Bookings",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TicketAmount",
                table: "Bookings",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 214, 123, 149, 212, 31, 46, 212, 23, 243, 182, 136, 92, 244, 254, 27, 132, 50, 212, 135, 141, 54, 243, 193, 219, 139, 200, 139, 250, 30, 121, 0, 163, 243, 66, 194, 10, 113, 108, 101, 143, 4, 232, 135, 166, 200, 59, 1, 5, 64, 162, 121, 14, 185, 27, 199, 56, 41, 241, 40, 206, 207, 175, 52, 65 }, new byte[] { 6, 134, 213, 190, 72, 230, 8, 123, 51, 3, 8, 191, 42, 7, 33, 37, 204, 205, 211, 119, 191, 19, 33, 245, 165, 8, 82, 102, 186, 5, 206, 64, 129, 122, 133, 146, 223, 144, 141, 189, 6, 142, 81, 18, 240, 234, 88, 63, 139, 168, 198, 190, 171, 254, 67, 80, 145, 244, 181, 51, 42, 174, 144, 209, 154, 49, 178, 176, 159, 107, 216, 252, 62, 152, 197, 79, 62, 71, 155, 155, 215, 125, 210, 78, 34, 162, 23, 242, 186, 99, 231, 214, 210, 60, 204, 232, 207, 117, 234, 75, 58, 68, 22, 86, 98, 2, 12, 143, 202, 54, 52, 84, 37, 81, 38, 102, 85, 40, 252, 42, 208, 94, 60, 117, 20, 199, 157, 40 } });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Column",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 9, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 11,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 12,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 13,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 14,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 15,
                column: "Column",
                value: 15);

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
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

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
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 10, true });

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
                column: "Column",
                value: 9);

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
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 11, true });

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
                column: "Column",
                value: 10);

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
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 12, true });

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
                column: "Column",
                value: 11);

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
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 13, true });

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
                column: "Column",
                value: 12);

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
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 14, true });

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
                column: "Column",
                value: 13);

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
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 15, true });

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
                column: "Column",
                value: 14);

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
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 1, true, 9 });

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
                column: "Column",
                value: 15);

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
                columns: new[] { "Column", "Row" },
                values: new object[] { 2, 10 });

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
                columns: new[] { "Column", "Row" },
                values: new object[] { 3, 13 });

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
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 5, true, 13 });

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
                columns: new[] { "Column", "Row" },
                values: new object[] { 4, 14 });

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
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 6, true, 14 });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[] { 1, "mynameisshrish@gmail.com", "Shrish", "1231233123" });

            migrationBuilder.InsertData(
                table: "UserAuths",
                columns: new[] { "Id", "PasswordHash", "PasswordHashKey", "UserId" },
                values: new object[] { 1, new byte[] { 164, 132, 252, 181, 43, 216, 128, 83, 21, 53, 177, 126, 94, 35, 83, 181, 59, 206, 139, 47, 123, 200, 73, 61, 210, 242, 142, 100, 98, 253, 255, 255, 242, 239, 30, 131, 151, 118, 100, 55, 219, 121, 82, 176, 83, 30, 159, 64, 148, 187, 4, 184, 22, 242, 161, 120, 230, 243, 120, 133, 87, 115, 11, 213 }, new byte[] { 125, 167, 61, 36, 87, 245, 24, 22, 230, 131, 245, 197, 235, 227, 78, 122, 252, 74, 83, 204, 129, 145, 247, 59, 36, 157, 100, 171, 146, 7, 70, 251, 63, 206, 173, 41, 134, 150, 238, 107, 65, 139, 84, 245, 103, 234, 99, 137, 254, 253, 164, 195, 154, 198, 239, 254, 44, 60, 49, 52, 54, 243, 6, 44, 130, 50, 237, 183, 208, 26, 37, 223, 15, 53, 163, 147, 203, 4, 175, 87, 96, 200, 12, 198, 163, 181, 168, 165, 166, 124, 112, 111, 42, 123, 247, 171, 197, 118, 34, 38, 97, 20, 148, 47, 72, 254, 116, 55, 57, 57, 120, 23, 127, 173, 81, 30, 111, 193, 110, 41, 125, 215, 43, 204, 56, 175, 181, 29 }, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Snacks");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "SnackOrders");

            migrationBuilder.DropColumn(
                name: "SnackAmount",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "TicketAmount",
                table: "Bookings");

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 140, 239, 238, 73, 226, 165, 213, 172, 148, 192, 11, 73, 59, 230, 1, 95, 77, 249, 0, 114, 236, 88, 152, 132, 135, 109, 119, 13, 160, 115, 150, 201, 151, 203, 189, 55, 241, 205, 140, 42, 122, 64, 60, 62, 93, 228, 242, 19, 96, 12, 28, 172, 224, 0, 171, 134, 43, 87, 132, 14, 11, 226, 134, 37 }, new byte[] { 78, 75, 45, 34, 165, 54, 17, 52, 160, 145, 49, 100, 193, 27, 207, 136, 73, 142, 202, 91, 159, 207, 232, 180, 163, 62, 135, 240, 192, 15, 2, 140, 213, 104, 193, 109, 119, 132, 141, 60, 35, 79, 76, 51, 87, 179, 145, 100, 196, 230, 76, 141, 192, 218, 32, 220, 205, 155, 160, 214, 65, 91, 198, 142, 170, 231, 115, 17, 174, 57, 228, 201, 239, 102, 125, 111, 111, 161, 144, 142, 137, 185, 199, 220, 231, 211, 38, 14, 193, 249, 238, 220, 149, 125, 38, 175, 47, 179, 104, 5, 5, 107, 207, 157, 1, 156, 53, 185, 200, 102, 180, 225, 9, 88, 200, 39, 64, 120, 122, 215, 53, 48, 4, 100, 110, 157, 142, 107 } });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Column",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 6, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Column",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 11,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 12,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 13,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 14,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 15,
                column: "Column",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 1 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 17,
                column: "Column",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 18,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 19,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 20,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 21,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 5, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 6, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 26,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 27,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 28,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 29,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 30,
                column: "Column",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 2 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 2 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 33,
                column: "Column",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 34,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 35,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 36,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 4, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 5, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 39,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 42,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 43,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 44,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 45,
                column: "Column",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 3 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 3 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 3 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 49,
                column: "Column",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 50,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 51,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 3, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 4, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 54,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 55,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 58,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 59,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 60,
                column: "Column",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 4 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 4 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 4 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 4 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 65,
                column: "Column",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 66,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 2, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 3, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 69,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 70,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 71,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 74,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 75,
                column: "Column",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Column", "Row" },
                values: new object[] { 11, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 5 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 81,
                column: "Column",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 1, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 2, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 84,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 85,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 86,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 87,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 90,
                column: "Column",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Column", "Row" },
                values: new object[] { 10, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Column", "Row" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 6 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 0, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 1, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 99,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 100,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 101,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 102,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 103,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 8, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Column", "Row" },
                values: new object[] { 9, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Column", "Row" },
                values: new object[] { 10, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Column", "Row" },
                values: new object[] { 11, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 15, true, 7 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 0, true });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 114,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 115,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 116,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 117,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 118,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 119,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Column", "IsSeat" },
                values: new object[] { 7, false });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 8, false, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Column", "Row" },
                values: new object[] { 9, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Column", "Row" },
                values: new object[] { 10, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Column", "Row" },
                values: new object[] { 11, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 14, true, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 15, true, 8 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 129,
                column: "Column",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 130,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 131,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 132,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 133,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 134,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 135,
                column: "Column",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Column", "Row" },
                values: new object[] { 7, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Column", "Row" },
                values: new object[] { 8, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 9, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 10, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 11, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 12, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 13, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 14, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 15, true, 9 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 145,
                column: "Column",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 146,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 147,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 148,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 149,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 150,
                column: "Column",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Column", "Row" },
                values: new object[] { 6, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Column", "Row" },
                values: new object[] { 7, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Column", "Row" },
                values: new object[] { 8, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Column", "Row" },
                values: new object[] { 9, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Column", "Row" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Column", "Row" },
                values: new object[] { 11, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 10 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 161,
                column: "Column",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 162,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 163,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 164,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 165,
                column: "Column",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 5, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 6, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 7, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 8, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 9, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 10, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Column", "Row" },
                values: new object[] { 11, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 13, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 14, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 15, false, 11 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 177,
                column: "Column",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 178,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 179,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 180,
                column: "Column",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Column", "Row" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Column", "Row" },
                values: new object[] { 5, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Column", "Row" },
                values: new object[] { 6, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 7, false, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 8, false, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Column", "Row" },
                values: new object[] { 9, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 10, true, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 11, true, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 12 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 193,
                column: "Column",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 194,
                column: "Column",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 195,
                column: "Column",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Column", "Row" },
                values: new object[] { 3, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Column", "Row" },
                values: new object[] { 4, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Column", "Row" },
                values: new object[] { 5, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Column", "Row" },
                values: new object[] { 6, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 7, false, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 8, false, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 9, true, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Column", "IsSeat", "Row" },
                values: new object[] { 10, true, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Column", "Row" },
                values: new object[] { 11, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Column", "Row" },
                values: new object[] { 12, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Column", "Row" },
                values: new object[] { 13, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Column", "Row" },
                values: new object[] { 14, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Column", "Row" },
                values: new object[] { 15, 13 });

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 209,
                column: "Column",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ScreenLayouts",
                keyColumn: "Id",
                keyValue: 210,
                column: "Column",
                value: 1);

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 211, 2, true, 100f, 14, 1 },
                    { 212, 3, true, 100f, 14, 1 },
                    { 213, 4, true, 100f, 14, 1 },
                    { 214, 5, true, 100f, 14, 1 },
                    { 215, 6, true, 100f, 14, 1 },
                    { 216, 7, false, 100f, 14, 1 },
                    { 217, 8, false, 100f, 14, 1 },
                    { 218, 9, true, 100f, 14, 1 },
                    { 219, 10, true, 100f, 14, 1 },
                    { 220, 11, true, 100f, 14, 1 },
                    { 221, 12, true, 100f, 14, 1 },
                    { 222, 13, true, 100f, 14, 1 },
                    { 223, 14, true, 100f, 14, 1 },
                    { 224, 15, true, 100f, 14, 1 }
                });
        }
    }
}
