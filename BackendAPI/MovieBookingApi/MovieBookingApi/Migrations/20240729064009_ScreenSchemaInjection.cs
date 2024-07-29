using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class ScreenSchemaInjection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Column",
                table: "ScreenSchemas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 238, 158, 143, 65, 74, 113, 206, 126, 66, 142, 166, 62, 49, 33, 237, 162, 65, 230, 138, 254, 166, 236, 119, 222, 233, 229, 239, 228, 47, 42, 165, 186, 234, 79, 94, 253, 61, 143, 251, 164, 135, 225, 137, 237, 47, 57, 193, 81, 5, 251, 99, 201, 145, 66, 75, 78, 166, 138, 65, 139, 180, 250, 129, 235 }, new byte[] { 80, 86, 251, 104, 219, 19, 170, 2, 132, 163, 205, 83, 164, 96, 65, 219, 231, 42, 39, 40, 147, 130, 254, 22, 40, 12, 246, 101, 39, 69, 174, 215, 185, 129, 245, 143, 102, 204, 189, 189, 67, 35, 245, 223, 10, 20, 5, 48, 70, 96, 181, 13, 32, 17, 120, 204, 137, 168, 22, 183, 188, 31, 253, 69, 74, 238, 40, 106, 254, 151, 81, 89, 212, 211, 139, 193, 219, 214, 91, 156, 170, 29, 25, 10, 149, 82, 105, 22, 138, 231, 17, 215, 33, 109, 58, 245, 27, 43, 234, 70, 107, 54, 232, 90, 31, 145, 192, 75, 60, 154, 205, 119, 165, 222, 215, 190, 80, 121, 87, 141, 164, 200, 123, 28, 5, 166, 84, 235 } });

            migrationBuilder.InsertData(
                table: "Schemas",
                columns: new[] { "Id", "ColumnDimension", "Name", "RowDimension" },
                values: new object[] { 1, 16, "Schema 1", 15 });

            migrationBuilder.InsertData(
                table: "Theaters",
                columns: new[] { "Id", "Address", "District", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "xyz,xxx", "Chennai", "INOX Theater", "1231231231" },
                    { 2, "asd,asd", "Chennai", "Rohini Theater", "1234123434" },
                    { 3, "qwe,asd", "Chennai", "Theater X", "1234512345" }
                });

            migrationBuilder.InsertData(
                table: "ScreenSchemas",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 1, 0, false, 100f, 1, 1 },
                    { 2, 1, false, 100f, 1, 1 },
                    { 3, 2, false, 100f, 1, 1 },
                    { 4, 3, false, 100f, 1, 1 },
                    { 5, 4, false, 100f, 1, 1 },
                    { 6, 5, false, 100f, 1, 1 },
                    { 7, 6, false, 100f, 1, 1 },
                    { 8, 7, true, 100f, 1, 1 },
                    { 9, 8, true, 100f, 1, 1 },
                    { 10, 9, false, 100f, 1, 1 },
                    { 11, 10, false, 100f, 1, 1 },
                    { 12, 11, false, 100f, 1, 1 },
                    { 13, 12, false, 100f, 1, 1 },
                    { 14, 13, false, 100f, 1, 1 },
                    { 15, 14, false, 100f, 1, 1 },
                    { 16, 15, false, 100f, 1, 1 },
                    { 17, 0, false, 100f, 2, 1 },
                    { 18, 1, false, 100f, 2, 1 },
                    { 19, 2, false, 100f, 2, 1 },
                    { 20, 3, false, 100f, 2, 1 },
                    { 21, 4, false, 100f, 2, 1 },
                    { 22, 5, false, 100f, 2, 1 },
                    { 23, 6, false, 100f, 2, 1 },
                    { 24, 7, true, 100f, 2, 1 },
                    { 25, 8, true, 100f, 2, 1 },
                    { 26, 9, false, 100f, 2, 1 },
                    { 27, 10, false, 100f, 2, 1 },
                    { 28, 11, false, 100f, 2, 1 },
                    { 29, 12, false, 100f, 2, 1 },
                    { 30, 13, false, 100f, 2, 1 },
                    { 31, 14, false, 100f, 2, 1 },
                    { 32, 15, false, 100f, 2, 1 },
                    { 33, 0, false, 100f, 3, 1 },
                    { 34, 1, false, 100f, 3, 1 },
                    { 35, 2, false, 100f, 3, 1 },
                    { 36, 3, false, 100f, 3, 1 },
                    { 37, 4, false, 100f, 3, 1 },
                    { 38, 5, false, 100f, 3, 1 },
                    { 39, 6, false, 100f, 3, 1 },
                    { 40, 7, true, 100f, 3, 1 },
                    { 41, 8, true, 100f, 3, 1 },
                    { 42, 9, false, 100f, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenSchemas",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 43, 10, false, 100f, 3, 1 },
                    { 44, 11, false, 100f, 3, 1 },
                    { 45, 12, false, 100f, 3, 1 },
                    { 46, 13, false, 100f, 3, 1 },
                    { 47, 14, false, 100f, 3, 1 },
                    { 48, 15, false, 100f, 3, 1 },
                    { 49, 0, false, 100f, 4, 1 },
                    { 50, 1, false, 100f, 4, 1 },
                    { 51, 2, false, 100f, 4, 1 },
                    { 52, 3, false, 100f, 4, 1 },
                    { 53, 4, false, 100f, 4, 1 },
                    { 54, 5, false, 100f, 4, 1 },
                    { 55, 6, false, 100f, 4, 1 },
                    { 56, 7, true, 100f, 4, 1 },
                    { 57, 8, true, 100f, 4, 1 },
                    { 58, 9, false, 100f, 4, 1 },
                    { 59, 10, false, 100f, 4, 1 },
                    { 60, 11, false, 100f, 4, 1 },
                    { 61, 12, false, 100f, 4, 1 },
                    { 62, 13, false, 100f, 4, 1 },
                    { 63, 14, false, 100f, 4, 1 },
                    { 64, 15, false, 100f, 4, 1 },
                    { 65, 0, false, 100f, 5, 1 },
                    { 66, 1, false, 100f, 5, 1 },
                    { 67, 2, false, 100f, 5, 1 },
                    { 68, 3, false, 100f, 5, 1 },
                    { 69, 4, false, 100f, 5, 1 },
                    { 70, 5, false, 100f, 5, 1 },
                    { 71, 6, false, 100f, 5, 1 },
                    { 72, 7, true, 100f, 5, 1 },
                    { 73, 8, true, 100f, 5, 1 },
                    { 74, 9, false, 100f, 5, 1 },
                    { 75, 10, false, 100f, 5, 1 },
                    { 76, 11, false, 100f, 5, 1 },
                    { 77, 12, false, 100f, 5, 1 },
                    { 78, 13, false, 100f, 5, 1 },
                    { 79, 14, false, 100f, 5, 1 },
                    { 80, 15, false, 100f, 5, 1 },
                    { 81, 0, false, 100f, 6, 1 },
                    { 82, 1, false, 100f, 6, 1 },
                    { 83, 2, false, 100f, 6, 1 },
                    { 84, 3, false, 100f, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenSchemas",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 85, 4, false, 100f, 6, 1 },
                    { 86, 5, false, 100f, 6, 1 },
                    { 87, 6, false, 100f, 6, 1 },
                    { 88, 7, true, 100f, 6, 1 },
                    { 89, 8, true, 100f, 6, 1 },
                    { 90, 9, false, 100f, 6, 1 },
                    { 91, 10, false, 100f, 6, 1 },
                    { 92, 11, false, 100f, 6, 1 },
                    { 93, 12, false, 100f, 6, 1 },
                    { 94, 13, false, 100f, 6, 1 },
                    { 95, 14, false, 100f, 6, 1 },
                    { 96, 15, false, 100f, 6, 1 },
                    { 97, 0, false, 100f, 7, 1 },
                    { 98, 1, false, 100f, 7, 1 },
                    { 99, 2, false, 100f, 7, 1 },
                    { 100, 3, false, 100f, 7, 1 },
                    { 101, 4, false, 100f, 7, 1 },
                    { 102, 5, false, 100f, 7, 1 },
                    { 103, 6, false, 100f, 7, 1 },
                    { 104, 7, true, 100f, 7, 1 },
                    { 105, 8, true, 100f, 7, 1 },
                    { 106, 9, false, 100f, 7, 1 },
                    { 107, 10, false, 100f, 7, 1 },
                    { 108, 11, false, 100f, 7, 1 },
                    { 109, 12, false, 100f, 7, 1 },
                    { 110, 13, false, 100f, 7, 1 },
                    { 111, 14, false, 100f, 7, 1 },
                    { 112, 15, false, 100f, 7, 1 },
                    { 113, 0, false, 100f, 8, 1 },
                    { 114, 1, false, 100f, 8, 1 },
                    { 115, 2, false, 100f, 8, 1 },
                    { 116, 3, false, 100f, 8, 1 },
                    { 117, 4, false, 100f, 8, 1 },
                    { 118, 5, false, 100f, 8, 1 },
                    { 119, 6, false, 100f, 8, 1 },
                    { 120, 7, true, 100f, 8, 1 },
                    { 121, 8, true, 100f, 8, 1 },
                    { 122, 9, false, 100f, 8, 1 },
                    { 123, 10, false, 100f, 8, 1 },
                    { 124, 11, false, 100f, 8, 1 },
                    { 125, 12, false, 100f, 8, 1 },
                    { 126, 13, false, 100f, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenSchemas",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 127, 14, false, 100f, 8, 1 },
                    { 128, 15, false, 100f, 8, 1 },
                    { 129, 0, false, 100f, 9, 1 },
                    { 130, 1, false, 100f, 9, 1 },
                    { 131, 2, false, 100f, 9, 1 },
                    { 132, 3, false, 100f, 9, 1 },
                    { 133, 4, false, 100f, 9, 1 },
                    { 134, 5, false, 100f, 9, 1 },
                    { 135, 6, false, 100f, 9, 1 },
                    { 136, 7, true, 100f, 9, 1 },
                    { 137, 8, true, 100f, 9, 1 },
                    { 138, 9, false, 100f, 9, 1 },
                    { 139, 10, false, 100f, 9, 1 },
                    { 140, 11, false, 100f, 9, 1 },
                    { 141, 12, false, 100f, 9, 1 },
                    { 142, 13, false, 100f, 9, 1 },
                    { 143, 14, false, 100f, 9, 1 },
                    { 144, 15, false, 100f, 9, 1 },
                    { 145, 0, true, 100f, 10, 1 },
                    { 146, 1, true, 100f, 10, 1 },
                    { 147, 2, true, 100f, 10, 1 },
                    { 148, 3, true, 100f, 10, 1 },
                    { 149, 4, true, 100f, 10, 1 },
                    { 150, 5, true, 100f, 10, 1 },
                    { 151, 6, true, 100f, 10, 1 },
                    { 152, 7, true, 100f, 10, 1 },
                    { 153, 8, true, 100f, 10, 1 },
                    { 154, 9, true, 100f, 10, 1 },
                    { 155, 10, true, 100f, 10, 1 },
                    { 156, 11, true, 100f, 10, 1 },
                    { 157, 12, true, 100f, 10, 1 },
                    { 158, 13, true, 100f, 10, 1 },
                    { 159, 14, true, 100f, 10, 1 },
                    { 160, 15, true, 100f, 10, 1 },
                    { 161, 0, true, 100f, 11, 1 },
                    { 162, 1, true, 100f, 11, 1 },
                    { 163, 2, true, 100f, 11, 1 },
                    { 164, 3, true, 100f, 11, 1 },
                    { 165, 4, true, 100f, 11, 1 },
                    { 166, 5, true, 100f, 11, 1 },
                    { 167, 6, true, 100f, 11, 1 },
                    { 168, 7, true, 100f, 11, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenSchemas",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 169, 8, true, 100f, 11, 1 },
                    { 170, 9, true, 100f, 11, 1 },
                    { 171, 10, true, 100f, 11, 1 },
                    { 172, 11, true, 100f, 11, 1 },
                    { 173, 12, true, 100f, 11, 1 },
                    { 174, 13, true, 100f, 11, 1 },
                    { 175, 14, true, 100f, 11, 1 },
                    { 176, 15, true, 100f, 11, 1 },
                    { 177, 0, false, 100f, 12, 1 },
                    { 178, 1, false, 100f, 12, 1 },
                    { 179, 2, false, 100f, 12, 1 },
                    { 180, 3, false, 100f, 12, 1 },
                    { 181, 4, false, 100f, 12, 1 },
                    { 182, 5, false, 100f, 12, 1 },
                    { 183, 6, false, 100f, 12, 1 },
                    { 184, 7, true, 100f, 12, 1 },
                    { 185, 8, true, 100f, 12, 1 },
                    { 186, 9, false, 100f, 12, 1 },
                    { 187, 10, false, 100f, 12, 1 },
                    { 188, 11, false, 100f, 12, 1 },
                    { 189, 12, false, 100f, 12, 1 },
                    { 190, 13, false, 100f, 12, 1 },
                    { 191, 14, false, 100f, 12, 1 },
                    { 192, 15, false, 100f, 12, 1 },
                    { 193, 0, false, 100f, 13, 1 },
                    { 194, 1, false, 100f, 13, 1 },
                    { 195, 2, false, 100f, 13, 1 },
                    { 196, 3, false, 100f, 13, 1 },
                    { 197, 4, false, 100f, 13, 1 },
                    { 198, 5, false, 100f, 13, 1 },
                    { 199, 6, false, 100f, 13, 1 },
                    { 200, 7, true, 100f, 13, 1 },
                    { 201, 8, true, 100f, 13, 1 },
                    { 202, 9, false, 100f, 13, 1 },
                    { 203, 10, false, 100f, 13, 1 },
                    { 204, 11, false, 100f, 13, 1 },
                    { 205, 12, false, 100f, 13, 1 },
                    { 206, 13, false, 100f, 13, 1 },
                    { 207, 14, false, 100f, 13, 1 },
                    { 208, 15, false, 100f, 13, 1 },
                    { 209, 0, false, 100f, 14, 1 },
                    { 210, 1, false, 100f, 14, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenSchemas",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 211, 2, false, 100f, 14, 1 },
                    { 212, 3, false, 100f, 14, 1 },
                    { 213, 4, false, 100f, 14, 1 },
                    { 214, 5, false, 100f, 14, 1 },
                    { 215, 6, false, 100f, 14, 1 },
                    { 216, 7, true, 100f, 14, 1 },
                    { 217, 8, true, 100f, 14, 1 },
                    { 218, 9, false, 100f, 14, 1 },
                    { 219, 10, false, 100f, 14, 1 },
                    { 220, 11, false, 100f, 14, 1 },
                    { 221, 12, false, 100f, 14, 1 },
                    { 222, 13, false, 100f, 14, 1 },
                    { 223, 14, false, 100f, 14, 1 },
                    { 224, 15, false, 100f, 14, 1 }
                });

            migrationBuilder.InsertData(
                table: "Screens",
                columns: new[] { "Id", "SchemaId", "ScreenName", "TheaterId" },
                values: new object[] { 1, 1, "Screen 1", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ScreenSchemas",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schemas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Column",
                table: "ScreenSchemas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 200, 106, 6, 2, 153, 38, 235, 15, 227, 20, 200, 157, 194, 147, 116, 151, 227, 128, 35, 165, 77, 149, 252, 24, 193, 162, 112, 170, 153, 20, 237, 145, 155, 143, 2, 89, 244, 236, 50, 27, 196, 229, 69, 8, 21, 140, 235, 197, 171, 160, 125, 186, 49, 14, 140, 112, 196, 113, 244, 40, 222, 111, 13, 243 }, new byte[] { 103, 25, 225, 183, 199, 166, 6, 79, 110, 137, 210, 216, 17, 231, 36, 197, 84, 54, 192, 42, 84, 87, 230, 205, 66, 198, 201, 30, 204, 106, 46, 203, 185, 170, 21, 69, 210, 187, 68, 97, 159, 21, 215, 182, 203, 106, 190, 167, 171, 179, 62, 75, 53, 150, 67, 196, 169, 235, 157, 1, 166, 66, 115, 222, 74, 99, 27, 79, 88, 150, 60, 178, 172, 162, 228, 199, 214, 92, 42, 155, 65, 77, 45, 43, 92, 53, 27, 205, 20, 60, 234, 179, 223, 47, 65, 64, 89, 10, 179, 133, 27, 56, 134, 22, 19, 108, 69, 18, 123, 167, 121, 84, 111, 30, 79, 209, 206, 222, 30, 226, 31, 105, 205, 220, 181, 222, 97, 231 } });
        }
    }
}
