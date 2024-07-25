using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieBookingApi.Repositories
{
    public class TheaterRepository:IRepository<int,Theater>
    {
        private readonly MovieBookingContext _context;

        public TheaterRepository(MovieBookingContext context) 
        {
            _context=context;
        }

        public async Task<Theater> Add(Theater item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<Theater> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<Theater> Get(int key)
        {
            var format = await _context.Theaters.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<Theater>> GetAll()
        {
            var movies = await _context.Theaters.ToListAsync();
            return movies;
        }

        public Task<Theater> Update(Theater item)
        {
            throw new NotImplementedException();
        }
    }
}
