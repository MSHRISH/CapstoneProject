using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieBookingApi.Repositories
{
    public class FormatRepository : IRepository<int, Format>
    {
        private readonly MovieBookingContext _context;

        public FormatRepository(MovieBookingContext context) 
        { 
            _context=context;
        }
        public async Task<Format> Add(Format item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<Format> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<Format> Get(int key)
        {
            var format = await _context.Formats.FirstOrDefaultAsync(f => f.Id==key);
            return format;
        }

        public async Task<IEnumerable<Format>> GetAll()
        {
            var movies = await _context.Formats.ToListAsync();
            return movies;
        }

        public Task<Format> Update(Format item)
        {
            throw new NotImplementedException();
        }
    }
}
