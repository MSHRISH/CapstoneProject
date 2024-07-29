using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class ScreenSchemaChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScreenSchemas_Screens_ScreenId",
                table: "ScreenSchemas");

            migrationBuilder.DropColumn(
                name: "DimensionColumn",
                table: "Screens");

            migrationBuilder.DropColumn(
                name: "DimensionRow",
                table: "Screens");

            migrationBuilder.RenameColumn(
                name: "ScreenId",
                table: "ScreenSchemas",
                newName: "SchemaId");

            migrationBuilder.RenameIndex(
                name: "IX_ScreenSchemas_ScreenId",
                table: "ScreenSchemas",
                newName: "IX_ScreenSchemas_SchemaId");

            migrationBuilder.RenameColumn(
                name: "SeatingCapacity",
                table: "Screens",
                newName: "SchemaId");

            migrationBuilder.CreateTable(
                name: "Schemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowDimension = table.Column<int>(type: "int", nullable: false),
                    ColumnDimension = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schemas", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 200, 106, 6, 2, 153, 38, 235, 15, 227, 20, 200, 157, 194, 147, 116, 151, 227, 128, 35, 165, 77, 149, 252, 24, 193, 162, 112, 170, 153, 20, 237, 145, 155, 143, 2, 89, 244, 236, 50, 27, 196, 229, 69, 8, 21, 140, 235, 197, 171, 160, 125, 186, 49, 14, 140, 112, 196, 113, 244, 40, 222, 111, 13, 243 }, new byte[] { 103, 25, 225, 183, 199, 166, 6, 79, 110, 137, 210, 216, 17, 231, 36, 197, 84, 54, 192, 42, 84, 87, 230, 205, 66, 198, 201, 30, 204, 106, 46, 203, 185, 170, 21, 69, 210, 187, 68, 97, 159, 21, 215, 182, 203, 106, 190, 167, 171, 179, 62, 75, 53, 150, 67, 196, 169, 235, 157, 1, 166, 66, 115, 222, 74, 99, 27, 79, 88, 150, 60, 178, 172, 162, 228, 199, 214, 92, 42, 155, 65, 77, 45, 43, 92, 53, 27, 205, 20, 60, 234, 179, 223, 47, 65, 64, 89, 10, 179, 133, 27, 56, 134, 22, 19, 108, 69, 18, 123, 167, 121, 84, 111, 30, 79, 209, 206, 222, 30, 226, 31, 105, 205, 220, 181, 222, 97, 231 } });

            migrationBuilder.CreateIndex(
                name: "IX_Screens_SchemaId",
                table: "Screens",
                column: "SchemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Screens_Schemas_SchemaId",
                table: "Screens",
                column: "SchemaId",
                principalTable: "Schemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenSchemas_Schemas_SchemaId",
                table: "ScreenSchemas",
                column: "SchemaId",
                principalTable: "Schemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Screens_Schemas_SchemaId",
                table: "Screens");

            migrationBuilder.DropForeignKey(
                name: "FK_ScreenSchemas_Schemas_SchemaId",
                table: "ScreenSchemas");

            migrationBuilder.DropTable(
                name: "Schemas");

            migrationBuilder.DropIndex(
                name: "IX_Screens_SchemaId",
                table: "Screens");

            migrationBuilder.RenameColumn(
                name: "SchemaId",
                table: "ScreenSchemas",
                newName: "ScreenId");

            migrationBuilder.RenameIndex(
                name: "IX_ScreenSchemas_SchemaId",
                table: "ScreenSchemas",
                newName: "IX_ScreenSchemas_ScreenId");

            migrationBuilder.RenameColumn(
                name: "SchemaId",
                table: "Screens",
                newName: "SeatingCapacity");

            migrationBuilder.AddColumn<int>(
                name: "DimensionColumn",
                table: "Screens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DimensionRow",
                table: "Screens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AdminAuths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordHashKey" },
                values: new object[] { new byte[] { 47, 14, 141, 100, 108, 199, 213, 16, 68, 149, 77, 44, 97, 171, 3, 237, 127, 160, 93, 136, 48, 156, 230, 212, 173, 170, 120, 119, 9, 203, 190, 27, 134, 206, 92, 198, 190, 31, 105, 57, 122, 205, 165, 38, 80, 91, 133, 219, 12, 103, 61, 52, 222, 170, 20, 172, 183, 115, 215, 226, 75, 250, 58, 174 }, new byte[] { 140, 154, 131, 247, 169, 166, 164, 98, 24, 107, 194, 160, 67, 224, 91, 253, 118, 192, 250, 142, 110, 132, 218, 134, 164, 122, 51, 238, 37, 233, 58, 136, 51, 232, 140, 67, 209, 247, 28, 24, 7, 12, 172, 192, 161, 28, 24, 238, 63, 47, 199, 166, 54, 29, 37, 208, 9, 62, 224, 224, 96, 41, 60, 240, 71, 91, 172, 223, 50, 130, 32, 242, 28, 142, 166, 246, 125, 65, 61, 125, 10, 240, 226, 203, 45, 225, 121, 218, 193, 188, 146, 8, 19, 118, 138, 170, 37, 241, 73, 176, 179, 212, 32, 151, 137, 216, 84, 251, 241, 94, 95, 204, 140, 77, 183, 80, 200, 180, 11, 161, 93, 239, 154, 57, 195, 242, 182, 245 } });

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenSchemas_Screens_ScreenId",
                table: "ScreenSchemas",
                column: "ScreenId",
                principalTable: "Screens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
