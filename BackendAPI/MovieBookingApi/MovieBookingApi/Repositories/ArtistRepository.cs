using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using Microsoft.EntityFrameworkCore;
using MovieBookingApi.Models.MovieModels;
using Microsoft.EntityFrameworkCore;

namespace MovieBookingApi.Repositories
{
    public class ArtistRepository:IRepository<int,Artist>
    {
        private readonly MovieBookingContext _context;

        public ArtistRepository(MovieBookingContext context) 
        {
            _context = context;
        }

        public async Task<Artist> Add(Artist item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<Artist> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<Artist> Get(int key)
        {
            var format = await _context.Artists.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<Artist>> GetAll()
        {
            var movies = await _context.Artists.ToListAsync();
            return movies;
        }

        public Task<Artist> Update(Artist item)
        {
            throw new NotImplementedException();
        }
    }
}
