using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBookingApi.Migrations
{
    public partial class PopulatedData : Migration
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
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    { 3, "Great Director.", "David Fincher" },
                    { 4, "Tamil Actor", "Vijay" },
                    { 5, "Tamil Director", "Lokesh Kanagaraj" },
                    { 6, "Actor", "Sanjay Dutt" },
                    { 7, "Tamil Actor", "Dhanush" },
                    { 8, "Tamil Artist", "Selvaraghavan" },
                    { 9, "Tamil Actress", "Dushara Vijayan" },
                    { 10, "Hollywood Actor", "Ryan Renolds" },
                    { 11, "Hollywood Actor", "Hugh Jackman" },
                    { 12, "Hollywood Director", "Shawn Lavy" },
                    { 13, "Korean Actor", "Choi Min-sik" },
                    { 14, "Korean Actor", "Yoo ji-tae" },
                    { 15, "Korean Director", "Park Chan-wook" }
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
                    { 4, "Korean" },
                    { 5, "Japanese" }
                });

            migrationBuilder.InsertData(
                table: "Schemas",
                columns: new[] { "Id", "ColumnDimension", "Name", "RowDimension" },
                values: new object[,]
                {
                    { 1, 16, "Schema 1", 15 },
                    { 2, 15, "Schema 2", 10 },
                    { 3, 13, "Schema 3", 12 }
                });

            migrationBuilder.InsertData(
                table: "Theaters",
                columns: new[] { "Id", "Address", "District", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "xyz,xxx", "Chennai", "INOX Theater", "1231231231" },
                    { 2, "asd,asd", "Chennai", "Rohini Theater", "1234123434" },
                    { 3, "qwe,asd", "Madurai", "Thanga Regal", "1234512345" },
                    { 4, "asd, asd", "Madurai", "Gopuram Cinemas", "1231231239" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[] { 1, "Naresh@gmail.com", "Naresh", "1231233122" });

            migrationBuilder.InsertData(
                table: "AdminAuths",
                columns: new[] { "Id", "AdminId", "PasswordHash", "PasswordHashKey" },
                values: new object[] { 1, 1, new byte[] { 42, 50, 250, 82, 40, 138, 240, 96, 92, 13, 89, 61, 49, 242, 99, 57, 85, 48, 126, 192, 123, 127, 73, 141, 229, 54, 114, 244, 97, 141, 130, 215, 250, 183, 241, 113, 250, 5, 152, 26, 48, 73, 56, 105, 193, 187, 12, 128, 197, 106, 211, 62, 183, 107, 249, 186, 122, 176, 163, 129, 13, 29, 17, 196 }, new byte[] { 198, 53, 146, 113, 146, 179, 236, 81, 142, 217, 247, 82, 5, 40, 104, 119, 118, 173, 251, 140, 37, 82, 218, 148, 208, 141, 187, 61, 139, 127, 237, 3, 2, 162, 100, 122, 149, 128, 106, 57, 41, 46, 175, 195, 24, 12, 55, 17, 238, 190, 246, 147, 215, 145, 178, 142, 20, 196, 191, 55, 222, 102, 168, 51, 255, 143, 138, 64, 5, 103, 18, 121, 64, 54, 104, 225, 99, 232, 235, 228, 177, 217, 29, 117, 202, 212, 229, 85, 50, 210, 199, 32, 248, 28, 182, 72, 206, 242, 132, 191, 183, 44, 228, 58, 26, 237, 30, 152, 169, 240, 89, 115, 86, 196, 121, 194, 102, 217, 178, 98, 1, 213, 36, 250, 137, 151, 113, 100 } });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CertificateId", "Description", "Duration", "FormatId", "LanguageId", "LetterBoxUrl", "PosterUrl", "RealeaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 3, "First Rule of Fight Club is You do not talk about Fight Club", 139, 1, 1, "https://letterboxd.com/film/fight-club/", "https://a.ltrbxd.com/resized/film-poster/5/1/5/6/8/51568-fight-club-0-500-0-750-crop.jpg?v=768b32dfa4", new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club" },
                    { 2, 1, "Bloody Sweet!\r\nA mild-mannered man becomes a local hero through an act of violence, but it brings forth consequences with connection to a dangerous world, one which will shake his carefully constructed life to its very core.", 163, 1, 2, "https://letterboxd.com/film/leo-2023-1/", "https://a.ltrbxd.com/resized/film-poster/8/5/3/7/3/3/853733-leo-0-500-0-750-crop.jpg?v=36bd55c98c", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leo" },
                    { 3, 3, "Blood is Thicker than Everything.\r\nAfter his family is killed, a young man trains to avenge their murders. Seeking those responsible, his quest leads him through the criminal underworld.", 143, 1, 2, "https://letterboxd.com/film/raayan/", "https://a.ltrbxd.com/resized/film-poster/1/0/2/4/2/1/2/1024212-raayan-0-500-0-750-crop.jpg?v=d118dd747c", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raayan" },
                    { 4, 3, "Come together.\r\nA listless Wade Wilson toils away in civilian life with his days as the morally flexible mercenary, Deadpool, behind him. But when his homeworld faces an existential threat, Wade must reluctantly suit-up again with an even more reluctant Wolverine. ", 128, 3, 1, "https://letterboxd.com/film/deadpool-wolverine/", "https://a.ltrbxd.com/resized/film-poster/4/6/2/8/7/0/462870-deadpool-wolverine-0-500-0-750-crop.jpg?v=1aa778d2c6", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deadpool & Wolverine" },
                    { 5, 3, "15 years of imprisonment, five days of vengeance\r\nWith no clue how he came to be imprisoned, drugged and tortured for 15 years, a desperate businessman seeks revenge on his captors", 120, 1, 4, "https://letterboxd.com/film/oldboy/", "https://a.ltrbxd.com/resized/film-poster/5/1/4/5/4/51454-oldboy-0-500-0-750-crop.jpg?v=294dbcadef", new DateTime(2003, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oldboy" }
                });

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
                    { 36, 4, true, 100f, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 37, 5, true, 100f, 3, 1 },
                    { 38, 6, true, 100f, 3, 1 },
                    { 39, 7, false, 100f, 3, 1 },
                    { 40, 8, false, 100f, 3, 1 },
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
                    { 78, 14, true, 100f, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 79, 15, true, 100f, 5, 1 },
                    { 80, 16, true, 100f, 5, 1 },
                    { 81, 1, true, 100f, 6, 1 },
                    { 82, 2, true, 100f, 6, 1 },
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
                    { 120, 8, false, 100f, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 121, 9, true, 100f, 8, 1 },
                    { 122, 10, true, 100f, 8, 1 },
                    { 123, 11, true, 100f, 8, 1 },
                    { 124, 12, true, 100f, 8, 1 },
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
                    { 162, 2, false, 100f, 11, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 163, 3, false, 100f, 11, 1 },
                    { 164, 4, false, 100f, 11, 1 },
                    { 165, 5, false, 100f, 11, 1 },
                    { 166, 6, false, 100f, 11, 1 },
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
                    { 204, 12, true, 100f, 13, 1 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 205, 13, true, 100f, 13, 1 },
                    { 206, 14, true, 100f, 13, 1 },
                    { 207, 15, true, 100f, 13, 1 },
                    { 208, 16, true, 100f, 13, 1 },
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
                    { 240, 16, true, 100f, 15, 1 },
                    { 241, 1, true, 240f, 1, 2 },
                    { 242, 2, true, 240f, 1, 2 },
                    { 243, 3, true, 240f, 1, 2 },
                    { 244, 4, true, 240f, 1, 2 },
                    { 245, 5, true, 240f, 1, 2 },
                    { 246, 6, true, 240f, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 247, 7, true, 240f, 1, 2 },
                    { 248, 8, false, 240f, 1, 2 },
                    { 249, 9, true, 240f, 1, 2 },
                    { 250, 10, true, 240f, 1, 2 },
                    { 251, 11, true, 240f, 1, 2 },
                    { 252, 12, true, 240f, 1, 2 },
                    { 253, 13, true, 240f, 1, 2 },
                    { 254, 14, true, 240f, 1, 2 },
                    { 255, 15, true, 240f, 1, 2 },
                    { 256, 1, true, 240f, 2, 2 },
                    { 257, 2, true, 240f, 2, 2 },
                    { 258, 3, true, 240f, 2, 2 },
                    { 259, 4, true, 240f, 2, 2 },
                    { 260, 5, true, 240f, 2, 2 },
                    { 261, 6, true, 240f, 2, 2 },
                    { 262, 7, true, 240f, 2, 2 },
                    { 263, 8, false, 240f, 2, 2 },
                    { 264, 9, true, 240f, 2, 2 },
                    { 265, 10, true, 240f, 2, 2 },
                    { 266, 11, true, 240f, 2, 2 },
                    { 267, 12, true, 240f, 2, 2 },
                    { 268, 13, true, 240f, 2, 2 },
                    { 269, 14, true, 240f, 2, 2 },
                    { 270, 15, true, 240f, 2, 2 },
                    { 271, 1, true, 240f, 3, 2 },
                    { 272, 2, true, 240f, 3, 2 },
                    { 273, 3, true, 240f, 3, 2 },
                    { 274, 4, true, 240f, 3, 2 },
                    { 275, 5, true, 240f, 3, 2 },
                    { 276, 6, true, 240f, 3, 2 },
                    { 277, 7, true, 240f, 3, 2 },
                    { 278, 8, false, 240f, 3, 2 },
                    { 279, 9, true, 240f, 3, 2 },
                    { 280, 10, true, 240f, 3, 2 },
                    { 281, 11, true, 240f, 3, 2 },
                    { 282, 12, true, 240f, 3, 2 },
                    { 283, 13, true, 240f, 3, 2 },
                    { 284, 14, true, 240f, 3, 2 },
                    { 285, 15, true, 240f, 3, 2 },
                    { 286, 1, true, 240f, 4, 2 },
                    { 287, 2, true, 240f, 4, 2 },
                    { 288, 3, true, 240f, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 289, 4, true, 240f, 4, 2 },
                    { 290, 5, true, 240f, 4, 2 },
                    { 291, 6, true, 240f, 4, 2 },
                    { 292, 7, true, 240f, 4, 2 },
                    { 293, 8, false, 240f, 4, 2 },
                    { 294, 9, true, 240f, 4, 2 },
                    { 295, 10, true, 240f, 4, 2 },
                    { 296, 11, true, 240f, 4, 2 },
                    { 297, 12, true, 240f, 4, 2 },
                    { 298, 13, true, 240f, 4, 2 },
                    { 299, 14, true, 240f, 4, 2 },
                    { 300, 15, true, 240f, 4, 2 },
                    { 301, 1, true, 240f, 5, 2 },
                    { 302, 2, true, 240f, 5, 2 },
                    { 303, 3, true, 240f, 5, 2 },
                    { 304, 4, true, 240f, 5, 2 },
                    { 305, 5, true, 240f, 5, 2 },
                    { 306, 6, true, 240f, 5, 2 },
                    { 307, 7, true, 240f, 5, 2 },
                    { 308, 8, false, 240f, 5, 2 },
                    { 309, 9, true, 240f, 5, 2 },
                    { 310, 10, true, 240f, 5, 2 },
                    { 311, 11, true, 240f, 5, 2 },
                    { 312, 12, true, 240f, 5, 2 },
                    { 313, 13, true, 240f, 5, 2 },
                    { 314, 14, true, 240f, 5, 2 },
                    { 315, 15, true, 240f, 5, 2 },
                    { 316, 1, true, 240f, 6, 2 },
                    { 317, 2, true, 240f, 6, 2 },
                    { 318, 3, true, 240f, 6, 2 },
                    { 319, 4, true, 240f, 6, 2 },
                    { 320, 5, true, 240f, 6, 2 },
                    { 321, 6, true, 240f, 6, 2 },
                    { 322, 7, true, 240f, 6, 2 },
                    { 323, 8, false, 240f, 6, 2 },
                    { 324, 9, true, 240f, 6, 2 },
                    { 325, 10, true, 240f, 6, 2 },
                    { 326, 11, true, 240f, 6, 2 },
                    { 327, 12, true, 240f, 6, 2 },
                    { 328, 13, true, 240f, 6, 2 },
                    { 329, 14, true, 240f, 6, 2 },
                    { 330, 15, true, 240f, 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 331, 1, true, 240f, 7, 2 },
                    { 332, 2, true, 240f, 7, 2 },
                    { 333, 3, true, 240f, 7, 2 },
                    { 334, 4, true, 240f, 7, 2 },
                    { 335, 5, true, 240f, 7, 2 },
                    { 336, 6, true, 240f, 7, 2 },
                    { 337, 7, true, 240f, 7, 2 },
                    { 338, 8, false, 240f, 7, 2 },
                    { 339, 9, true, 240f, 7, 2 },
                    { 340, 10, true, 240f, 7, 2 },
                    { 341, 11, true, 240f, 7, 2 },
                    { 342, 12, true, 240f, 7, 2 },
                    { 343, 13, true, 240f, 7, 2 },
                    { 344, 14, true, 240f, 7, 2 },
                    { 345, 15, true, 240f, 7, 2 },
                    { 346, 1, true, 240f, 8, 2 },
                    { 347, 2, true, 240f, 8, 2 },
                    { 348, 3, true, 240f, 8, 2 },
                    { 349, 4, true, 240f, 8, 2 },
                    { 350, 5, true, 240f, 8, 2 },
                    { 351, 6, true, 240f, 8, 2 },
                    { 352, 7, true, 240f, 8, 2 },
                    { 353, 8, false, 240f, 8, 2 },
                    { 354, 9, true, 240f, 8, 2 },
                    { 355, 10, true, 240f, 8, 2 },
                    { 356, 11, true, 240f, 8, 2 },
                    { 357, 12, true, 240f, 8, 2 },
                    { 358, 13, true, 240f, 8, 2 },
                    { 359, 14, true, 240f, 8, 2 },
                    { 360, 15, true, 240f, 8, 2 },
                    { 361, 1, true, 240f, 9, 2 },
                    { 362, 2, true, 240f, 9, 2 },
                    { 363, 3, true, 240f, 9, 2 },
                    { 364, 4, true, 240f, 9, 2 },
                    { 365, 5, true, 240f, 9, 2 },
                    { 366, 6, true, 240f, 9, 2 },
                    { 367, 7, true, 240f, 9, 2 },
                    { 368, 8, false, 240f, 9, 2 },
                    { 369, 9, true, 240f, 9, 2 },
                    { 370, 10, true, 240f, 9, 2 },
                    { 371, 11, true, 240f, 9, 2 },
                    { 372, 12, true, 240f, 9, 2 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 373, 13, true, 240f, 9, 2 },
                    { 374, 14, true, 240f, 9, 2 },
                    { 375, 15, true, 240f, 9, 2 },
                    { 376, 1, true, 240f, 10, 2 },
                    { 377, 2, true, 240f, 10, 2 },
                    { 378, 3, true, 240f, 10, 2 },
                    { 379, 4, true, 240f, 10, 2 },
                    { 380, 5, true, 240f, 10, 2 },
                    { 381, 6, true, 240f, 10, 2 },
                    { 382, 7, true, 240f, 10, 2 },
                    { 383, 8, false, 240f, 10, 2 },
                    { 384, 9, true, 240f, 10, 2 },
                    { 385, 10, true, 240f, 10, 2 },
                    { 386, 11, true, 240f, 10, 2 },
                    { 387, 12, true, 240f, 10, 2 },
                    { 388, 13, true, 240f, 10, 2 },
                    { 389, 14, true, 240f, 10, 2 },
                    { 390, 15, true, 240f, 10, 2 },
                    { 391, 1, true, 200f, 1, 3 },
                    { 392, 2, true, 200f, 1, 3 },
                    { 393, 3, true, 200f, 1, 3 },
                    { 394, 4, true, 200f, 1, 3 },
                    { 395, 5, true, 200f, 1, 3 },
                    { 396, 6, true, 200f, 1, 3 },
                    { 397, 7, false, 200f, 1, 3 },
                    { 398, 8, true, 200f, 1, 3 },
                    { 399, 9, true, 200f, 1, 3 },
                    { 400, 10, true, 200f, 1, 3 },
                    { 401, 11, true, 200f, 1, 3 },
                    { 402, 12, true, 200f, 1, 3 },
                    { 403, 13, true, 200f, 1, 3 },
                    { 404, 1, true, 200f, 2, 3 },
                    { 405, 2, true, 200f, 2, 3 },
                    { 406, 3, true, 200f, 2, 3 },
                    { 407, 4, true, 200f, 2, 3 },
                    { 408, 5, true, 200f, 2, 3 },
                    { 409, 6, true, 200f, 2, 3 },
                    { 410, 7, false, 200f, 2, 3 },
                    { 411, 8, true, 200f, 2, 3 },
                    { 412, 9, true, 200f, 2, 3 },
                    { 413, 10, true, 200f, 2, 3 },
                    { 414, 11, true, 200f, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 415, 12, true, 200f, 2, 3 },
                    { 416, 13, true, 200f, 2, 3 },
                    { 417, 1, true, 200f, 3, 3 },
                    { 418, 2, true, 200f, 3, 3 },
                    { 419, 3, true, 200f, 3, 3 },
                    { 420, 4, true, 200f, 3, 3 },
                    { 421, 5, true, 200f, 3, 3 },
                    { 422, 6, true, 200f, 3, 3 },
                    { 423, 7, false, 200f, 3, 3 },
                    { 424, 8, true, 200f, 3, 3 },
                    { 425, 9, true, 200f, 3, 3 },
                    { 426, 10, true, 200f, 3, 3 },
                    { 427, 11, true, 200f, 3, 3 },
                    { 428, 12, true, 200f, 3, 3 },
                    { 429, 13, true, 200f, 3, 3 },
                    { 430, 1, true, 200f, 4, 3 },
                    { 431, 2, true, 200f, 4, 3 },
                    { 432, 3, true, 200f, 4, 3 },
                    { 433, 4, true, 200f, 4, 3 },
                    { 434, 5, true, 200f, 4, 3 },
                    { 435, 6, true, 200f, 4, 3 },
                    { 436, 7, false, 200f, 4, 3 },
                    { 437, 8, true, 200f, 4, 3 },
                    { 438, 9, true, 200f, 4, 3 },
                    { 439, 10, true, 200f, 4, 3 },
                    { 440, 11, true, 200f, 4, 3 },
                    { 441, 12, true, 200f, 4, 3 },
                    { 442, 13, true, 200f, 4, 3 },
                    { 443, 1, true, 200f, 5, 3 },
                    { 444, 2, true, 200f, 5, 3 },
                    { 445, 3, true, 200f, 5, 3 },
                    { 446, 4, true, 200f, 5, 3 },
                    { 447, 5, true, 200f, 5, 3 },
                    { 448, 6, true, 200f, 5, 3 },
                    { 449, 7, false, 200f, 5, 3 },
                    { 450, 8, true, 200f, 5, 3 },
                    { 451, 9, true, 200f, 5, 3 },
                    { 452, 10, true, 200f, 5, 3 },
                    { 453, 11, true, 200f, 5, 3 },
                    { 454, 12, true, 200f, 5, 3 },
                    { 455, 13, true, 200f, 5, 3 },
                    { 456, 1, true, 200f, 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 457, 2, true, 200f, 6, 3 },
                    { 458, 3, true, 200f, 6, 3 },
                    { 459, 4, true, 200f, 6, 3 },
                    { 460, 5, true, 200f, 6, 3 },
                    { 461, 6, true, 200f, 6, 3 },
                    { 462, 7, false, 200f, 6, 3 },
                    { 463, 8, true, 200f, 6, 3 },
                    { 464, 9, true, 200f, 6, 3 },
                    { 465, 10, true, 200f, 6, 3 },
                    { 466, 11, true, 200f, 6, 3 },
                    { 467, 12, true, 200f, 6, 3 },
                    { 468, 13, true, 200f, 6, 3 },
                    { 469, 1, true, 200f, 7, 3 },
                    { 470, 2, true, 200f, 7, 3 },
                    { 471, 3, true, 200f, 7, 3 },
                    { 472, 4, true, 200f, 7, 3 },
                    { 473, 5, true, 200f, 7, 3 },
                    { 474, 6, true, 200f, 7, 3 },
                    { 475, 7, false, 200f, 7, 3 },
                    { 476, 8, true, 200f, 7, 3 },
                    { 477, 9, true, 200f, 7, 3 },
                    { 478, 10, true, 200f, 7, 3 },
                    { 479, 11, true, 200f, 7, 3 },
                    { 480, 12, true, 200f, 7, 3 },
                    { 481, 13, true, 200f, 7, 3 },
                    { 482, 1, true, 200f, 8, 3 },
                    { 483, 2, true, 200f, 8, 3 },
                    { 484, 3, true, 200f, 8, 3 },
                    { 485, 4, true, 200f, 8, 3 },
                    { 486, 5, true, 200f, 8, 3 },
                    { 487, 6, true, 200f, 8, 3 },
                    { 488, 7, false, 200f, 8, 3 },
                    { 489, 8, true, 200f, 8, 3 },
                    { 490, 9, true, 200f, 8, 3 },
                    { 491, 10, true, 200f, 8, 3 },
                    { 492, 11, true, 200f, 8, 3 },
                    { 493, 12, true, 200f, 8, 3 },
                    { 494, 13, true, 200f, 8, 3 },
                    { 495, 1, true, 200f, 9, 3 },
                    { 496, 2, true, 200f, 9, 3 },
                    { 497, 3, true, 200f, 9, 3 },
                    { 498, 4, true, 200f, 9, 3 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 499, 5, true, 200f, 9, 3 },
                    { 500, 6, true, 200f, 9, 3 },
                    { 501, 7, false, 200f, 9, 3 },
                    { 502, 8, true, 200f, 9, 3 },
                    { 503, 9, true, 200f, 9, 3 },
                    { 504, 10, true, 200f, 9, 3 },
                    { 505, 11, true, 200f, 9, 3 },
                    { 506, 12, true, 200f, 9, 3 },
                    { 507, 13, true, 200f, 9, 3 },
                    { 508, 1, true, 200f, 10, 3 },
                    { 509, 2, true, 200f, 10, 3 },
                    { 510, 3, true, 200f, 10, 3 },
                    { 511, 4, true, 200f, 10, 3 },
                    { 512, 5, true, 200f, 10, 3 },
                    { 513, 6, true, 200f, 10, 3 },
                    { 514, 7, false, 200f, 10, 3 },
                    { 515, 8, true, 200f, 10, 3 },
                    { 516, 9, true, 200f, 10, 3 },
                    { 517, 10, true, 200f, 10, 3 },
                    { 518, 11, true, 200f, 10, 3 },
                    { 519, 12, true, 200f, 10, 3 },
                    { 520, 13, true, 200f, 10, 3 },
                    { 521, 1, false, 200f, 11, 3 },
                    { 522, 2, false, 200f, 11, 3 },
                    { 523, 3, false, 200f, 11, 3 },
                    { 524, 4, false, 200f, 11, 3 },
                    { 525, 5, false, 200f, 11, 3 },
                    { 526, 6, false, 200f, 11, 3 },
                    { 527, 7, false, 200f, 11, 3 },
                    { 528, 8, false, 200f, 11, 3 },
                    { 529, 9, false, 200f, 11, 3 },
                    { 530, 10, false, 200f, 11, 3 },
                    { 531, 11, false, 200f, 11, 3 },
                    { 532, 12, false, 200f, 11, 3 },
                    { 533, 13, false, 200f, 11, 3 },
                    { 534, 1, true, 200f, 12, 3 },
                    { 535, 2, true, 200f, 12, 3 },
                    { 536, 3, true, 200f, 12, 3 },
                    { 537, 4, true, 200f, 12, 3 },
                    { 538, 5, true, 200f, 12, 3 },
                    { 539, 6, true, 200f, 12, 3 },
                    { 540, 7, true, 200f, 12, 3 }
                });

            migrationBuilder.InsertData(
                table: "ScreenLayouts",
                columns: new[] { "Id", "Column", "IsSeat", "Price", "Row", "SchemaId" },
                values: new object[,]
                {
                    { 541, 8, true, 200f, 12, 3 },
                    { 542, 9, true, 200f, 12, 3 },
                    { 543, 10, true, 200f, 12, 3 },
                    { 544, 11, true, 200f, 12, 3 },
                    { 545, 12, true, 200f, 12, 3 },
                    { 546, 13, true, 200f, 12, 3 }
                });

            migrationBuilder.InsertData(
                table: "Screens",
                columns: new[] { "Id", "SchemaId", "ScreenName", "TheaterId" },
                values: new object[,]
                {
                    { 1, 1, "Screen 1", 1 },
                    { 2, 2, "King Sony 4K", 2 },
                    { 3, 3, "Queen Qube Laser", 2 },
                    { 4, 1, "Prince", 3 },
                    { 5, 2, "G1", 4 },
                    { 6, 3, "G2", 4 }
                });

            migrationBuilder.InsertData(
                table: "Snacks",
                columns: new[] { "Id", "Description", "IsAvailable", "Name", "Price", "TheaterId" },
                values: new object[,]
                {
                    { 1, "Salted Popcorn", true, "Regular Popcorn", 350f, 1 },
                    { 2, "Crispy Nachos", true, "Nachos", 260f, 1 },
                    { 3, "Hot Coffee", true, "Coffee", 280f, 1 },
                    { 4, "Salted Popcorn", true, "Salted Popcorn", 200f, 2 },
                    { 5, "Crispy Chips", true, "Chips", 150f, 2 },
                    { 6, "Hot Coffee", true, "Coffee", 100f, 2 },
                    { 7, "Salted Popcorn", true, "Popcorn", 150f, 3 },
                    { 8, "Corn", true, "Sweet Corn", 100f, 3 },
                    { 9, "Hot Coffee", true, "Coffee", 50f, 3 },
                    { 10, "Salted Popcorn", true, "Salted Popcorn", 250f, 4 },
                    { 11, "Crispy Nachos", true, "Nachos", 200f, 4 },
                    { 12, "Cold Coke", true, "Coke", 200f, 4 }
                });

            migrationBuilder.InsertData(
                table: "UserAuths",
                columns: new[] { "Id", "PasswordHash", "PasswordHashKey", "UserId" },
                values: new object[] { 1, new byte[] { 13, 47, 48, 41, 219, 207, 47, 210, 8, 72, 177, 3, 41, 130, 172, 112, 35, 162, 177, 121, 187, 98, 237, 226, 189, 60, 119, 34, 155, 45, 113, 72, 183, 54, 193, 207, 18, 115, 53, 108, 193, 84, 38, 204, 81, 56, 85, 124, 156, 51, 175, 170, 141, 120, 143, 60, 161, 34, 188, 126, 119, 138, 30, 218 }, new byte[] { 103, 80, 149, 142, 159, 159, 160, 220, 238, 88, 122, 29, 233, 64, 68, 230, 149, 162, 84, 122, 109, 137, 74, 141, 115, 211, 179, 231, 34, 239, 153, 69, 206, 230, 44, 218, 5, 102, 22, 203, 243, 120, 41, 213, 84, 159, 142, 157, 21, 31, 188, 70, 199, 167, 18, 204, 159, 99, 24, 204, 192, 123, 135, 50, 228, 121, 6, 131, 59, 142, 87, 32, 69, 191, 75, 2, 210, 98, 131, 149, 167, 57, 226, 213, 176, 21, 85, 127, 38, 58, 226, 44, 14, 224, 44, 43, 205, 39, 194, 106, 200, 15, 240, 128, 229, 101, 144, 203, 156, 36, 1, 86, 174, 117, 188, 215, 246, 198, 80, 170, 197, 113, 13, 213, 222, 104, 96, 110 }, 1 });

            migrationBuilder.InsertData(
                table: "CastCrews",
                columns: new[] { "Id", "ArtistId", "MovieId", "Role" },
                values: new object[,]
                {
                    { 1, 1, 1, "Tyler Durden" },
                    { 2, 2, 1, "The Narrator" },
                    { 3, 3, 1, "Director" },
                    { 4, 4, 2, "Parthiban/Leo" },
                    { 5, 5, 2, "director" },
                    { 6, 6, 2, "Anthony" },
                    { 7, 7, 3, "Raayan" },
                    { 8, 8, 3, "Sekhar" },
                    { 9, 9, 3, "Durga" },
                    { 10, 10, 4, "Deadpool" },
                    { 11, 11, 4, "Wolverine" },
                    { 12, 12, 4, "Director" },
                    { 13, 13, 5, "Oh Dae-su" },
                    { 14, 14, 5, "Yoo Woo-jin" },
                    { 15, 15, 5, "Director" }
                });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "MovieId", "ScreenId", "ShowDateTime" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 8, 7, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, new DateTime(2024, 8, 7, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 3, new DateTime(2024, 8, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 6, new DateTime(2024, 8, 7, 16, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 1, new DateTime(2024, 8, 8, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, 2, new DateTime(2024, 8, 7, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, 2, new DateTime(2024, 8, 7, 13, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, 3, new DateTime(2024, 8, 7, 14, 5, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, 4, new DateTime(2024, 8, 7, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, 5, new DateTime(2024, 8, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 2, 2, new DateTime(2024, 8, 8, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 2, 2, new DateTime(2024, 8, 8, 13, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 2, 3, new DateTime(2024, 8, 8, 14, 5, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 2, 4, new DateTime(2024, 8, 8, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 2, 5, new DateTime(2024, 8, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 3, 5, new DateTime(2024, 8, 8, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 3, 5, new DateTime(2024, 8, 8, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 3, 1, new DateTime(2024, 8, 7, 18, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 3, 5, new DateTime(2024, 8, 9, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 3, 5, new DateTime(2024, 8, 9, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 3, 1, new DateTime(2024, 8, 8, 18, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 4, 1, new DateTime(2024, 8, 7, 22, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 4, 6, new DateTime(2024, 8, 7, 20, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 4, 1, new DateTime(2024, 8, 8, 22, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 4, 6, new DateTime(2024, 8, 8, 20, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 5, 1, new DateTime(2024, 8, 8, 14, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 5, 6, new DateTime(2024, 8, 8, 10, 45, 0, 0, DateTimeKind.Unspecified) }
                });

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
