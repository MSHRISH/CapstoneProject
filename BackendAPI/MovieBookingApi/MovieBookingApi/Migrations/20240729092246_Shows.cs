using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class Shows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_ScreenSchemas_SeatId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "ScreenSchemas");

            migrationBuilder.CreateTable(
                name: "ScreenLayouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchemaId = table.Column<int>(type: "int", nullable: false),
                    Row = table.Column<int>(type: "int", nullable: false),
                    Column = table.Column<int>(type: "int", nullable: false),
                    IsSeat = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenLayouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScreenLayouts_Schemas_SchemaId",
                        column: x => x.SchemaId,
                        principalTable: "Schemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 140, 239, 238, 73, 226, 165, 213, 172, 148, 192, 11, 73, 59, 230, 1, 95, 77, 249, 0, 114, 236, 88, 152, 132, 135, 109, 119, 13, 160, 115, 150, 201, 151, 203, 189, 55, 241, 205, 140, 42, 122, 64, 60, 62, 93, 228, 242, 19, 96, 12, 28, 172, 224, 0, 171, 134, 43, 87, 132, 14, 11, 226, 134, 37 }, new byte[] { 78, 75, 45, 34, 165, 54, 17, 52, 160, 145, 49, 100, 193, 27, 207, 136, 73, 142, 202, 91, 159, 207, 232, 180, 163, 62, 135, 240, 192, 15, 2, 140, 213, 104, 193, 109, 119, 132, 141, 60, 35, 79, 76, 51, 87, 179, 145, 100, 196, 230, 76, 141, 192, 218, 32, 220, 205, 155, 160, 214, 65, 91, 198, 142, 170, 231, 115, 17, 174, 57, 228, 201, 239, 102, 125, 111, 111, 161, 144, 142, 137, 185, 199, 220, 231, 211, 38, 14, 193, 249, 238, 220, 149, 125, 38, 175, 47, 179, 104, 5, 5, 107, 207, 157, 1, 156, 53, 185, 200, 102, 180, 225, 9, 88, 200, 39, 64, 120, 122, 215, 53, 48, 4, 100, 110, 157, 142, 107 } });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 1, 0, true, 100f, 1, 1 },
                    { 2, 1, true, 100f, 1, 1 },
                    { 3, 2, true, 100f, 1, 1 },
                    { 4, 3, true, 100f, 1, 1 },
                    { 5, 4, true, 100f, 1, 1 },
                    { 6, 5, true, 100f, 1, 1 },
                    { 7, 6, true, 100f, 1, 1 },
                    { 8, 7, false, 100f, 1, 1 },
                    { 9, 8, false, 100f, 1, 1 },
                    { 10, 9, true, 100f, 1, 1 },
                    { 11, 10, true, 100f, 1, 1 },
                    { 12, 11, true, 100f, 1, 1 },
                    { 13, 12, true, 100f, 1, 1 },
                    { 14, 13, true, 100f, 1, 1 },
                    { 15, 14, true, 100f, 1, 1 },
                    { 16, 15, true, 100f, 1, 1 },
                    { 17, 0, true, 100f, 2, 1 },
                    { 18, 1, true, 100f, 2, 1 },
                    { 19, 2, true, 100f, 2, 1 },
                    { 20, 3, true, 100f, 2, 1 },
                    { 21, 4, true, 100f, 2, 1 },
                    { 22, 5, true, 100f, 2, 1 },
                    { 23, 6, true, 100f, 2, 1 },
                    { 24, 7, false, 100f, 2, 1 },
                    { 25, 8, false, 100f, 2, 1 },
                    { 26, 9, true, 100f, 2, 1 },
                    { 27, 10, true, 100f, 2, 1 },
                    { 28, 11, true, 100f, 2, 1 },
                    { 29, 12, true, 100f, 2, 1 },
                    { 30, 13, true, 100f, 2, 1 },
                    { 31, 14, true, 100f, 2, 1 },
                    { 32, 15, true, 100f, 2, 1 },
                    { 33, 0, true, 100f, 3, 1 },
                    { 34, 1, true, 100f, 3, 1 },
                    { 35, 2, true, 100f, 3, 1 },
                    { 36, 3, true, 100f, 3, 1 },
                    { 37, 4, true, 100f, 3, 1 },
                    { 38, 5, true, 100f, 3, 1 },
                    { 39, 6, true, 100f, 3, 1 },
                    { 40, 7, false, 100f, 3, 1 },
                    { 41, 8, false, 100f, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 42, 9, true, 100f, 3, 1 },
                    { 43, 10, true, 100f, 3, 1 },
                    { 44, 11, true, 100f, 3, 1 },
                    { 45, 12, true, 100f, 3, 1 },
                    { 46, 13, true, 100f, 3, 1 },
                    { 47, 14, true, 100f, 3, 1 },
                    { 48, 15, true, 100f, 3, 1 },
                    { 49, 0, true, 100f, 4, 1 },
                    { 50, 1, true, 100f, 4, 1 },
                    { 51, 2, true, 100f, 4, 1 },
                    { 52, 3, true, 100f, 4, 1 },
                    { 53, 4, true, 100f, 4, 1 },
                    { 54, 5, true, 100f, 4, 1 },
                    { 55, 6, true, 100f, 4, 1 },
                    { 56, 7, false, 100f, 4, 1 },
                    { 57, 8, false, 100f, 4, 1 },
                    { 58, 9, true, 100f, 4, 1 },
                    { 59, 10, true, 100f, 4, 1 },
                    { 60, 11, true, 100f, 4, 1 },
                    { 61, 12, true, 100f, 4, 1 },
                    { 62, 13, true, 100f, 4, 1 },
                    { 63, 14, true, 100f, 4, 1 },
                    { 64, 15, true, 100f, 4, 1 },
                    { 65, 0, true, 100f, 5, 1 },
                    { 66, 1, true, 100f, 5, 1 },
                    { 67, 2, true, 100f, 5, 1 },
                    { 68, 3, true, 100f, 5, 1 },
                    { 69, 4, true, 100f, 5, 1 },
                    { 70, 5, true, 100f, 5, 1 },
                    { 71, 6, true, 100f, 5, 1 },
                    { 72, 7, false, 100f, 5, 1 },
                    { 73, 8, false, 100f, 5, 1 },
                    { 74, 9, true, 100f, 5, 1 },
                    { 75, 10, true, 100f, 5, 1 },
                    { 76, 11, true, 100f, 5, 1 },
                    { 77, 12, true, 100f, 5, 1 },
                    { 78, 13, true, 100f, 5, 1 },
                    { 79, 14, true, 100f, 5, 1 },
                    { 80, 15, true, 100f, 5, 1 },
                    { 81, 0, true, 100f, 6, 1 },
                    { 82, 1, true, 100f, 6, 1 },
                    { 83, 2, true, 100f, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 84, 3, true, 100f, 6, 1 },
                    { 85, 4, true, 100f, 6, 1 },
                    { 86, 5, true, 100f, 6, 1 },
                    { 87, 6, true, 100f, 6, 1 },
                    { 88, 7, false, 100f, 6, 1 },
                    { 89, 8, false, 100f, 6, 1 },
                    { 90, 9, true, 100f, 6, 1 },
                    { 91, 10, true, 100f, 6, 1 },
                    { 92, 11, true, 100f, 6, 1 },
                    { 93, 12, true, 100f, 6, 1 },
                    { 94, 13, true, 100f, 6, 1 },
                    { 95, 14, true, 100f, 6, 1 },
                    { 96, 15, true, 100f, 6, 1 },
                    { 97, 0, true, 100f, 7, 1 },
                    { 98, 1, true, 100f, 7, 1 },
                    { 99, 2, true, 100f, 7, 1 },
                    { 100, 3, true, 100f, 7, 1 },
                    { 101, 4, true, 100f, 7, 1 },
                    { 102, 5, true, 100f, 7, 1 },
                    { 103, 6, true, 100f, 7, 1 },
                    { 104, 7, false, 100f, 7, 1 },
                    { 105, 8, false, 100f, 7, 1 },
                    { 106, 9, true, 100f, 7, 1 },
                    { 107, 10, true, 100f, 7, 1 },
                    { 108, 11, true, 100f, 7, 1 },
                    { 109, 12, true, 100f, 7, 1 },
                    { 110, 13, true, 100f, 7, 1 },
                    { 111, 14, true, 100f, 7, 1 },
                    { 112, 15, true, 100f, 7, 1 },
                    { 113, 0, true, 100f, 8, 1 },
                    { 114, 1, true, 100f, 8, 1 },
                    { 115, 2, true, 100f, 8, 1 },
                    { 116, 3, true, 100f, 8, 1 },
                    { 117, 4, true, 100f, 8, 1 },
                    { 118, 5, true, 100f, 8, 1 },
                    { 119, 6, true, 100f, 8, 1 },
                    { 120, 7, false, 100f, 8, 1 },
                    { 121, 8, false, 100f, 8, 1 },
                    { 122, 9, true, 100f, 8, 1 },
                    { 123, 10, true, 100f, 8, 1 },
                    { 124, 11, true, 100f, 8, 1 },
                    { 125, 12, true, 100f, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 126, 13, true, 100f, 8, 1 },
                    { 127, 14, true, 100f, 8, 1 },
                    { 128, 15, true, 100f, 8, 1 },
                    { 129, 0, true, 100f, 9, 1 },
                    { 130, 1, true, 100f, 9, 1 },
                    { 131, 2, true, 100f, 9, 1 },
                    { 132, 3, true, 100f, 9, 1 },
                    { 133, 4, true, 100f, 9, 1 },
                    { 134, 5, true, 100f, 9, 1 },
                    { 135, 6, true, 100f, 9, 1 },
                    { 136, 7, false, 100f, 9, 1 },
                    { 137, 8, false, 100f, 9, 1 },
                    { 138, 9, true, 100f, 9, 1 },
                    { 139, 10, true, 100f, 9, 1 },
                    { 140, 11, true, 100f, 9, 1 },
                    { 141, 12, true, 100f, 9, 1 },
                    { 142, 13, true, 100f, 9, 1 },
                    { 143, 14, true, 100f, 9, 1 },
                    { 144, 15, true, 100f, 9, 1 },
                    { 145, 0, false, 100f, 10, 1 },
                    { 146, 1, false, 100f, 10, 1 },
                    { 147, 2, false, 100f, 10, 1 },
                    { 148, 3, false, 100f, 10, 1 },
                    { 149, 4, false, 100f, 10, 1 },
                    { 150, 5, false, 100f, 10, 1 },
                    { 151, 6, false, 100f, 10, 1 },
                    { 152, 7, false, 100f, 10, 1 },
                    { 153, 8, false, 100f, 10, 1 },
                    { 154, 9, false, 100f, 10, 1 },
                    { 155, 10, false, 100f, 10, 1 },
                    { 156, 11, false, 100f, 10, 1 },
                    { 157, 12, false, 100f, 10, 1 },
                    { 158, 13, false, 100f, 10, 1 },
                    { 159, 14, false, 100f, 10, 1 },
                    { 160, 15, false, 100f, 10, 1 },
                    { 161, 0, false, 100f, 11, 1 },
                    { 162, 1, false, 100f, 11, 1 },
                    { 163, 2, false, 100f, 11, 1 },
                    { 164, 3, false, 100f, 11, 1 },
                    { 165, 4, false, 100f, 11, 1 },
                    { 166, 5, false, 100f, 11, 1 },
                    { 167, 6, false, 100f, 11, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 168, 7, false, 100f, 11, 1 },
                    { 169, 8, false, 100f, 11, 1 },
                    { 170, 9, false, 100f, 11, 1 },
                    { 171, 10, false, 100f, 11, 1 },
                    { 172, 11, false, 100f, 11, 1 },
                    { 173, 12, false, 100f, 11, 1 },
                    { 174, 13, false, 100f, 11, 1 },
                    { 175, 14, false, 100f, 11, 1 },
                    { 176, 15, false, 100f, 11, 1 },
                    { 177, 0, true, 100f, 12, 1 },
                    { 178, 1, true, 100f, 12, 1 },
                    { 179, 2, true, 100f, 12, 1 },
                    { 180, 3, true, 100f, 12, 1 },
                    { 181, 4, true, 100f, 12, 1 },
                    { 182, 5, true, 100f, 12, 1 },
                    { 183, 6, true, 100f, 12, 1 },
                    { 184, 7, false, 100f, 12, 1 },
                    { 185, 8, false, 100f, 12, 1 },
                    { 186, 9, true, 100f, 12, 1 },
                    { 187, 10, true, 100f, 12, 1 },
                    { 188, 11, true, 100f, 12, 1 },
                    { 189, 12, true, 100f, 12, 1 },
                    { 190, 13, true, 100f, 12, 1 },
                    { 191, 14, true, 100f, 12, 1 },
                    { 192, 15, true, 100f, 12, 1 },
                    { 193, 0, true, 100f, 13, 1 },
                    { 194, 1, true, 100f, 13, 1 },
                    { 195, 2, true, 100f, 13, 1 },
                    { 196, 3, true, 100f, 13, 1 },
                    { 197, 4, true, 100f, 13, 1 },
                    { 198, 5, true, 100f, 13, 1 },
                    { 199, 6, true, 100f, 13, 1 },
                    { 200, 7, false, 100f, 13, 1 },
                    { 201, 8, false, 100f, 13, 1 },
                    { 202, 9, true, 100f, 13, 1 },
                    { 203, 10, true, 100f, 13, 1 },
                    { 204, 11, true, 100f, 13, 1 },
                    { 205, 12, true, 100f, 13, 1 },
                    { 206, 13, true, 100f, 13, 1 },
                    { 207, 14, true, 100f, 13, 1 },
                    { 208, 15, true, 100f, 13, 1 },
                    { 209, 0, true, 100f, 14, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 210, 1, true, 100f, 14, 1 },
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

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Date", "MovieId", "MovieId1", "ScreenId", "ShowTime" },
                values: new object[] { 1, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, new TimeSpan(0, 9, 30, 0, 0) });

            migrationBuilder.CreateIndex(
                name: "IX_ScreenLayouts_SchemaId",
                table: "ScreenLayouts",
                column: "SchemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_ScreenLayouts_SeatId",
                table: "Tickets",
                column: "SeatId",
                principalTable: "ScreenLayouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_ScreenLayouts_SeatId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "ScreenLayouts");

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "ScreenSchemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchemaId = table.Column<int>(type: "int", nullable: false),
                    Column = table.Column<int>(type: "int", nullable: false),
                    IsSeat = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Row = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenSchemas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScreenSchemas_Schemas_SchemaId",
                        column: x => x.SchemaId,
                        principalTable: "Schemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 150, 94, 223, 60, 118, 235, 216, 76, 183, 14, 150, 90, 115, 204, 226, 151, 13, 55, 158, 120, 217, 205, 71, 191, 138, 130, 111, 232, 238, 13, 145, 59, 140, 191, 139, 202, 255, 37, 237, 76, 182, 94, 91, 237, 214, 112, 249, 83, 251, 161, 103, 74, 242, 218, 144, 195, 44, 110, 31, 192, 75, 3, 157, 105 }, new byte[] { 245, 227, 41, 189, 6, 120, 56, 139, 41, 68, 202, 208, 54, 151, 76, 230, 232, 163, 223, 54, 232, 23, 45, 192, 13, 12, 31, 17, 74, 202, 220, 158, 113, 172, 190, 116, 234, 145, 212, 221, 212, 49, 210, 88, 13, 106, 217, 4, 172, 80, 236, 44, 230, 78, 180, 158, 67, 40, 124, 45, 0, 8, 231, 171, 76, 35, 4, 78, 230, 241, 43, 136, 152, 85, 255, 110, 64, 215, 108, 47, 140, 35, 202, 162, 41, 191, 85, 252, 234, 53, 206, 123, 174, 198, 49, 58, 92, 85, 187, 118, 74, 210, 45, 131, 52, 125, 131, 76, 162, 110, 89, 52, 235, 114, 24, 205, 233, 215, 28, 141, 241, 12, 222, 12, 150, 15, 198, 184 } });

            migrationBuilder.InsertData(
                table: "ScreenSchemas",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 1, 0, true, 100f, 1, 1 },
                    { 2, 1, true, 100f, 1, 1 },
                    { 3, 2, true, 100f, 1, 1 },
                    { 4, 3, true, 100f, 1, 1 },
                    { 5, 4, true, 100f, 1, 1 },
                    { 6, 5, true, 100f, 1, 1 },
                    { 7, 6, true, 100f, 1, 1 },
                    { 8, 7, false, 100f, 1, 1 },
                    { 9, 8, false, 100f, 1, 1 },
                    { 10, 9, true, 100f, 1, 1 },
                    { 11, 10, true, 100f, 1, 1 },
                    { 12, 11, true, 100f, 1, 1 },
                    { 13, 12, true, 100f, 1, 1 },
                    { 14, 13, true, 100f, 1, 1 },
                    { 15, 14, true, 100f, 1, 1 },
                    { 16, 15, true, 100f, 1, 1 },
                    { 17, 0, true, 100f, 2, 1 },
                    { 18, 1, true, 100f, 2, 1 },
                    { 19, 2, true, 100f, 2, 1 },
                    { 20, 3, true, 100f, 2, 1 },
                    { 21, 4, true, 100f, 2, 1 },
                    { 22, 5, true, 100f, 2, 1 },
                    { 23, 6, true, 100f, 2, 1 },
                    { 24, 7, false, 100f, 2, 1 },
                    { 25, 8, false, 100f, 2, 1 },
                    { 26, 9, true, 100f, 2, 1 },
                    { 27, 10, true, 100f, 2, 1 },
                    { 28, 11, true, 100f, 2, 1 },
                    { 29, 12, true, 100f, 2, 1 },
                    { 30, 13, true, 100f, 2, 1 },
                    { 31, 14, true, 100f, 2, 1 },
                    { 32, 15, true, 100f, 2, 1 },
                    { 33, 0, true, 100f, 3, 1 },
                    { 34, 1, true, 100f, 3, 1 },
                    { 35, 2, true, 100f, 3, 1 },
                    { 36, 3, true, 100f, 3, 1 },
                    { 37, 4, true, 100f, 3, 1 },
                    { 38, 5, true, 100f, 3, 1 },
                    { 39, 6, true, 100f, 3, 1 },
                    { 40, 7, false, 100f, 3, 1 },
                    { 41, 8, false, 100f, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenSchemas",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 42, 9, true, 100f, 3, 1 },
                    { 43, 10, true, 100f, 3, 1 },
                    { 44, 11, true, 100f, 3, 1 },
                    { 45, 12, true, 100f, 3, 1 },
                    { 46, 13, true, 100f, 3, 1 },
                    { 47, 14, true, 100f, 3, 1 },
                    { 48, 15, true, 100f, 3, 1 },
                    { 49, 0, true, 100f, 4, 1 },
                    { 50, 1, true, 100f, 4, 1 },
                    { 51, 2, true, 100f, 4, 1 },
                    { 52, 3, true, 100f, 4, 1 },
                    { 53, 4, true, 100f, 4, 1 },
                    { 54, 5, true, 100f, 4, 1 },
                    { 55, 6, true, 100f, 4, 1 },
                    { 56, 7, false, 100f, 4, 1 },
                    { 57, 8, false, 100f, 4, 1 },
                    { 58, 9, true, 100f, 4, 1 },
                    { 59, 10, true, 100f, 4, 1 },
                    { 60, 11, true, 100f, 4, 1 },
                    { 61, 12, true, 100f, 4, 1 },
                    { 62, 13, true, 100f, 4, 1 },
                    { 63, 14, true, 100f, 4, 1 },
                    { 64, 15, true, 100f, 4, 1 },
                    { 65, 0, true, 100f, 5, 1 },
                    { 66, 1, true, 100f, 5, 1 },
                    { 67, 2, true, 100f, 5, 1 },
                    { 68, 3, true, 100f, 5, 1 },
                    { 69, 4, true, 100f, 5, 1 },
                    { 70, 5, true, 100f, 5, 1 },
                    { 71, 6, true, 100f, 5, 1 },
                    { 72, 7, false, 100f, 5, 1 },
                    { 73, 8, false, 100f, 5, 1 },
                    { 74, 9, true, 100f, 5, 1 },
                    { 75, 10, true, 100f, 5, 1 },
                    { 76, 11, true, 100f, 5, 1 },
                    { 77, 12, true, 100f, 5, 1 },
                    { 78, 13, true, 100f, 5, 1 },
                    { 79, 14, true, 100f, 5, 1 },
                    { 80, 15, true, 100f, 5, 1 },
                    { 81, 0, true, 100f, 6, 1 },
                    { 82, 1, true, 100f, 6, 1 },
                    { 83, 2, true, 100f, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenSchemas",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 84, 3, true, 100f, 6, 1 },
                    { 85, 4, true, 100f, 6, 1 },
                    { 86, 5, true, 100f, 6, 1 },
                    { 87, 6, true, 100f, 6, 1 },
                    { 88, 7, false, 100f, 6, 1 },
                    { 89, 8, false, 100f, 6, 1 },
                    { 90, 9, true, 100f, 6, 1 },
                    { 91, 10, true, 100f, 6, 1 },
                    { 92, 11, true, 100f, 6, 1 },
                    { 93, 12, true, 100f, 6, 1 },
                    { 94, 13, true, 100f, 6, 1 },
                    { 95, 14, true, 100f, 6, 1 },
                    { 96, 15, true, 100f, 6, 1 },
                    { 97, 0, true, 100f, 7, 1 },
                    { 98, 1, true, 100f, 7, 1 },
                    { 99, 2, true, 100f, 7, 1 },
                    { 100, 3, true, 100f, 7, 1 },
                    { 101, 4, true, 100f, 7, 1 },
                    { 102, 5, true, 100f, 7, 1 },
                    { 103, 6, true, 100f, 7, 1 },
                    { 104, 7, false, 100f, 7, 1 },
                    { 105, 8, false, 100f, 7, 1 },
                    { 106, 9, true, 100f, 7, 1 },
                    { 107, 10, true, 100f, 7, 1 },
                    { 108, 11, true, 100f, 7, 1 },
                    { 109, 12, true, 100f, 7, 1 },
                    { 110, 13, true, 100f, 7, 1 },
                    { 111, 14, true, 100f, 7, 1 },
                    { 112, 15, true, 100f, 7, 1 },
                    { 113, 0, true, 100f, 8, 1 },
                    { 114, 1, true, 100f, 8, 1 },
                    { 115, 2, true, 100f, 8, 1 },
                    { 116, 3, true, 100f, 8, 1 },
                    { 117, 4, true, 100f, 8, 1 },
                    { 118, 5, true, 100f, 8, 1 },
                    { 119, 6, true, 100f, 8, 1 },
                    { 120, 7, false, 100f, 8, 1 },
                    { 121, 8, false, 100f, 8, 1 },
                    { 122, 9, true, 100f, 8, 1 },
                    { 123, 10, true, 100f, 8, 1 },
                    { 124, 11, true, 100f, 8, 1 },
                    { 125, 12, true, 100f, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenSchemas",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 126, 13, true, 100f, 8, 1 },
                    { 127, 14, true, 100f, 8, 1 },
                    { 128, 15, true, 100f, 8, 1 },
                    { 129, 0, true, 100f, 9, 1 },
                    { 130, 1, true, 100f, 9, 1 },
                    { 131, 2, true, 100f, 9, 1 },
                    { 132, 3, true, 100f, 9, 1 },
                    { 133, 4, true, 100f, 9, 1 },
                    { 134, 5, true, 100f, 9, 1 },
                    { 135, 6, true, 100f, 9, 1 },
                    { 136, 7, false, 100f, 9, 1 },
                    { 137, 8, false, 100f, 9, 1 },
                    { 138, 9, true, 100f, 9, 1 },
                    { 139, 10, true, 100f, 9, 1 },
                    { 140, 11, true, 100f, 9, 1 },
                    { 141, 12, true, 100f, 9, 1 },
                    { 142, 13, true, 100f, 9, 1 },
                    { 143, 14, true, 100f, 9, 1 },
                    { 144, 15, true, 100f, 9, 1 },
                    { 145, 0, false, 100f, 10, 1 },
                    { 146, 1, false, 100f, 10, 1 },
                    { 147, 2, false, 100f, 10, 1 },
                    { 148, 3, false, 100f, 10, 1 },
                    { 149, 4, false, 100f, 10, 1 },
                    { 150, 5, false, 100f, 10, 1 },
                    { 151, 6, false, 100f, 10, 1 },
                    { 152, 7, false, 100f, 10, 1 },
                    { 153, 8, false, 100f, 10, 1 },
                    { 154, 9, false, 100f, 10, 1 },
                    { 155, 10, false, 100f, 10, 1 },
                    { 156, 11, false, 100f, 10, 1 },
                    { 157, 12, false, 100f, 10, 1 },
                    { 158, 13, false, 100f, 10, 1 },
                    { 159, 14, false, 100f, 10, 1 },
                    { 160, 15, false, 100f, 10, 1 },
                    { 161, 0, false, 100f, 11, 1 },
                    { 162, 1, false, 100f, 11, 1 },
                    { 163, 2, false, 100f, 11, 1 },
                    { 164, 3, false, 100f, 11, 1 },
                    { 165, 4, false, 100f, 11, 1 },
                    { 166, 5, false, 100f, 11, 1 },
                    { 167, 6, false, 100f, 11, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenSchemas",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 168, 7, false, 100f, 11, 1 },
                    { 169, 8, false, 100f, 11, 1 },
                    { 170, 9, false, 100f, 11, 1 },
                    { 171, 10, false, 100f, 11, 1 },
                    { 172, 11, false, 100f, 11, 1 },
                    { 173, 12, false, 100f, 11, 1 },
                    { 174, 13, false, 100f, 11, 1 },
                    { 175, 14, false, 100f, 11, 1 },
                    { 176, 15, false, 100f, 11, 1 },
                    { 177, 0, true, 100f, 12, 1 },
                    { 178, 1, true, 100f, 12, 1 },
                    { 179, 2, true, 100f, 12, 1 },
                    { 180, 3, true, 100f, 12, 1 },
                    { 181, 4, true, 100f, 12, 1 },
                    { 182, 5, true, 100f, 12, 1 },
                    { 183, 6, true, 100f, 12, 1 },
                    { 184, 7, false, 100f, 12, 1 },
                    { 185, 8, false, 100f, 12, 1 },
                    { 186, 9, true, 100f, 12, 1 },
                    { 187, 10, true, 100f, 12, 1 },
                    { 188, 11, true, 100f, 12, 1 },
                    { 189, 12, true, 100f, 12, 1 },
                    { 190, 13, true, 100f, 12, 1 },
                    { 191, 14, true, 100f, 12, 1 },
                    { 192, 15, true, 100f, 12, 1 },
                    { 193, 0, true, 100f, 13, 1 },
                    { 194, 1, true, 100f, 13, 1 },
                    { 195, 2, true, 100f, 13, 1 },
                    { 196, 3, true, 100f, 13, 1 },
                    { 197, 4, true, 100f, 13, 1 },
                    { 198, 5, true, 100f, 13, 1 },
                    { 199, 6, true, 100f, 13, 1 },
                    { 200, 7, false, 100f, 13, 1 },
                    { 201, 8, false, 100f, 13, 1 },
                    { 202, 9, true, 100f, 13, 1 },
                    { 203, 10, true, 100f, 13, 1 },
                    { 204, 11, true, 100f, 13, 1 },
                    { 205, 12, true, 100f, 13, 1 },
                    { 206, 13, true, 100f, 13, 1 },
                    { 207, 14, true, 100f, 13, 1 },
                    { 208, 15, true, 100f, 13, 1 },
                    { 209, 0, true, 100f, 14, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenSchemas",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 210, 1, true, 100f, 14, 1 },
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

            migrationBuilder.CreateIndex(
                name: "IX_ScreenSchemas_SchemaId",
                table: "ScreenSchemas",
                column: "SchemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_ScreenSchemas_SeatId",
                table: "Tickets",
                column: "SeatId",
                principalTable: "ScreenSchemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
