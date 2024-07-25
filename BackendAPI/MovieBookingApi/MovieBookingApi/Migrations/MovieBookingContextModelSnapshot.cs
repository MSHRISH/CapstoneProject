﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieBookingApi.Context;

#nullable disable

namespace MovieBookingApi.Migrations
{
    [DbContext(typeof(MovieBookingContext))]
    partial class MovieBookingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MovieBookingApi.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Shrish@gmail.com",
                            Name = "Shrish"
                        });
                });

            modelBuilder.Entity("MovieBookingApi.Models.AdminAuth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordHashKey")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId")
                        .IsUnique();

                    b.ToTable("AdminAuths");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminId = 1,
                            PasswordHash = new byte[] { 79, 222, 62, 66, 151, 71, 106, 62, 89, 235, 148, 50, 245, 128, 101, 152, 103, 68, 245, 72, 116, 13, 59, 41, 232, 25, 23, 6, 255, 205, 13, 71, 86, 4, 205, 246, 3, 222, 236, 42, 160, 252, 74, 129, 206, 5, 153, 216, 121, 69, 159, 98, 176, 174, 153, 103, 123, 28, 109, 12, 161, 89, 20, 229 },
                            PasswordHashKey = new byte[] { 82, 253, 16, 102, 249, 252, 236, 250, 79, 70, 239, 153, 111, 199, 89, 189, 234, 30, 15, 41, 39, 220, 245, 84, 70, 236, 31, 117, 56, 245, 82, 193, 64, 132, 191, 16, 122, 112, 59, 134, 135, 75, 205, 124, 149, 78, 118, 148, 176, 54, 172, 7, 84, 12, 106, 188, 249, 111, 110, 13, 171, 118, 69, 141, 40, 12, 41, 12, 46, 83, 42, 187, 120, 152, 254, 188, 85, 146, 55, 61, 114, 126, 156, 27, 87, 174, 13, 145, 217, 221, 46, 222, 103, 115, 144, 31, 70, 163, 200, 31, 131, 237, 201, 106, 219, 77, 130, 203, 119, 72, 212, 98, 140, 29, 177, 196, 54, 8, 150, 254, 42, 106, 233, 150, 245, 157, 130, 208 }
                        });
                });

            modelBuilder.Entity("MovieBookingApi.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Great Actor.",
                            Name = "Brad Pitt"
                        },
                        new
                        {
                            Id = 2,
                            About = "Great Actor.",
                            Name = "Edward Norton"
                        },
                        new
                        {
                            Id = 3,
                            About = "Great Director.",
                            Name = "David Fincher"
                        });
                });

            modelBuilder.Entity("MovieBookingApi.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("BillAmount")
                        .HasColumnType("real");

                    b.Property<DateTime>("BookedOn")
                        .HasColumnType("datetime2");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("bit");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.Property<float>("TotalAmount")
                        .HasColumnType("real");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("MovieBookingApi.Models.CastCrew", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("MovieId");

                    b.ToTable("CastCrews");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Certification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CertificateType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Certifications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CertificateType = "U"
                        },
                        new
                        {
                            Id = 2,
                            CertificateType = "U/A"
                        },
                        new
                        {
                            Id = 3,
                            CertificateType = "A"
                        });
                });

            modelBuilder.Entity("MovieBookingApi.Models.Format", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FormatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Formats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FormatName = "2D"
                        },
                        new
                        {
                            Id = 2,
                            FormatName = "3D"
                        },
                        new
                        {
                            Id = 3,
                            FormatName = "IMAX"
                        });
                });

            modelBuilder.Entity("MovieBookingApi.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LanguageName = "English"
                        },
                        new
                        {
                            Id = 2,
                            LanguageName = "Tamil"
                        },
                        new
                        {
                            Id = 3,
                            LanguageName = "Hindi"
                        },
                        new
                        {
                            Id = 4,
                            LanguageName = "Japanese"
                        });
                });

            modelBuilder.Entity("MovieBookingApi.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CertificateId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("FormatId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("LetterBoxUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PosterUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RealeaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CertificateId");

                    b.HasIndex("FormatId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Screen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DimensionColumn")
                        .HasColumnType("int");

                    b.Property<int>("DimensionRow")
                        .HasColumnType("int");

                    b.Property<string>("ScreenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatingCapacity")
                        .HasColumnType("int");

                    b.Property<int>("TheaterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TheaterId");

                    b.ToTable("Screens");
                });

            modelBuilder.Entity("MovieBookingApi.Models.ScreenSchema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Column")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSeat")
                        .HasColumnType("bit");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.Property<int>("ScreenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScreenId");

                    b.ToTable("ScreenSchemas");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId1")
                        .HasColumnType("int");

                    b.Property<int>("ScreenId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("ShowTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("MovieId1");

                    b.HasIndex("ScreenId");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Snack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("TheaterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TheaterId");

                    b.ToTable("Snacks");
                });

            modelBuilder.Entity("MovieBookingApi.Models.SnackOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("SnackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("SnackId");

                    b.ToTable("SnackOrders");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Theater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Theaters");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("SeatId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("MovieBookingApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MovieBookingApi.Models.UserAuth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordHashKey")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserAuths");
                });

            modelBuilder.Entity("MovieBookingApi.Models.AdminAuth", b =>
                {
                    b.HasOne("MovieBookingApi.Models.Admin", "Admin")
                        .WithOne("AdminAuth")
                        .HasForeignKey("MovieBookingApi.Models.AdminAuth", "AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Booking", b =>
                {
                    b.HasOne("MovieBookingApi.Models.Show", "Show")
                        .WithMany("Bookings")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MovieBookingApi.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Show");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MovieBookingApi.Models.CastCrew", b =>
                {
                    b.HasOne("MovieBookingApi.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieBookingApi.Models.Movie", "Movie")
                        .WithMany("CastCrews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Movie", b =>
                {
                    b.HasOne("MovieBookingApi.Models.Certification", "Certification")
                        .WithMany()
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieBookingApi.Models.Format", "Format")
                        .WithMany()
                        .HasForeignKey("FormatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieBookingApi.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Certification");

                    b.Navigation("Format");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Screen", b =>
                {
                    b.HasOne("MovieBookingApi.Models.Theater", "Theater")
                        .WithMany("Screens")
                        .HasForeignKey("TheaterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Theater");
                });

            modelBuilder.Entity("MovieBookingApi.Models.ScreenSchema", b =>
                {
                    b.HasOne("MovieBookingApi.Models.Screen", "Screen")
                        .WithMany("ScreenSchemas")
                        .HasForeignKey("ScreenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Screen");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Show", b =>
                {
                    b.HasOne("MovieBookingApi.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieBookingApi.Models.Movie", null)
                        .WithMany("Shows")
                        .HasForeignKey("MovieId1");

                    b.HasOne("MovieBookingApi.Models.Screen", "Screen")
                        .WithMany("Shows")
                        .HasForeignKey("ScreenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Screen");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Snack", b =>
                {
                    b.HasOne("MovieBookingApi.Models.Theater", "Theater")
                        .WithMany("Snacks")
                        .HasForeignKey("TheaterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Theater");
                });

            modelBuilder.Entity("MovieBookingApi.Models.SnackOrder", b =>
                {
                    b.HasOne("MovieBookingApi.Models.Booking", "Booking")
                        .WithMany("SnackOrders")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieBookingApi.Models.Snack", "Snack")
                        .WithMany()
                        .HasForeignKey("SnackId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Snack");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Ticket", b =>
                {
                    b.HasOne("MovieBookingApi.Models.Booking", "Booking")
                        .WithMany("Tickets")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MovieBookingApi.Models.ScreenSchema", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("MovieBookingApi.Models.UserAuth", b =>
                {
                    b.HasOne("MovieBookingApi.Models.User", "User")
                        .WithOne("UserAuth")
                        .HasForeignKey("MovieBookingApi.Models.UserAuth", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Admin", b =>
                {
                    b.Navigation("AdminAuth")
                        .IsRequired();
                });

            modelBuilder.Entity("MovieBookingApi.Models.Booking", b =>
                {
                    b.Navigation("SnackOrders");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Movie", b =>
                {
                    b.Navigation("CastCrews");

                    b.Navigation("Shows");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Screen", b =>
                {
                    b.Navigation("ScreenSchemas");

                    b.Navigation("Shows");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Show", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("MovieBookingApi.Models.Theater", b =>
                {
                    b.Navigation("Screens");

                    b.Navigation("Snacks");
                });

            modelBuilder.Entity("MovieBookingApi.Models.User", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("UserAuth")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
