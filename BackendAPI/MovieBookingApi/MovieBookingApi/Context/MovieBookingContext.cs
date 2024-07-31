using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieBookingApi.Models;
using MovieBookingApi.Models.MovieModels;
using MovieBookingApi.Models.TheaterModels;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Security.Cryptography;
using System.Text;
using System;

namespace MovieBookingApi.Context
{
    public class MovieBookingContext : DbContext
    {
        public MovieBookingContext(DbContextOptions options) : base(options) { }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MemberType> MemberTypes { get; set; }
        public DbSet<CastCrew> CastCrews { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Schema> Schemas { get; set; }
        public DbSet<ScreenLayout> ScreenLayouts { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Snack> Snacks { get; set; }
        public DbSet<SnackOrder> SnackOrders { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdminAuth> AdminAuths { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAuth> UserAuths { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Format
            modelBuilder.Entity<Format>(ConfigureFormat);
            BuildFormats(modelBuilder);

            //Language
            modelBuilder.Entity<Language>(ConfigureLanguage);
            BuildLanguages(modelBuilder);

            //Certification
            modelBuilder.Entity<Certification>(ConfigureCertification);
            BuildCertifications(modelBuilder);

            modelBuilder.Entity<Movie>(ConfigureMovie);
            modelBuilder.Entity<CastCrew>(ConfigureCastCrew);

            //MemberTypes (i.e Cast/Crew)
            modelBuilder.Entity<MemberType>(ConfigureMemberType);
            BuildMemberTypes(modelBuilder);

            //Artists
            modelBuilder.Entity<Artist>(ConfigureArtist);
            BuildArtists(modelBuilder);

            //Theater
            modelBuilder.Entity<Theater>(ConfigureTheater);
            BuildTheaters(modelBuilder);

            //Schemas
            modelBuilder.Entity<Schema>(ConfigureSchema);
            BuildSchemas(modelBuilder);

            //Screens
            modelBuilder.Entity<Screen>(ConfigureScreen);
            BuildScreens(modelBuilder);

            //ScreenLayout
            modelBuilder.Entity<ScreenLayout>(ConfigureScreenLayout);
            BuildSchemaLayout(modelBuilder);

            //Shows
            modelBuilder.Entity<Show>(ConfigureShow);
            BuildShows(modelBuilder);

            modelBuilder.Entity<Ticket>(ConfigureTicket);
            modelBuilder.Entity<Booking>(ConfigureBooking);

            //Snacks
            modelBuilder.Entity<Snack>(ConfigureSnack);
            BuildSnacks(modelBuilder);
            modelBuilder.Entity<SnackOrder>(ConfigureSnackOrder);

            //Admin
            modelBuilder.Entity<Admin>(ConfigureAdmin);
            BuildAdmin(modelBuilder);
            modelBuilder.Entity<AdminAuth>(ConfigureAdminAuth);
            BuildAdminAuth(modelBuilder);

            //User
            modelBuilder.Entity<User>(ConfigureUser);
            BuildUser(modelBuilder);
            modelBuilder.Entity<UserAuth>(ConfigureUserAuth);
            BuildUserAuth(modelBuilder);
        }


        private void ConfigureMemberType(EntityTypeBuilder<MemberType> builder)
        {
            builder.HasKey(mt => mt.Id);
            builder.Property(mt => mt.MemberName).IsRequired();
        }
        private void BuildMemberTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberType>().HasData(
                new MemberType { Id = 1, MemberName = "Cast" },
                new MemberType { Id = 2, MemberName = "Crew" }
                );
        }

        private void ConfigureFormat(EntityTypeBuilder<Format> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.FormatName).IsRequired();
        }
        private void BuildFormats(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Format>().HasData(
                new Format { Id = 1, FormatName = "2D" },
                new Format { Id = 2, FormatName = "3D" },
                new Format { Id = 3, FormatName = "IMAX" }
                );
        }
        private void ConfigureLanguage(EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.LanguageName).IsRequired();
        }

        private void BuildLanguages(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
                new Language { Id = 1, LanguageName = "English" },
                new Language { Id = 2, LanguageName = "Tamil" },
                new Language { Id = 3, LanguageName = "Hindi" },
                new Language { Id = 4, LanguageName = "Japanese" }
                );
        }
        private void ConfigureCertification(EntityTypeBuilder<Certification> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CertificateType).IsRequired();
        }

        private void BuildCertifications(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certification>().HasData(
                new Certification { Id = 1, CertificateType = "U" },
                new Certification { Id = 2, CertificateType = "U/A" },
                new Certification { Id = 3, CertificateType = "A" }
                );
        }
        private void ConfigureMovie(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Title).IsRequired();
            builder.Property(m => m.Description).IsRequired();
            builder.Property(m => m.PosterUrl).IsRequired(false);
            builder.Property(m => m.LetterBoxUrl).IsRequired(false);
            builder.Property(m => m.RealeaseDate).IsRequired();
            builder.Property(m => m.Duration).IsRequired();

