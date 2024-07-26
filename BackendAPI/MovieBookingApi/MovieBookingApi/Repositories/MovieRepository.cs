using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using Microsoft.EntityFrameworkCore;
using MovieBookingApi.Models.MovieModels;

namespace MovieBookingApi.Repositories
{
    public class MovieRepository : IRepository<int, Movie>
    {
        private readonly MovieBookingContext _context;

        public MovieRepository(MovieBookingContext context) 
        {
            _context = context;
        }
        public async Task<Movie> Add(Movie item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<Movie> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> Get(int key)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == key);
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            var movies = await _context.Movies.ToListAsync();
            return movies;
        }
        public Task<Movie> Update(Movie item)
        {
            throw new NotImplementedException();
        }
    }
}
