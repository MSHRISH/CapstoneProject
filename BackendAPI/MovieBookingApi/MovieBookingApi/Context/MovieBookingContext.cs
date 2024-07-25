using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieBookingApi.Models;

namespace MovieBookingApi.Context
{
    public class MovieBookingContext: DbContext
    {
       public MovieBookingContext(DbContextOptions options):base (options) { }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CastCrew> CastCrews { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<ScreenSchema> ScreenSchemas { get; set; }
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
            modelBuilder.Entity<Format>(ConfigureFormat);
            modelBuilder.Entity<Language>(ConfigureLanguage);
            modelBuilder.Entity<Certification>(ConfigureCertification);
            modelBuilder.Entity<Movie>(ConfigureMovie);
            modelBuilder.Entity<CastCrew>(ConfigureCastCrew);
            modelBuilder.Entity<Artist>(ConfigureArtist);
            modelBuilder.Entity<Theater>(ConfigureTheater);
            modelBuilder.Entity<Screen>(ConfigureScreen);
            modelBuilder.Entity<ScreenSchema>(ConfigureScreenSchema);
            modelBuilder.Entity<Show>(ConfigureShow);
            modelBuilder.Entity<Ticket>(ConfigureTicket);
            modelBuilder.Entity<Booking>(ConfigureBooking);
            modelBuilder.Entity<Snack>(ConfigureSnack);
            modelBuilder.Entity<SnackOrder>(ConfigureSnackOrder);
            modelBuilder.Entity<Admin>(ConfigureAdmin);
            modelBuilder.Entity<AdminAuth>(ConfigureAdminAuth);
            modelBuilder.Entity<User>(ConfigureUser);
            modelBuilder.Entity<UserAuth>(ConfigureUserAuth);
        }
        private void ConfigureFormat(EntityTypeBuilder<Format> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.FormatName).IsRequired();
        }
        private void ConfigureLanguage(EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.LanguageName).IsRequired();
        }
        private void ConfigureCertification(EntityTypeBuilder<Certification> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CertificateType).IsRequired();
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
        }
        private void ConfigureArtist(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.About).IsRequired(false);
        }
        private void ConfigureTheater(EntityTypeBuilder<Theater> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Phone).IsRequired();
            builder.Property(t => t.Address).IsRequired();
            builder.Property(t => t.District).IsRequired();
        }
        private void ConfigureScreen(EntityTypeBuilder<Screen> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.ScreenName).IsRequired();
            builder.Property(s => s.DimensionRow).IsRequired();
            builder.Property(s => s.DimensionColumn).IsRequired();
            builder.Property(s => s.SeatingCapacity).IsRequired();

            builder.HasOne(s => s.Theater)
                .WithMany(t => t.Screens)
                .HasForeignKey(s => s.TheaterId);
        }
        private void ConfigureScreenSchema(EntityTypeBuilder<ScreenSchema> builder)
        {
            builder.HasKey(ss => ss.Id);
            builder.Property(ss => ss.Row).IsRequired();
            builder.Property(ss => ss.Column).IsRequired();
            builder.Property(ss => ss.IsSeat).IsRequired();
            builder.Property(ss => ss.Price).IsRequired();

            builder.HasOne(ss => ss.Screen)
                .WithMany(s => s.ScreenSchemas)
                .HasForeignKey(ss => ss.ScreenId);
        }
        private void ConfigureShow(EntityTypeBuilder<Show> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Date).IsRequired();
            builder.Property(s => s.ShowTime).IsRequired();

            builder.HasOne(s => s.Screen)
                .WithMany(scr => scr.Shows)
                .HasForeignKey(s => s.ScreenId);

            builder.HasOne(s => s.Movie)
               .WithMany()
               .HasForeignKey(s => s.MovieId);
        }
        private void ConfigureTicket(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => t.Id);

            builder.HasOne(t => t.Booking)
                .WithMany(b => b.Tickets)
                .HasForeignKey(t => t.BookingId)
                .OnDelete(DeleteBehavior.Cascade)
                .OnDelete(DeleteBehavior.Restrict);

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

            builder.HasOne(s => s.Theater)
               .WithMany(t => t.Snacks)
               .HasForeignKey(s => s.TheaterId)
               .OnDelete(DeleteBehavior.Restrict);
        }
        private void ConfigureSnackOrder(EntityTypeBuilder<SnackOrder> builder)
        {
            builder.HasKey(so => so.Id);

            builder.HasOne(so => so.Booking)
                .WithMany(b => b.SnackOrders)
                .HasForeignKey(so => so.BookingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(so => so.Snack)
               .WithMany()
               .HasForeignKey(so => so.SnackId)
               .OnDelete(DeleteBehavior.Restrict);
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

        private void ConfigureAdminAuth(EntityTypeBuilder<AdminAuth> builder)
        {
            builder.HasKey(aa => aa.Id);
            builder.Property(aa => aa.PasswordHash).IsRequired();
            builder.Property(aa => aa.PasswordHashKey).IsRequired();

            builder.HasOne(aa => aa.Admin)
                .WithOne(a => a.AdminAuth)
                .HasForeignKey<AdminAuth>(aa => aa.AdminId);
                
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
        private void ConfigureUserAuth(EntityTypeBuilder<UserAuth> builder)
        {
            builder.HasKey(ua => ua.Id);
            builder.Property(ua => ua.PasswordHash).IsRequired();
            builder.Property(ua => ua.PasswordHashKey).IsRequired();

            builder.HasOne(ua => ua.User)
                .WithOne(u => u.UserAuth)
                .HasForeignKey<UserAuth>(ua => ua.UserId);
                
        }
    }
}