            builder.HasOne(m => m.Format)
                .WithMany()
                .HasForeignKey(m => m.FormatId);

            builder.HasOne(m => m.Language)
                .WithMany()
                .HasForeignKey(m => m.LanguageId);

            builder.HasOne(m => m.Certification)
                .WithMany()
                .HasForeignKey(m => m.CertificateId);
        }
        private void ConfigureCastCrew(EntityTypeBuilder<CastCrew> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Movie)
                .WithMany(m => m.CastCrews)
                .HasForeignKey(c => c.MovieId);

            builder.HasOne(c => c.Artist)
                .WithMany()
                .HasForeignKey(c => c.ArtistId);

            builder.HasOne(c => c.MemberType)
                .WithMany()
                .HasForeignKey(c => c.MemberTypeId);
        }
        private void ConfigureArtist(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.About).IsRequired(false);
        }

        private void BuildArtists(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist { Id = 1, Name = "Brad Pitt", About = "Great Actor." },
                new Artist { Id = 2, Name = "Edward Norton", About = "Great Actor." },
                new Artist { Id = 3, Name = "David Fincher", About = "Great Director." }
                );
        }
        private void ConfigureTheater(EntityTypeBuilder<Theater> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Phone).IsRequired();
            builder.Property(t => t.Address).IsRequired();
            builder.Property(t => t.District).IsRequired();
        }
        private void BuildTheaters(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Theater>().HasData(
                new Theater { Id = 1, Name = "INOX Theater", Phone = "1231231231", Address = "xyz,xxx", District = "Chennai" },
                new Theater { Id = 2, Name = "Rohini Theater", Phone = "1234123434", Address = "asd,asd", District = "Chennai" },
                new Theater { Id = 3, Name = "Theater X", Phone = "1234512345", Address = "qwe,asd", District = "Chennai" }
                );
        }

        private void ConfigureScreen(EntityTypeBuilder<Screen> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.ScreenName).IsRequired();


            builder.HasOne(s => s.Theater)
                .WithMany(t => t.Screens)
                .HasForeignKey(s => s.TheaterId);

            builder.HasOne(s => s.Schema)
                .WithMany(sc => sc.Screens)
                .HasForeignKey(s => s.SchemaId);
        }

        private void BuildScreens(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Screen>().HasData(
                new Screen { Id = 1, ScreenName = "Screen 1", TheaterId = 1, SchemaId = 1 }
                );
        }
        private void ConfigureSchema(EntityTypeBuilder<Schema> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).IsRequired();
            builder.Property(s => s.RowDimension).IsRequired();
            builder.Property(s => s.ColumnDimension).IsRequired();
        }

        private void BuildSchemas(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Schema>().HasData(
                new Schema { Id = 1, Name = "Schema 1", RowDimension = 15, ColumnDimension = 16 }
                );
        }

        private void ConfigureScreenLayout(EntityTypeBuilder<ScreenLayout> builder)
        {
            builder.HasKey(ss => ss.Id);
            builder.Property(ss => ss.Row).IsRequired();
            builder.Property(ss => ss.Column).IsRequired();
            builder.Property(ss => ss.IsSeat).IsRequired();
            builder.Property(ss => ss.Price).IsRequired();

            builder.HasOne(sl => sl.Schema)
                .WithMany(s => s.Layouts)
                .HasForeignKey(sl => sl.SchemaId);
        }

        private void BuildSchemaLayout(ModelBuilder modelBuilder)
        {
            int id = 1;
            for (int row = 1; row < 15; row++)
            {
                for (int column = 1; column < 16; column++)
                {
                    bool IsSeat = true;
                    if (row == 10 || row == 11 || column == 7 || column == 8)
                    {
                        IsSeat = false;

                    }
                    modelBuilder.Entity<ScreenLayout>().HasData(
                        new ScreenLayout { Id = id, Row = row, Column = column, Price = 100, IsSeat = IsSeat, SchemaId = 1 }
                        );
                    id++;
                }
            }
        }

        private void BuildShows(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Show>().HasData(
               new Show { Id = 1, ShowDateTime = new DateTime(2024, 8, 15, 14, 30, 0), MovieId = 1, ScreenId = 1}
                );
        }
        private void ConfigureShow(EntityTypeBuilder<Show> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.ShowDateTime).IsRequired();


            builder.HasOne(s => s.Screen)
                .WithMany(scr => scr.Shows)
                .HasForeignKey(s => s.ScreenId);

            builder.HasOne(s => s.Movie)
               .WithMany(m=>m.Shows)
               .HasForeignKey(s => s.MovieId);
        }
        private void ConfigureTicket(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => t.Id);

            builder.HasOne(t => t.Booking)
                .WithMany(b => b.Tickets)
                .HasForeignKey(t => t.BookingId)
                .OnDelete(DeleteBehavior.Cascade);
               

            builder.HasOne(t => t.Seat)
                .WithMany()
                .HasForeignKey(t => t.SeatId);
        }
        private void ConfigureBooking(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.BillAmount).IsRequired();
            builder.Property(b => b.Discount).IsRequired();
            builder.Property(b => b.TotalAmount).IsRequired();
            builder.Property(b => b.PaymentStatus).IsRequired();
            builder.Property(b => b.BookedOn).IsRequired();
            builder.Property(b => b.TicketAmount).IsRequired();
           

            builder.HasOne(b => b.Show)
                .WithMany(s => s.Bookings)
                .HasForeignKey(b => b.ShowId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b => b.User)
                .WithMany(u => u.Bookings)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
        private void ConfigureSnack(EntityTypeBuilder<Snack> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).IsRequired();
            builder.Property(s => s.Description).IsRequired(false);
            builder.Property(s => s.Price).IsRequired();
            builder.Property(s => s.IsAvailable).IsRequired();

            builder.HasOne(s => s.Theater)
               .WithMany(t => t.Snacks)
               .HasForeignKey(s => s.TheaterId)
               .OnDelete(DeleteBehavior.Restrict);
        }

        private void BuildSnacks(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Snack>().HasData(
                new Snack { Id=1, Name="Regular Popcorn", Description="Salted Popcorn", IsAvailable=true, Price=250, TheaterId=1},
                new Snack { Id=2, Name="Nachos", Description="Crispy Nachos", IsAvailable=true, Price=200, TheaterId=1},
                new Snack { Id=3, Name="Coffee", Description="Hot Coffee", IsAvailable=true, Price=200, TheaterId=1}
                );
        }
        private void ConfigureSnackOrder(EntityTypeBuilder<SnackOrder> builder)
        {
            builder.HasKey(so => so.Id);
            builder.Property(so => so.Quantity).IsRequired();

            builder.HasOne(so => so.Booking)
                .WithMany(b => b.SnackOrders)
                .HasForeignKey(so => so.BookingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(so => so.Snack)
               .WithMany()
               .HasForeignKey(so => so.SnackId)
               .OnDelete(DeleteBehavior.Cascade);
        }
        private void ConfigureAdmin(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.Email).IsRequired();

            builder.HasOne(a => a.AdminAuth)
                .WithOne(aa => aa.Admin)
                .HasForeignKey<AdminAuth>(aa => aa.AdminId);
        }
        private void BuildAdmin(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(
                new Admin { Id = 1, Name = "Shrish", Email = "Shrish@gmail.com" }
                );
        }

        private void ConfigureAdminAuth(EntityTypeBuilder<AdminAuth> builder)
        {
            builder.HasKey(aa => aa.Id);
            builder.Property(aa => aa.PasswordHash).IsRequired();
            builder.Property(aa => aa.PasswordHashKey).IsRequired();

            builder.HasOne(aa => aa.Admin)
                .WithOne(a => a.AdminAuth)
                .HasForeignKey<AdminAuth>(aa => aa.AdminId);

        }

        private void BuildAdminAuth(ModelBuilder modelBuilder)
        {
            var password = "string";
            HMACSHA512 hMACSHA = new HMACSHA512();

            modelBuilder.Entity<AdminAuth>().HasData(
                new AdminAuth { Id = 1, AdminId = 1, PasswordHashKey = hMACSHA.Key, PasswordHash = hMACSHA.ComputeHash(Encoding.UTF8.GetBytes(password)) }
                );
        }
        private void ConfigureUser(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Phone).IsRequired();

            builder.HasOne(u => u.UserAuth)
                .WithOne(ua => ua.User)
                .HasForeignKey<UserAuth>(ua => ua.UserId);

        }
        private void BuildUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "mynameisshrish@gmail.com", Name = "Shrish", Phone = "1231233123" }
                );
        }

        private void ConfigureUserAuth(EntityTypeBuilder<UserAuth> builder)
        {
            builder.HasKey(ua => ua.Id);
            builder.Property(ua => ua.PasswordHash).IsRequired();
            builder.Property(ua => ua.PasswordHashKey).IsRequired();

            builder.HasOne(ua => ua.User)
                .WithOne(u => u.UserAuth)
                .HasForeignKey<UserAuth>(ua => ua.UserId);
        }
        private void BuildUserAuth(ModelBuilder modelBuilder)
        {
            var password = "string";
            HMACSHA512 hMACSHA = new HMACSHA512();

            modelBuilder.Entity<UserAuth>().HasData(
                new UserAuth { Id = 1, UserId = 1, PasswordHashKey = hMACSHA.Key, PasswordHash = hMACSHA.ComputeHash(Encoding.UTF8.GetBytes(password)) }
                );

        }
    }
}
