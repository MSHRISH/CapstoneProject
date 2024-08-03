using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormatName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Theaters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theaters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminAuths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHashKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminAuths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminAuths_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormatId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    CertificateId = table.Column<int>(type: "int", nullable: false),
                    PosterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LetterBoxUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealeaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Certifications_CertificateId",
                        column: x => x.CertificateId,
                        principalTable: "Certifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Formats_FormatId",
                        column: x => x.FormatId,
                        principalTable: "Formats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Screens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheaterId = table.Column<int>(type: "int", nullable: false),
                    ScreenName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchemaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screens_Schemas_SchemaId",
                        column: x => x.SchemaId,
                        principalTable: "Schemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Screens_Theaters_TheaterId",
                        column: x => x.TheaterId,
                        principalTable: "Theaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Snacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheaterId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Snacks_Theaters_TheaterId",
                        column: x => x.TheaterId,
                        principalTable: "Theaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAuths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHashKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAuths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAuths_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CastCrews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastCrews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CastCrews_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastCrews_MemberTypes_MemberTypeId",
                        column: x => x.MemberTypeId,
                        principalTable: "MemberTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastCrews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScreenId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ShowDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shows_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shows_Screens_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "Screens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TicketAmount = table.Column<float>(type: "real", nullable: false),
                    SnackAmount = table.Column<float>(type: "real", nullable: false),
                    BillAmount = table.Column<float>(type: "real", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    TotalAmount = table.Column<float>(type: "real", nullable: false),
                    PaymentStatus = table.Column<bool>(type: "bit", nullable: false),
                    BookedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Shows_ShowId",
                        column: x => x.ShowId,
                        principalTable: "Shows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SnackOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    SnackId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnackOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SnackOrders_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SnackOrders_Snacks_SnackId",
                        column: x => x.SnackId,
                        principalTable: "Snacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    SeatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_ScreenLayouts_SeatId",
                        column: x => x.SeatId,
                        principalTable: "ScreenLayouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Certifications",
                columns: new[] { "Id", "CertificateType" },
                values: new object[,]
                {
                    { 1, "U" },
                    { 2, "U/A" },
                    { 3, "A" }
                });

            migrationBuilder.InsertData(
                table: "Formats",
                columns: new[] { "Id", "FormatName" },
                values: new object[,]
                {
                    { 1, "2D" },
                    { 2, "3D" },
                    { 3, "IMAX" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "LanguageName" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "Tamil" },
                    { 3, "Hindi" },
                    { 4, "Japanese" }
                });

            migrationBuilder.InsertData(
                table: "MemberTypes",
                columns: new[] { "Id", "MemberName" },
                values: new object[,]
                {
                    { 1, "Cast" },
                    { 2, "Crew" }
                });

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
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[] { 1, "mynameisshrish@gmail.com", "Shrish", "1231233123" });

            migrationBuilder.InsertData(
                table: "AdminAuths",
                columns: new[] { "Id", "AdminId", "PasswordHash", "PasswordHashKey" },
                values: new object[] { 1, 1, new byte[] { 210, 81, 34, 135, 254, 35, 133, 60, 86, 17, 115, 1, 46, 216, 134, 109, 161, 47, 212, 3, 140, 245, 9, 117, 182, 68, 229, 160, 78, 44, 23, 96, 165, 242, 86, 13, 188, 172, 61, 188, 160, 188, 128, 47, 51, 1, 193, 63, 140, 183, 75, 159, 111, 51, 255, 158, 28, 217, 117, 249, 116, 148, 121, 107 }, new byte[] { 122, 250, 116, 5, 199, 246, 175, 170, 52, 170, 66, 243, 5, 89, 83, 166, 192, 166, 121, 86, 161, 129, 137, 211, 101, 172, 80, 114, 59, 199, 123, 229, 10, 253, 33, 160, 25, 121, 163, 208, 121, 46, 230, 24, 96, 79, 140, 219, 254, 5, 232, 221, 168, 201, 58, 92, 113, 10, 184, 250, 76, 42, 199, 153, 203, 235, 186, 228, 186, 229, 209, 180, 87, 187, 47, 127, 16, 122, 241, 51, 94, 95, 180, 63, 2, 57, 234, 106, 253, 57, 73, 244, 31, 199, 117, 79, 225, 192, 122, 158, 208, 136, 238, 208, 150, 45, 240, 36, 0, 95, 75, 97, 52, 100, 65, 146, 147, 231, 226, 168, 36, 198, 102, 85, 196, 91, 27, 184 } });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CertificateId", "Description", "Duration", "FormatId", "LanguageId", "LetterBoxUrl", "PosterUrl", "RealeaseDate", "Title" },
                values: new object[] { 1, 3, "First Rule of Fight Club is You do not talk about Fight Club", 139, 1, 1, "https://letterboxd.com/film/fight-club/", "https://a.ltrbxd.com/resized/film-poster/5/1/5/6/8/51568-fight-club-0-500-0-750-crop.jpg?v=768b32dfa4", new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club" });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 1, 1, true, 100f, 1, 1 },
                    { 2, 2, true, 100f, 1, 1 },
                    { 3, 3, true, 100f, 1, 1 },
                    { 4, 4, true, 100f, 1, 1 },
                    { 5, 5, true, 100f, 1, 1 },
                    { 6, 6, true, 100f, 1, 1 },
                    { 7, 7, false, 100f, 1, 1 },
                    { 8, 8, false, 100f, 1, 1 },
                    { 9, 9, true, 100f, 1, 1 },
                    { 10, 10, true, 100f, 1, 1 },
                    { 11, 11, true, 100f, 1, 1 },
                    { 12, 12, true, 100f, 1, 1 },
                    { 13, 13, true, 100f, 1, 1 },
                    { 14, 14, true, 100f, 1, 1 },
                    { 15, 15, true, 100f, 1, 1 },
                    { 16, 16, true, 100f, 1, 1 },
                    { 17, 1, true, 100f, 2, 1 },
                    { 18, 2, true, 100f, 2, 1 },
                    { 19, 3, true, 100f, 2, 1 },
                    { 20, 4, true, 100f, 2, 1 },
                    { 21, 5, true, 100f, 2, 1 },
                    { 22, 6, true, 100f, 2, 1 },
                    { 23, 7, false, 100f, 2, 1 },
                    { 24, 8, false, 100f, 2, 1 },
                    { 25, 9, true, 100f, 2, 1 },
                    { 26, 10, true, 100f, 2, 1 },
                    { 27, 11, true, 100f, 2, 1 },
                    { 28, 12, true, 100f, 2, 1 },
                    { 29, 13, true, 100f, 2, 1 },
                    { 30, 14, true, 100f, 2, 1 },
                    { 31, 15, true, 100f, 2, 1 },
                    { 32, 16, true, 100f, 2, 1 },
                    { 33, 1, true, 100f, 3, 1 },
                    { 34, 2, true, 100f, 3, 1 },
                    { 35, 3, true, 100f, 3, 1 },
                    { 36, 4, true, 100f, 3, 1 },
                    { 37, 5, true, 100f, 3, 1 },
                    { 38, 6, true, 100f, 3, 1 },
                    { 39, 7, false, 100f, 3, 1 },
                    { 40, 8, false, 100f, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 41, 9, true, 100f, 3, 1 },
                    { 42, 10, true, 100f, 3, 1 },
                    { 43, 11, true, 100f, 3, 1 },
                    { 44, 12, true, 100f, 3, 1 },
                    { 45, 13, true, 100f, 3, 1 },
                    { 46, 14, true, 100f, 3, 1 },
                    { 47, 15, true, 100f, 3, 1 },
                    { 48, 16, true, 100f, 3, 1 },
                    { 49, 1, true, 100f, 4, 1 },
                    { 50, 2, true, 100f, 4, 1 },
                    { 51, 3, true, 100f, 4, 1 },
                    { 52, 4, true, 100f, 4, 1 },
                    { 53, 5, true, 100f, 4, 1 },
                    { 54, 6, true, 100f, 4, 1 },
                    { 55, 7, false, 100f, 4, 1 },
                    { 56, 8, false, 100f, 4, 1 },
                    { 57, 9, true, 100f, 4, 1 },
                    { 58, 10, true, 100f, 4, 1 },
                    { 59, 11, true, 100f, 4, 1 },
                    { 60, 12, true, 100f, 4, 1 },
                    { 61, 13, true, 100f, 4, 1 },
                    { 62, 14, true, 100f, 4, 1 },
                    { 63, 15, true, 100f, 4, 1 },
                    { 64, 16, true, 100f, 4, 1 },
                    { 65, 1, true, 100f, 5, 1 },
                    { 66, 2, true, 100f, 5, 1 },
                    { 67, 3, true, 100f, 5, 1 },
                    { 68, 4, true, 100f, 5, 1 },
                    { 69, 5, true, 100f, 5, 1 },
                    { 70, 6, true, 100f, 5, 1 },
                    { 71, 7, false, 100f, 5, 1 },
                    { 72, 8, false, 100f, 5, 1 },
                    { 73, 9, true, 100f, 5, 1 },
                    { 74, 10, true, 100f, 5, 1 },
                    { 75, 11, true, 100f, 5, 1 },
                    { 76, 12, true, 100f, 5, 1 },
                    { 77, 13, true, 100f, 5, 1 },
                    { 78, 14, true, 100f, 5, 1 },
                    { 79, 15, true, 100f, 5, 1 },
                    { 80, 16, true, 100f, 5, 1 },
                    { 81, 1, true, 100f, 6, 1 },
                    { 82, 2, true, 100f, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 83, 3, true, 100f, 6, 1 },
                    { 84, 4, true, 100f, 6, 1 },
                    { 85, 5, true, 100f, 6, 1 },
                    { 86, 6, true, 100f, 6, 1 },
                    { 87, 7, false, 100f, 6, 1 },
                    { 88, 8, false, 100f, 6, 1 },
                    { 89, 9, true, 100f, 6, 1 },
                    { 90, 10, true, 100f, 6, 1 },
                    { 91, 11, true, 100f, 6, 1 },
                    { 92, 12, true, 100f, 6, 1 },
                    { 93, 13, true, 100f, 6, 1 },
                    { 94, 14, true, 100f, 6, 1 },
                    { 95, 15, true, 100f, 6, 1 },
                    { 96, 16, true, 100f, 6, 1 },
                    { 97, 1, true, 100f, 7, 1 },
                    { 98, 2, true, 100f, 7, 1 },
                    { 99, 3, true, 100f, 7, 1 },
                    { 100, 4, true, 100f, 7, 1 },
                    { 101, 5, true, 100f, 7, 1 },
                    { 102, 6, true, 100f, 7, 1 },
                    { 103, 7, false, 100f, 7, 1 },
                    { 104, 8, false, 100f, 7, 1 },
                    { 105, 9, true, 100f, 7, 1 },
                    { 106, 10, true, 100f, 7, 1 },
                    { 107, 11, true, 100f, 7, 1 },
                    { 108, 12, true, 100f, 7, 1 },
                    { 109, 13, true, 100f, 7, 1 },
                    { 110, 14, true, 100f, 7, 1 },
                    { 111, 15, true, 100f, 7, 1 },
                    { 112, 16, true, 100f, 7, 1 },
                    { 113, 1, true, 100f, 8, 1 },
                    { 114, 2, true, 100f, 8, 1 },
                    { 115, 3, true, 100f, 8, 1 },
                    { 116, 4, true, 100f, 8, 1 },
                    { 117, 5, true, 100f, 8, 1 },
                    { 118, 6, true, 100f, 8, 1 },
                    { 119, 7, false, 100f, 8, 1 },
                    { 120, 8, false, 100f, 8, 1 },
                    { 121, 9, true, 100f, 8, 1 },
                    { 122, 10, true, 100f, 8, 1 },
                    { 123, 11, true, 100f, 8, 1 },
                    { 124, 12, true, 100f, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 125, 13, true, 100f, 8, 1 },
                    { 126, 14, true, 100f, 8, 1 },
                    { 127, 15, true, 100f, 8, 1 },
                    { 128, 16, true, 100f, 8, 1 },
                    { 129, 1, true, 100f, 9, 1 },
                    { 130, 2, true, 100f, 9, 1 },
                    { 131, 3, true, 100f, 9, 1 },
                    { 132, 4, true, 100f, 9, 1 },
                    { 133, 5, true, 100f, 9, 1 },
                    { 134, 6, true, 100f, 9, 1 },
                    { 135, 7, false, 100f, 9, 1 },
                    { 136, 8, false, 100f, 9, 1 },
                    { 137, 9, true, 100f, 9, 1 },
                    { 138, 10, true, 100f, 9, 1 },
                    { 139, 11, true, 100f, 9, 1 },
                    { 140, 12, true, 100f, 9, 1 },
                    { 141, 13, true, 100f, 9, 1 },
                    { 142, 14, true, 100f, 9, 1 },
                    { 143, 15, true, 100f, 9, 1 },
                    { 144, 16, true, 100f, 9, 1 },
                    { 145, 1, false, 100f, 10, 1 },
                    { 146, 2, false, 100f, 10, 1 },
                    { 147, 3, false, 100f, 10, 1 },
                    { 148, 4, false, 100f, 10, 1 },
                    { 149, 5, false, 100f, 10, 1 },
                    { 150, 6, false, 100f, 10, 1 },
                    { 151, 7, false, 100f, 10, 1 },
                    { 152, 8, false, 100f, 10, 1 },
                    { 153, 9, false, 100f, 10, 1 },
                    { 154, 10, false, 100f, 10, 1 },
                    { 155, 11, false, 100f, 10, 1 },
                    { 156, 12, false, 100f, 10, 1 },
                    { 157, 13, false, 100f, 10, 1 },
                    { 158, 14, false, 100f, 10, 1 },
                    { 159, 15, false, 100f, 10, 1 },
                    { 160, 16, false, 100f, 10, 1 },
                    { 161, 1, false, 100f, 11, 1 },
                    { 162, 2, false, 100f, 11, 1 },
                    { 163, 3, false, 100f, 11, 1 },
                    { 164, 4, false, 100f, 11, 1 },
                    { 165, 5, false, 100f, 11, 1 },
                    { 166, 6, false, 100f, 11, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 167, 7, false, 100f, 11, 1 },
                    { 168, 8, false, 100f, 11, 1 },
                    { 169, 9, false, 100f, 11, 1 },
                    { 170, 10, false, 100f, 11, 1 },
                    { 171, 11, false, 100f, 11, 1 },
                    { 172, 12, false, 100f, 11, 1 },
                    { 173, 13, false, 100f, 11, 1 },
                    { 174, 14, false, 100f, 11, 1 },
                    { 175, 15, false, 100f, 11, 1 },
                    { 176, 16, false, 100f, 11, 1 },
                    { 177, 1, true, 100f, 12, 1 },
                    { 178, 2, true, 100f, 12, 1 },
                    { 179, 3, true, 100f, 12, 1 },
                    { 180, 4, true, 100f, 12, 1 },
                    { 181, 5, true, 100f, 12, 1 },
                    { 182, 6, true, 100f, 12, 1 },
                    { 183, 7, false, 100f, 12, 1 },
                    { 184, 8, false, 100f, 12, 1 },
                    { 185, 9, true, 100f, 12, 1 },
                    { 186, 10, true, 100f, 12, 1 },
                    { 187, 11, true, 100f, 12, 1 },
                    { 188, 12, true, 100f, 12, 1 },
                    { 189, 13, true, 100f, 12, 1 },
                    { 190, 14, true, 100f, 12, 1 },
                    { 191, 15, true, 100f, 12, 1 },
                    { 192, 16, true, 100f, 12, 1 },
                    { 193, 1, true, 100f, 13, 1 },
                    { 194, 2, true, 100f, 13, 1 },
                    { 195, 3, true, 100f, 13, 1 },
                    { 196, 4, true, 100f, 13, 1 },
                    { 197, 5, true, 100f, 13, 1 },
                    { 198, 6, true, 100f, 13, 1 },
                    { 199, 7, false, 100f, 13, 1 },
                    { 200, 8, false, 100f, 13, 1 },
                    { 201, 9, true, 100f, 13, 1 },
                    { 202, 10, true, 100f, 13, 1 },
                    { 203, 11, true, 100f, 13, 1 },
                    { 204, 12, true, 100f, 13, 1 },
                    { 205, 13, true, 100f, 13, 1 },
                    { 206, 14, true, 100f, 13, 1 },
                    { 207, 15, true, 100f, 13, 1 },
                    { 208, 16, true, 100f, 13, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 209, 1, true, 100f, 14, 1 },
                    { 210, 2, true, 100f, 14, 1 },
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
                    { 224, 16, true, 100f, 14, 1 },
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

            migrationBuilder.InsertData(
                table: "Screens",
                columns: new[] { "Id", "SchemaId", "ScreenName", "TheaterId" },
                values: new object[] { 1, 1, "Screen 1", 1 });

            migrationBuilder.InsertData(
                table: "Snacks",
                columns: new[] { "Id", "Description", "IsAvailable", "Name", "Price", "TheaterId" },
                values: new object[,]
                {
                    { 1, "Salted Popcorn", true, "Regular Popcorn", 250f, 1 },
                    { 2, "Crispy Nachos", true, "Nachos", 200f, 1 },
                    { 3, "Hot Coffee", true, "Coffee", 200f, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserAuths",
                columns: new[] { "Id", "PasswordHash", "PasswordHashKey", "UserId" },
                values: new object[] { 1, new byte[] { 64, 205, 157, 238, 173, 37, 81, 179, 57, 17, 117, 14, 180, 164, 18, 216, 29, 6, 90, 101, 204, 255, 199, 106, 3, 163, 105, 40, 59, 250, 144, 13, 252, 207, 235, 215, 76, 216, 120, 96, 149, 101, 205, 18, 19, 231, 97, 96, 197, 206, 5, 220, 166, 37, 173, 103, 112, 165, 22, 82, 81, 1, 145, 105 }, new byte[] { 134, 166, 195, 10, 72, 43, 176, 102, 194, 1, 112, 80, 133, 253, 197, 195, 68, 155, 120, 177, 161, 140, 148, 63, 32, 159, 22, 104, 154, 10, 229, 217, 79, 72, 151, 10, 39, 196, 18, 53, 2, 62, 220, 46, 251, 235, 37, 81, 191, 9, 73, 131, 148, 252, 77, 140, 219, 72, 77, 75, 124, 141, 37, 90, 225, 104, 123, 20, 210, 168, 212, 194, 38, 128, 185, 30, 139, 54, 95, 105, 236, 187, 78, 243, 101, 68, 159, 231, 116, 77, 213, 205, 172, 26, 145, 196, 151, 185, 86, 106, 241, 169, 62, 218, 18, 135, 88, 52, 7, 14, 0, 12, 141, 9, 171, 0, 142, 142, 182, 92, 221, 23, 47, 133, 123, 42, 177, 248 }, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AdminAuths_AdminId",
                table: "AdminAuths",
                column: "AdminId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ShowId",
                table: "Bookings",
                column: "ShowId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CastCrews_ArtistId",
                table: "CastCrews",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_CastCrews_MemberTypeId",
                table: "CastCrews",
                column: "MemberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CastCrews_MovieId",
                table: "CastCrews",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CertificateId",
                table: "Movies",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_FormatId",
                table: "Movies",
                column: "FormatId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_LanguageId",
                table: "Movies",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ScreenLayouts_SchemaId",
                table: "ScreenLayouts",
                column: "SchemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Screens_SchemaId",
                table: "Screens",
                column: "SchemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Screens_TheaterId",
                table: "Screens",
                column: "TheaterId");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_MovieId",
                table: "Shows",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_ScreenId",
                table: "Shows",
                column: "ScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_SnackOrders_BookingId",
                table: "SnackOrders",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_SnackOrders_SnackId",
                table: "SnackOrders",
                column: "SnackId");

            migrationBuilder.CreateIndex(
                name: "IX_Snacks_TheaterId",
                table: "Snacks",
                column: "TheaterId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_BookingId",
                table: "Tickets",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SeatId",
                table: "Tickets",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuths_UserId",
                table: "UserAuths",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminAuths");

            migrationBuilder.DropTable(
                name: "CastCrews");

            migrationBuilder.DropTable(
                name: "SnackOrders");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "UserAuths");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "MemberTypes");

            migrationBuilder.DropTable(
                name: "Snacks");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "ScreenLayouts");

            migrationBuilder.DropTable(
                name: "Shows");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Screens");

            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Formats");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Schemas");

            migrationBuilder.DropTable(
                name: "Theaters");
        }
    }
}
