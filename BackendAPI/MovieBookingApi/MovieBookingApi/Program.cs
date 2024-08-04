using MovieBookingApi.Context;
using Microsoft.EntityFrameworkCore;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Repositories;
using MovieBookingApi.Models;
using MovieBookingApi.Services;
using MovieBookingApi.Models.MovieModels;
using MovieBookingApi.Models.TheaterModels;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


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

            #region Authorization
            //Auth
            builder.Services.AddSwaggerGen(option =>
            {
                option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
                });
                option.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] { }
                }
            });
            });

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenKey:JWT"]))
                    };

                });
            #endregion

            #region RoleBasedAuth
            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireUserRole", policy => policy.RequireRole("User"));
                options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
                options.AddPolicy("RequireAdminUserRole", policy => policy.RequireRole("Admin", "User"));

            });
            #endregion

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
            builder.Services.AddScoped<IRepository<int,Schema>, SchemaRepository>();
            builder.Services.AddScoped<IRepository<int,ScreenLayout>,ScreenLayoutRepository>();
            builder.Services.AddScoped<IRepository<int, Show>, ShowRepository>();
            builder.Services.AddScoped<IRepository<int, Snack>, SnackRepository>();
            builder.Services.AddScoped<IRepository<int, SnackOrder>, SnackOrdersRepository>();
            builder.Services.AddScoped<IRepository<int, Theater>, TheaterRepository>();
            builder.Services.AddScoped<IRepository<int, Ticket>, TicketRepository>();
            builder.Services.AddScoped<IRepository<int, User>, UserRepository>();
            builder.Services.AddScoped<IRepository<int, UserAuth>, UserAuthRepository>();
            #endregion

            #region Services
            builder.Services.AddScoped<IAccessServices, AccessServices>();
            builder.Services.AddScoped<ITokenServices, TokenServices>();
            builder.Services.AddScoped<IMovieServices, MovieServices>();
            builder.Services.AddScoped<IBookingServices, BookingServices>();
            builder.Services.AddScoped<ITheaterServices, TheaterServices>();
            #endregion

            #region CORS
            builder.Services.AddCors(opts =>
            {
                opts.AddPolicy("MyCors", options =>
                {
                    options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                });
            });
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("MyCors");
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
