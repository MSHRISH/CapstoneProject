﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class UpdateShows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowTime",
                table: "Shows");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Shows",
                newName: "ShowDateTime");

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 162, 57, 31, 178, 132, 40, 148, 187, 185, 249, 99, 216, 34, 147, 150, 40, 64, 40, 197, 129, 20, 122, 154, 184, 205, 28, 55, 44, 22, 76, 201, 138, 171, 43, 147, 250, 213, 24, 175, 113, 184, 81, 203, 237, 54, 211, 195, 227, 155, 75, 197, 44, 245, 218, 137, 24, 167, 108, 147, 201, 133, 199, 59, 100 }, new byte[] { 172, 13, 60, 16, 90, 91, 20, 106, 49, 157, 66, 105, 14, 29, 209, 196, 111, 25, 40, 90, 233, 102, 224, 23, 106, 105, 140, 210, 72, 1, 249, 22, 173, 23, 77, 183, 83, 72, 188, 201, 230, 98, 95, 117, 179, 98, 55, 124, 198, 233, 125, 126, 107, 148, 132, 142, 91, 245, 40, 69, 242, 117, 135, 126, 0, 146, 154, 137, 3, 41, 123, 162, 20, 90, 58, 109, 58, 23, 110, 86, 102, 111, 187, 196, 219, 169, 241, 206, 183, 153, 181, 129, 232, 38, 26, 44, 81, 43, 220, 140, 100, 166, 225, 24, 212, 87, 180, 163, 8, 84, 178, 189, 150, 133, 54, 174, 90, 208, 125, 50, 174, 211, 29, 111, 21, 17, 101, 52 } });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShowDateTime",
                value: new DateTime(2024, 8, 15, 14, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 59, 39, 114, 191, 192, 17, 255, 134, 187, 215, 18, 179, 131, 77, 129, 100, 88, 187, 70, 243, 26, 11, 19, 94, 240, 111, 37, 100, 232, 10, 64, 183, 198, 252, 237, 170, 64, 184, 135, 198, 178, 163, 35, 220, 198, 61, 5, 222, 65, 211, 164, 193, 102, 120, 159, 151, 177, 222, 39, 109, 175, 44, 188, 83 }, new byte[] { 139, 243, 14, 7, 112, 127, 61, 87, 36, 62, 133, 198, 192, 73, 0, 19, 64, 211, 199, 139, 77, 51, 222, 40, 237, 172, 121, 106, 187, 238, 225, 94, 29, 70, 221, 184, 205, 178, 169, 37, 216, 200, 125, 50, 103, 88, 102, 238, 180, 79, 48, 164, 80, 172, 17, 58, 216, 218, 129, 141, 208, 169, 185, 136, 175, 189, 142, 98, 9, 16, 253, 198, 141, 77, 102, 252, 157, 231, 233, 185, 218, 101, 204, 204, 210, 0, 11, 127, 102, 194, 157, 33, 135, 252, 55, 157, 24, 219, 20, 40, 9, 149, 85, 48, 121, 255, 167, 103, 237, 213, 48, 65, 120, 92, 13, 76, 191, 184, 45, 143, 123, 187, 97, 145, 138, 132, 17, 63 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShowDateTime",
                table: "Shows",
                newName: "Date");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ShowTime",
                table: "Shows",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 176, 9, 124, 43, 91, 24, 42, 8, 163, 25, 144, 93, 175, 225, 128, 104, 167, 217, 190, 3, 95, 209, 128, 110, 163, 181, 16, 247, 110, 90, 141, 55, 155, 49, 228, 226, 105, 231, 255, 99, 146, 166, 1, 176, 45, 90, 222, 120, 169, 145, 27, 157, 78, 221, 199, 7, 246, 232, 55, 18, 240, 178, 138, 59 }, new byte[] { 74, 47, 174, 89, 127, 161, 2, 137, 5, 199, 238, 77, 35, 118, 65, 32, 110, 91, 220, 133, 204, 96, 14, 181, 221, 135, 225, 0, 158, 17, 77, 199, 117, 6, 188, 154, 216, 95, 23, 245, 234, 40, 222, 124, 233, 206, 190, 102, 167, 68, 25, 74, 254, 177, 220, 51, 12, 4, 195, 216, 55, 127, 215, 165, 61, 238, 80, 79, 103, 158, 127, 165, 137, 167, 29, 13, 117, 84, 112, 78, 56, 207, 32, 80, 195, 236, 177, 243, 35, 34, 123, 245, 50, 62, 255, 249, 87, 196, 89, 78, 2, 52, 65, 226, 149, 213, 59, 137, 19, 242, 134, 154, 117, 29, 204, 153, 169, 68, 117, 203, 191, 57, 203, 7, 19, 245, 162, 47 } });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "ShowTime" },
                values: new object[] { new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 35, 198, 148, 180, 153, 226, 11, 134, 56, 33, 191, 225, 133, 203, 204, 235, 87, 161, 171, 124, 218, 234, 22, 101, 120, 175, 212, 214, 143, 117, 235, 88, 57, 239, 155, 60, 203, 169, 118, 123, 113, 97, 171, 22, 56, 36, 140, 116, 23, 238, 187, 114, 244, 133, 183, 171, 52, 12, 63, 83, 219, 44, 17, 131 }, new byte[] { 142, 1, 219, 175, 22, 122, 68, 165, 155, 142, 191, 152, 207, 140, 179, 98, 165, 248, 103, 74, 106, 135, 187, 211, 123, 123, 69, 156, 151, 92, 11, 101, 29, 32, 253, 20, 81, 89, 195, 80, 252, 170, 26, 208, 57, 253, 31, 115, 154, 246, 204, 72, 226, 86, 254, 231, 176, 221, 0, 217, 145, 192, 134, 250, 230, 17, 34, 149, 177, 246, 255, 91, 181, 86, 76, 157, 221, 210, 124, 104, 246, 225, 188, 221, 168, 126, 135, 168, 225, 159, 175, 2, 76, 57, 103, 172, 63, 202, 215, 149, 35, 199, 52, 13, 127, 198, 154, 98, 0, 78, 133, 63, 50, 242, 165, 137, 245, 122, 176, 1, 189, 194, 216, 231, 85, 11, 176, 243 } });
        }
    }
}
