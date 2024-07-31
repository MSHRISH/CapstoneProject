using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class MemberShipConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CastCrews_MemberTypes_memberTypeId",
                table: "CastCrews");

            migrationBuilder.DropColumn(
                name: "MemberType",
                table: "CastCrews");

            migrationBuilder.RenameColumn(
                name: "memberTypeId",
                table: "CastCrews",
                newName: "MemberTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CastCrews_memberTypeId",
                table: "CastCrews",
                newName: "IX_CastCrews_MemberTypeId");

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 176, 9, 124, 43, 91, 24, 42, 8, 163, 25, 144, 93, 175, 225, 128, 104, 167, 217, 190, 3, 95, 209, 128, 110, 163, 181, 16, 247, 110, 90, 141, 55, 155, 49, 228, 226, 105, 231, 255, 99, 146, 166, 1, 176, 45, 90, 222, 120, 169, 145, 27, 157, 78, 221, 199, 7, 246, 232, 55, 18, 240, 178, 138, 59 }, new byte[] { 74, 47, 174, 89, 127, 161, 2, 137, 5, 199, 238, 77, 35, 118, 65, 32, 110, 91, 220, 133, 204, 96, 14, 181, 221, 135, 225, 0, 158, 17, 77, 199, 117, 6, 188, 154, 216, 95, 23, 245, 234, 40, 222, 124, 233, 206, 190, 102, 167, 68, 25, 74, 254, 177, 220, 51, 12, 4, 195, 216, 55, 127, 215, 165, 61, 238, 80, 79, 103, 158, 127, 165, 137, 167, 29, 13, 117, 84, 112, 78, 56, 207, 32, 80, 195, 236, 177, 243, 35, 34, 123, 245, 50, 62, 255, 249, 87, 196, 89, 78, 2, 52, 65, 226, 149, 213, 59, 137, 19, 242, 134, 154, 117, 29, 204, 153, 169, 68, 117, 203, 191, 57, 203, 7, 19, 245, 162, 47 } });

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 35, 198, 148, 180, 153, 226, 11, 134, 56, 33, 191, 225, 133, 203, 204, 235, 87, 161, 171, 124, 218, 234, 22, 101, 120, 175, 212, 214, 143, 117, 235, 88, 57, 239, 155, 60, 203, 169, 118, 123, 113, 97, 171, 22, 56, 36, 140, 116, 23, 238, 187, 114, 244, 133, 183, 171, 52, 12, 63, 83, 219, 44, 17, 131 }, new byte[] { 142, 1, 219, 175, 22, 122, 68, 165, 155, 142, 191, 152, 207, 140, 179, 98, 165, 248, 103, 74, 106, 135, 187, 211, 123, 123, 69, 156, 151, 92, 11, 101, 29, 32, 253, 20, 81, 89, 195, 80, 252, 170, 26, 208, 57, 253, 31, 115, 154, 246, 204, 72, 226, 86, 254, 231, 176, 221, 0, 217, 145, 192, 134, 250, 230, 17, 34, 149, 177, 246, 255, 91, 181, 86, 76, 157, 221, 210, 124, 104, 246, 225, 188, 221, 168, 126, 135, 168, 225, 159, 175, 2, 76, 57, 103, 172, 63, 202, 215, 149, 35, 199, 52, 13, 127, 198, 154, 98, 0, 78, 133, 63, 50, 242, 165, 137, 245, 122, 176, 1, 189, 194, 216, 231, 85, 11, 176, 243 } });

            migrationBuilder.AddForeignKey(
                name: "FK_CastCrews_MemberTypes_MemberTypeId",
                table: "CastCrews",
                column: "MemberTypeId",
                principalTable: "MemberTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CastCrews_MemberTypes_MemberTypeId",
                table: "CastCrews");

            migrationBuilder.RenameColumn(
                name: "MemberTypeId",
                table: "CastCrews",
                newName: "memberTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CastCrews_MemberTypeId",
                table: "CastCrews",
                newName: "IX_CastCrews_memberTypeId");

            migrationBuilder.AddColumn<int>(
                name: "MemberType",
                table: "CastCrews",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "FK_CastCrews_MemberTypes_memberTypeId",
                table: "CastCrews",
                column: "memberTypeId",
                principalTable: "MemberTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
