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
       // public DbSet<MemberType> MemberTypes { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<CastCrew> CastCrews { get; set; }
       
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

            //Movie
            modelBuilder.Entity<Movie>(ConfigureMovie);
            BuildMovies(modelBuilder);

            //MemberTypes (i.e Cast/Crew)
            //modelBuilder.Entity<MemberType>(ConfigureMemberType);
           // BuildMemberTypes(modelBuilder);

            //Artists
            modelBuilder.Entity<Artist>(ConfigureArtist);
            BuildArtists(modelBuilder);

            //CastCrew
            modelBuilder.Entity<CastCrew>(ConfigureCastCrew);
            BuildCastCrew(modelBuilder);      

            //Theater
            modelBuilder.Entity<Theater>(ConfigureTheater);
            BuildTheaters(modelBuilder);

            //Schemas
            modelBuilder.Entity<Schema>(ConfigureSchema);
            BuildSchemas(modelBuilder);

            //ScreenLayout
            modelBuilder.Entity<ScreenLayout>(ConfigureScreenLayout);
            BuildSchemaLayout(modelBuilder);

            //Screens
            modelBuilder.Entity<Screen>(ConfigureScreen);
            BuildScreens(modelBuilder);

            

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
                new Language { Id=4, LanguageName ="Korean"},
                new Language { Id = 5, LanguageName = "Japanese" }
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
        private void BuildMovies(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id=1, Title="Fight Club", CertificateId=3, Description ="First Rule of Fight Club is You do not talk about Fight Club",
                     FormatId =1, Duration=139, LanguageId=1, LetterBoxUrl = "https://letterboxd.com/film/fight-club/", RealeaseDate = new DateTime(1999, 10, 15)
                     , PosterUrl = "https://a.ltrbxd.com/resized/film-poster/5/1/5/6/8/51568-fight-club-0-500-0-750-crop.jpg?v=768b32dfa4"
                },

                new Movie {Id=2,Title="Leo", CertificateId=1, Description= "Bloody Sweet!\r\nA mild-mannered man becomes a local hero through an act of violence, but it brings forth consequences with connection to a dangerous world, one which will shake his carefully constructed life to its very core.",
                            FormatId=1, Duration=163, LanguageId=2, LetterBoxUrl= "https://letterboxd.com/film/leo-2023-1/",RealeaseDate= new DateTime(2023,10,19)
                            ,PosterUrl= "https://a.ltrbxd.com/resized/film-poster/8/5/3/7/3/3/853733-leo-0-500-0-750-crop.jpg?v=36bd55c98c"
                },

                new Movie { Id=3, Title="Raayan", CertificateId=3, Description= "Blood is Thicker than Everything.\r\nAfter his family is killed, a young man trains to avenge their murders. Seeking those responsible, his quest leads him through the criminal underworld.",
                           FormatId=1, Duration=143, LanguageId=2, LetterBoxUrl= "https://letterboxd.com/film/raayan/", RealeaseDate=new DateTime(2024,7,26),
                           PosterUrl= "https://a.ltrbxd.com/resized/film-poster/1/0/2/4/2/1/2/1024212-raayan-0-500-0-750-crop.jpg?v=d118dd747c"
                },
                new Movie { Id=4, Title= "Deadpool & Wolverine", CertificateId=3, Description= "Come together.\r\nA listless Wade Wilson toils away in civilian life with his days as the morally flexible mercenary, Deadpool, behind him. But when his homeworld faces an existential threat, Wade must reluctantly suit-up again with an even more reluctant Wolverine. ",
                            FormatId=3, Duration=128, LanguageId=1, LetterBoxUrl= "https://letterboxd.com/film/deadpool-wolverine/", RealeaseDate=new DateTime(2024,07,26),
                            PosterUrl= "https://a.ltrbxd.com/resized/film-poster/4/6/2/8/7/0/462870-deadpool-wolverine-0-500-0-750-crop.jpg?v=1aa778d2c6"
                },
                new Movie {Id=5, Title= "Oldboy", CertificateId=3, Description= "15 years of imprisonment, five days of vengeance\r\nWith no clue how he came to be imprisoned, drugged and tortured for 15 years, a desperate businessman seeks revenge on his captors",
                           FormatId=1, Duration=120, LanguageId=4, LetterBoxUrl= "https://letterboxd.com/film/oldboy/", RealeaseDate=new DateTime(2003,11,10),
                           PosterUrl= "https://a.ltrbxd.com/resized/film-poster/5/1/4/5/4/51454-oldboy-0-500-0-750-crop.jpg?v=294dbcadef"
                }
                );
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

           // builder.HasOne(c => c.MemberType)
                //.WithMany()
                //.HasForeignKey(c => c.MemberTypeId);
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
                new Artist { Id = 3, Name = "David Fincher", About = "Great Director." },
                
                new Artist { Id=4, Name="Vijay", About="Tamil Actor"},
                new Artist { Id=5, Name="Lokesh Kanagaraj", About="Tamil Director"},
                new Artist { Id=6, Name="Sanjay Dutt", About="Actor"},

                new Artist { Id=7, Name="Dhanush", About="Tamil Actor"},
                new Artist { Id=8, Name="Selvaraghavan", About="Tamil Artist"},
                new Artist { Id=9, Name= "Dushara Vijayan", About="Tamil Actress" },

                new Artist { Id=10, Name="Ryan Renolds", About="Hollywood Actor"},
                new Artist { Id=11, Name="Hugh Jackman", About="Hollywood Actor"},
                new Artist { Id=12, Name="Shawn Lavy", About="Hollywood Director"},

                new Artist { Id=13, Name= "Choi Min-sik", About="Korean Actor"},
                new Artist { Id=14, Name="Yoo ji-tae", About="Korean Actor"},
                new Artist { Id=15, Name="Park Chan-wook",About="Korean Director"}

                );
        }
        private void BuildCastCrew(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CastCrew>().HasData(
                new CastCrew { Id=1, ArtistId=1, MovieId=1, Role="Tyler Durden"},
                new CastCrew { Id=2, ArtistId=2,  MovieId=1, Role="The Narrator"},
                new CastCrew { Id=3, ArtistId=3,  MovieId=1, Role="Director"},
                
                new CastCrew { Id = 4, ArtistId = 4,  MovieId = 2, Role = "Parthiban/Leo" },
                new CastCrew { Id=5, ArtistId=5,  MovieId=2, Role="director"},
                new CastCrew { Id=6, ArtistId=6,  MovieId=2, Role="Anthony"},
                
                new CastCrew { Id=7, ArtistId=7,  MovieId=3, Role="Raayan"},
                new CastCrew { Id=8, ArtistId=8, MovieId=3, Role="Sekhar"},
                new CastCrew { Id=9, ArtistId=9,  MovieId=3, Role="Durga"},

                new CastCrew { Id=10, ArtistId=10,  MovieId=4, Role="Deadpool"},
                new CastCrew { Id=11, ArtistId=11, MovieId=4, Role="Wolverine"},
                new CastCrew { Id=12, ArtistId=12, MovieId=4, Role="Director"},

                new CastCrew { Id=13, ArtistId=13, MovieId=5, Role="Oh Dae-su"},
                new CastCrew { Id=14, ArtistId=14, MovieId=5, Role="Yoo Woo-jin"},
                new CastCrew { Id = 15, ArtistId = 15, MovieId = 5, Role="Director"}
                
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
                new Theater { Id = 3, Name = "Thanga Regal", Phone = "1234512345", Address = "qwe,asd", District = "Madurai" },
                new Theater { Id=4, Name="Gopuram Cinemas", Phone="1231231239", Address="asd, asd", District="Madurai"}
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
                new Screen { Id = 1, ScreenName = "Screen 1", TheaterId = 1, SchemaId = 1 },
                new Screen { Id=2, ScreenName="King Sony 4K", TheaterId=2, SchemaId = 2 },
                new Screen { Id=3, ScreenName="Queen Qube Laser", TheaterId=2, SchemaId=3},
                new Screen { Id=4, ScreenName="Prince", TheaterId=3, SchemaId=1},
                new Screen { Id=5, ScreenName="G1", TheaterId=4, SchemaId=2},
                new Screen { Id=6, ScreenName="G2", TheaterId=4, SchemaId=3}
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
                new Schema { Id = 1, Name = "Schema 1", RowDimension = 15, ColumnDimension = 16 },
                new Schema { Id=2, Name="Schema 2", RowDimension=10, ColumnDimension=15},
                new Schema { Id=3, Name="Schema 3", RowDimension=12, ColumnDimension=13}
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
            for (int row = 1; row <= 15; row++)
            {
                for (int column = 1; column <= 16; column++)
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

            
            for(int row = 1; row <= 10; row++)
            {
                for(int column = 1;column <= 15; column++)
                {
                    bool IsSeat = true;
                    if (column == 8)
                    {
                        IsSeat = false;
                    }
                    modelBuilder.Entity<ScreenLayout>().HasData(
                        new ScreenLayout { Id=id, Row=row, Column=column, Price=240, IsSeat=IsSeat, SchemaId = 2 }
                        );
                    id++;
                }
            }

            
            for(int row = 1;row <= 12; row++)
            {
                for(int column = 1;column <= 13; column++)
                {
                    bool IsSeat = true;
                    if(column == 7||row==11) 
                    { 
                        IsSeat = false; 
                    }
                    if (row == 12)
                    {
                        IsSeat= true;
                    }
                    modelBuilder.Entity<ScreenLayout>().HasData(
                        new ScreenLayout { Id = id, Row = row, Column = column, Price = 200, IsSeat = IsSeat, SchemaId = 3 }
                        );
                    id++;
                }
            }
        }
        
        private void BuildShows(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Show>().HasData(
               new Show { Id = 1, ShowDateTime = new DateTime(2024, 8, 7, 9, 30, 0), MovieId = 1, ScreenId = 1},
               new Show { Id=2, ShowDateTime=new DateTime(2024,8,7,14,30,0),MovieId=1, ScreenId=1},
               new Show { Id=3, ShowDateTime=new DateTime(2024, 8,7,10,0,0), MovieId=1, ScreenId=3},
               new Show { Id=4, ShowDateTime=new DateTime(2024,8,7,16,30,0), MovieId=1,ScreenId=6},
               new Show { Id = 5, ShowDateTime = new DateTime(2024, 8, 8, 9, 30, 0), MovieId = 1, ScreenId = 1 },

               new Show { Id=6, ShowDateTime = new DateTime(2024,8,7, 9, 30,0), MovieId=2, ScreenId=2},
               new Show { Id=7,ShowDateTime =new DateTime(2024,8,7,13,30,0),MovieId=2,ScreenId=2},
               new Show { Id=8, ShowDateTime = new DateTime(2024,8,7,14,5,0), MovieId=2, ScreenId=3},
               new Show { Id=9, ShowDateTime = new DateTime(2024,8,7,9,30,0), MovieId=2, ScreenId=4},
               new Show { Id=10, ShowDateTime=new DateTime(2024,8,7,9,0,0), MovieId=2, ScreenId=5},
               new Show { Id = 11, ShowDateTime = new DateTime(2024, 8, 8, 9, 30, 0), MovieId = 2, ScreenId = 2 },
               new Show { Id = 12, ShowDateTime = new DateTime(2024, 8, 8, 13, 30, 0), MovieId = 2, ScreenId = 2 },
               new Show { Id = 13, ShowDateTime = new DateTime(2024, 8, 8, 14, 5, 0), MovieId = 2, ScreenId = 3 },
               new Show { Id = 14, ShowDateTime = new DateTime(2024, 8, 8, 9, 30, 0), MovieId = 2, ScreenId = 4 },
               new Show { Id = 15, ShowDateTime = new DateTime(2024, 8, 8, 9, 0, 0), MovieId = 2, ScreenId = 5 },

               new Show { Id = 16, ShowDateTime = new DateTime(2024, 8, 8, 14, 30, 0), MovieId = 3, ScreenId = 5 },
               new Show { Id = 17, ShowDateTime = new DateTime(2024, 8, 8, 18, 30, 0), MovieId = 3, ScreenId = 5 },
               new Show { Id = 18, ShowDateTime = new DateTime(2024, 8, 7, 18, 45, 0), MovieId = 3, ScreenId = 1 },
               new Show { Id = 19, ShowDateTime = new DateTime(2024, 8, 9, 14, 30, 0), MovieId = 3, ScreenId = 5 },
               new Show { Id = 20, ShowDateTime = new DateTime(2024, 8, 9, 18, 30, 0), MovieId = 3, ScreenId = 5 },
               new Show { Id = 21, ShowDateTime = new DateTime(2024, 8, 8, 18, 45, 0), MovieId = 3, ScreenId = 1 },


                new Show { Id = 22, ShowDateTime = new DateTime(2024, 8, 7, 22, 45, 0), MovieId = 4, ScreenId = 1 },
                new Show { Id = 23, ShowDateTime = new DateTime(2024, 8, 7, 20, 45, 0), MovieId = 4, ScreenId = 6 },
                new Show { Id = 24, ShowDateTime = new DateTime(2024, 8, 8, 22, 45, 0), MovieId = 4, ScreenId = 1 },
                new Show { Id = 25, ShowDateTime = new DateTime(2024, 8, 8, 20, 45, 0), MovieId = 4, ScreenId = 6 },

                new Show { Id = 26, ShowDateTime = new DateTime(2024, 8, 8, 14, 45, 0), MovieId = 5, ScreenId = 1 },
                new Show { Id = 27, ShowDateTime = new DateTime(2024, 8, 8, 10, 45, 0), MovieId = 5, ScreenId = 6 }
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
                new Snack { Id=1, Name="Regular Popcorn", Description="Salted Popcorn", IsAvailable=true, Price=350, TheaterId=1},
                new Snack { Id=2, Name="Nachos", Description="Crispy Nachos", IsAvailable=true, Price=260, TheaterId=1},
                new Snack { Id=3, Name="Coffee", Description="Hot Coffee", IsAvailable=true, Price=280, TheaterId=1},

                new Snack { Id = 4, Name = "Salted Popcorn", Description = "Salted Popcorn", IsAvailable = true, Price = 200, TheaterId = 2 },
                new Snack { Id = 5, Name = "Chips", Description = "Crispy Chips", IsAvailable = true, Price = 150, TheaterId = 2 },
                new Snack { Id = 6, Name = "Coffee", Description = "Hot Coffee", IsAvailable = true, Price = 100, TheaterId = 2 },

                new Snack { Id = 7, Name = "Popcorn", Description = "Salted Popcorn", IsAvailable = true, Price = 150, TheaterId = 3 },
                new Snack { Id = 8, Name = "Sweet Corn", Description = "Corn", IsAvailable = true, Price = 100, TheaterId = 3 },
                new Snack { Id = 9, Name = "Coffee", Description = "Hot Coffee", IsAvailable = true, Price = 50, TheaterId = 3 },

                new Snack { Id = 10, Name = "Salted Popcorn", Description = "Salted Popcorn", IsAvailable = true, Price = 250, TheaterId = 4 },
                new Snack { Id = 11, Name = "Nachos", Description = "Crispy Nachos", IsAvailable = true, Price = 200, TheaterId = 4 },
                new Snack { Id = 12, Name = "Coke", Description = "Cold Coke", IsAvailable = true, Price = 200, TheaterId = 4 }
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
                new User { Id = 1, Email = "Naresh@gmail.com", Name = "Naresh", Phone = "1231233122" }
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
