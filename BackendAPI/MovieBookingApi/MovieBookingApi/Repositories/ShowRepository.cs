using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieBookingApi.Repositories
{
    public class ShowRepository : IRepository<int, Show>
    {
        private readonly MovieBookingContext _context;

        public ShowRepository(MovieBookingContext context) 
        { 
            _context= context;
        }

        public async Task<Show> Add(Show item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<Show> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<Show> Get(int key)
        {
            var format = await _context.Shows.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<Show>> GetAll()
        {
            var movies = await _context.Shows.ToListAsync();
            return movies;
        }

        public Task<Show> Update(Show item)
        {
            throw new NotImplementedException();
        }
    }
}
