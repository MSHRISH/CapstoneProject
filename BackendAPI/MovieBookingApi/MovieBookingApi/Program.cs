using MovieBookingApi.Context;
using Microsoft.EntityFrameworkCore;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Repositories;
using MovieBookingApi.Models;


namespace MovieBookingApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region Context
            builder.Services.AddDbContext<MovieBookingContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));
            #endregion

            #region Repository
            builder.Services.AddScoped<IRepository<int,Admin>,AdminRepository>();
            builder.Services.AddScoped<IRepository<int, AdminAuth>, AdminAuthRepository>();
            builder.Services.AddScoped<IRepository<int, Artist>, ArtistRepository>();
            builder.Services.AddScoped<IRepository<int, Booking>, BookingRepository>();
            builder.Services.AddScoped<IRepository<int, CastCrew>, CastCrewRepository>();
            builder.Services.AddScoped<IRepository<int, Certification>, CertificationRepository>();
            builder.Services.AddScoped<IRepository<int, Format>, FormatRepository>();
            builder.Services.AddScoped<IRepository<int, Language>, LanguageRepository>();
            builder.Services.AddScoped<IRepository<int, Movie>, MovieRepository>();
            builder.Services.AddScoped<IRepository<int, Screen>, ScreenRepository>();
            builder.Services.AddScoped<IRepository<int, ScreenSchema>, ScreenSchemaRepository>();
            builder.Services.AddScoped<IRepository<int, Show>, ShowRepository>();
            builder.Services.AddScoped<IRepository<int, Snack>, SnackRepository>();
            builder.Services.AddScoped<IRepository<int, SnackOrder>, SnackOrdersRepository>();
            builder.Services.AddScoped<IRepository<int, Theater>, TheaterRepository>();
            builder.Services.AddScoped<IRepository<int, Ticket>, TicketRepository>();
            builder.Services.AddScoped<IRepository<int, User>, UserRepository>();
            builder.Services.AddScoped<IRepository<int, UserAuth>, UserAuthRepository>();
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
