using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class MemberTypesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberType",
                table: "CastCrews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "memberTypeId",
                table: "CastCrews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MemberTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 47, 14, 141, 100, 108, 199, 213, 16, 68, 149, 77, 44, 97, 171, 3, 237, 127, 160, 93, 136, 48, 156, 230, 212, 173, 170, 120, 119, 9, 203, 190, 27, 134, 206, 92, 198, 190, 31, 105, 57, 122, 205, 165, 38, 80, 91, 133, 219, 12, 103, 61, 52, 222, 170, 20, 172, 183, 115, 215, 226, 75, 250, 58, 174 }, new byte[] { 140, 154, 131, 247, 169, 166, 164, 98, 24, 107, 194, 160, 67, 224, 91, 253, 118, 192, 250, 142, 110, 132, 218, 134, 164, 122, 51, 238, 37, 233, 58, 136, 51, 232, 140, 67, 209, 247, 28, 24, 7, 12, 172, 192, 161, 28, 24, 238, 63, 47, 199, 166, 54, 29, 37, 208, 9, 62, 224, 224, 96, 41, 60, 240, 71, 91, 172, 223, 50, 130, 32, 242, 28, 142, 166, 246, 125, 65, 61, 125, 10, 240, 226, 203, 45, 225, 121, 218, 193, 188, 146, 8, 19, 118, 138, 170, 37, 241, 73, 176, 179, 212, 32, 151, 137, 216, 84, 251, 241, 94, 95, 204, 140, 77, 183, 80, 200, 180, 11, 161, 93, 239, 154, 57, 195, 242, 182, 245 } });

            migrationBuilder.InsertData(
                table: "MemberTypes",
                columns: new[] { "Id", "MemberName" },
                values: new object[] { 1, "Cast" });

            migrationBuilder.InsertData(
                table: "MemberTypes",
                columns: new[] { "Id", "MemberName" },
                values: new object[] { 2, "Crew" });

            migrationBuilder.CreateIndex(
                name: "IX_CastCrews_memberTypeId",
                table: "CastCrews",
                column: "memberTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CastCrews_MemberTypes_memberTypeId",
                table: "CastCrews",
                column: "memberTypeId",
                principalTable: "MemberTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CastCrews_MemberTypes_memberTypeId",
                table: "CastCrews");

            migrationBuilder.DropTable(
                name: "MemberTypes");

            migrationBuilder.DropIndex(
                name: "IX_CastCrews_memberTypeId",
                table: "CastCrews");

            migrationBuilder.DropColumn(
                name: "MemberType",
                table: "CastCrews");

            migrationBuilder.DropColumn(
                name: "memberTypeId",
                table: "CastCrews");

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 79, 222, 62, 66, 151, 71, 106, 62, 89, 235, 148, 50, 245, 128, 101, 152, 103, 68, 245, 72, 116, 13, 59, 41, 232, 25, 23, 6, 255, 205, 13, 71, 86, 4, 205, 246, 3, 222, 236, 42, 160, 252, 74, 129, 206, 5, 153, 216, 121, 69, 159, 98, 176, 174, 153, 103, 123, 28, 109, 12, 161, 89, 20, 229 }, new byte[] { 82, 253, 16, 102, 249, 252, 236, 250, 79, 70, 239, 153, 111, 199, 89, 189, 234, 30, 15, 41, 39, 220, 245, 84, 70, 236, 31, 117, 56, 245, 82, 193, 64, 132, 191, 16, 122, 112, 59, 134, 135, 75, 205, 124, 149, 78, 118, 148, 176, 54, 172, 7, 84, 12, 106, 188, 249, 111, 110, 13, 171, 118, 69, 141, 40, 12, 41, 12, 46, 83, 42, 187, 120, 152, 254, 188, 85, 146, 55, 61, 114, 126, 156, 27, 87, 174, 13, 145, 217, 221, 46, 222, 103, 115, 144, 31, 70, 163, 200, 31, 131, 237, 201, 106, 219, 77, 130, 203, 119, 72, 212, 98, 140, 29, 177, 196, 54, 8, 150, 254, 42, 106, 233, 150, 245, 157, 130, 208 } });
        }
    }
}
