using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class ConfigurationForDeleteBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SnackOrders_Snacks_SnackId",
                table: "SnackOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Bookings_BookingId",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 53, 0, 143, 249, 111, 137, 36, 119, 231, 220, 82, 143, 145, 55, 6, 248, 234, 169, 171, 177, 218, 213, 125, 244, 83, 52, 160, 32, 243, 152, 36, 107, 177, 168, 1, 14, 237, 147, 52, 205, 226, 95, 127, 149, 147, 251, 94, 241, 61, 140, 143, 116, 30, 193, 52, 39, 95, 78, 128, 107, 219, 62, 58, 49 }, new byte[] { 27, 83, 76, 44, 72, 142, 44, 112, 251, 0, 18, 225, 11, 2, 89, 225, 243, 156, 189, 87, 61, 209, 236, 55, 126, 206, 128, 34, 203, 41, 100, 159, 14, 72, 77, 208, 159, 74, 233, 190, 223, 154, 172, 56, 227, 248, 109, 250, 194, 170, 183, 123, 46, 221, 221, 53, 190, 137, 80, 10, 50, 136, 129, 228, 60, 6, 195, 248, 122, 129, 148, 248, 12, 181, 139, 182, 167, 84, 126, 66, 147, 228, 163, 239, 105, 54, 50, 79, 63, 143, 130, 38, 188, 202, 47, 123, 110, 49, 244, 255, 99, 208, 135, 231, 157, 71, 118, 147, 56, 141, 42, 75, 98, 99, 100, 229, 70, 236, 137, 33, 73, 226, 139, 220, 209, 232, 41, 133 } });

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 45, 208, 155, 249, 97, 22, 87, 112, 59, 154, 44, 37, 40, 198, 5, 248, 107, 140, 137, 210, 248, 193, 127, 144, 38, 237, 185, 222, 40, 20, 165, 110, 114, 153, 142, 89, 234, 165, 29, 80, 0, 210, 92, 54, 27, 161, 203, 241, 3, 43, 206, 84, 180, 46, 70, 216, 109, 83, 33, 206, 92, 178, 168, 177 }, new byte[] { 162, 80, 172, 204, 236, 212, 228, 138, 49, 161, 153, 223, 74, 185, 191, 98, 164, 128, 63, 249, 31, 102, 162, 232, 254, 140, 201, 46, 89, 110, 86, 39, 90, 18, 87, 27, 13, 221, 236, 169, 224, 68, 153, 107, 36, 129, 221, 68, 186, 174, 25, 7, 110, 96, 225, 34, 185, 146, 185, 58, 115, 212, 139, 148, 136, 0, 228, 109, 237, 210, 108, 230, 127, 54, 140, 96, 65, 232, 204, 11, 145, 169, 210, 44, 43, 223, 99, 44, 212, 148, 245, 184, 15, 162, 172, 114, 2, 17, 116, 175, 231, 75, 199, 1, 102, 73, 234, 65, 200, 57, 166, 110, 156, 4, 201, 61, 223, 102, 83, 169, 11, 148, 111, 53, 55, 46, 43, 175 } });

            migrationBuilder.AddForeignKey(
                name: "FK_SnackOrders_Snacks_SnackId",
                table: "SnackOrders",
                column: "SnackId",
                principalTable: "Snacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Bookings_BookingId",
                table: "Tickets",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SnackOrders_Snacks_SnackId",
                table: "SnackOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Bookings_BookingId",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 231, 225, 186, 45, 176, 150, 170, 171, 137, 80, 169, 245, 82, 75, 146, 50, 90, 208, 29, 68, 111, 217, 3, 187, 44, 162, 206, 43, 172, 235, 46, 203, 129, 156, 42, 133, 45, 242, 28, 28, 41, 180, 55, 95, 238, 116, 35, 242, 3, 98, 227, 20, 17, 217, 60, 126, 18, 155, 172, 46, 45, 133, 197, 208 }, new byte[] { 11, 15, 106, 146, 1, 36, 33, 75, 191, 225, 206, 220, 229, 22, 89, 199, 251, 241, 246, 22, 75, 170, 193, 218, 181, 110, 99, 31, 30, 32, 177, 110, 107, 196, 36, 26, 236, 85, 138, 218, 62, 223, 51, 43, 86, 61, 217, 103, 114, 252, 221, 177, 22, 238, 214, 141, 90, 246, 43, 86, 30, 202, 115, 156, 149, 192, 148, 146, 144, 22, 129, 108, 158, 247, 75, 161, 213, 122, 27, 239, 223, 91, 199, 214, 233, 13, 58, 242, 235, 241, 112, 203, 245, 230, 133, 224, 159, 86, 5, 191, 223, 143, 68, 148, 165, 185, 251, 61, 173, 48, 112, 117, 149, 244, 255, 35, 139, 152, 32, 106, 161, 87, 141, 141, 211, 37, 154, 33 } });

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 235, 182, 165, 67, 151, 75, 75, 109, 223, 236, 80, 73, 124, 254, 189, 237, 204, 130, 54, 209, 102, 177, 127, 223, 46, 72, 214, 244, 137, 158, 130, 233, 65, 1, 70, 78, 157, 234, 243, 227, 225, 32, 17, 156, 216, 50, 129, 65, 63, 204, 4, 248, 92, 216, 144, 102, 203, 126, 250, 192, 172, 13, 72, 99 }, new byte[] { 179, 195, 223, 197, 158, 113, 118, 250, 121, 108, 156, 68, 93, 138, 131, 167, 65, 21, 31, 209, 225, 213, 225, 217, 250, 168, 197, 151, 125, 61, 41, 160, 13, 214, 216, 149, 245, 165, 101, 239, 171, 123, 100, 85, 85, 156, 236, 88, 68, 125, 198, 3, 113, 205, 219, 206, 118, 29, 158, 117, 7, 219, 171, 240, 99, 50, 241, 5, 32, 111, 4, 51, 55, 182, 63, 84, 83, 197, 158, 80, 103, 108, 156, 50, 98, 212, 118, 138, 94, 61, 98, 64, 139, 17, 138, 238, 35, 146, 184, 86, 248, 74, 122, 106, 173, 211, 141, 201, 182, 255, 77, 66, 163, 146, 223, 222, 123, 116, 159, 34, 244, 10, 221, 60, 220, 72, 14, 179 } });

            migrationBuilder.AddForeignKey(
                name: "FK_SnackOrders_Snacks_SnackId",
                table: "SnackOrders",
                column: "SnackId",
                principalTable: "Snacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Bookings_BookingId",
                table: "Tickets",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
