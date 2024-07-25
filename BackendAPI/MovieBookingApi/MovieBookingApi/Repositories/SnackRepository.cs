using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieBookingApi.Repositories
{
    public class SnackRepository:IRepository<int, Snack>
    {
        private readonly MovieBookingContext _context;

        public SnackRepository(MovieBookingContext context) 
        { 
            _context=context;
        }

        public async Task<Snack> Add(Snack item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<Snack> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<Snack> Get(int key)
        {
            var format = await _context.Snacks.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<Snack>> GetAll()
        {
            var movies = await _context.Snacks.ToListAsync();
            return movies;
        }

        public Task<Snack> Update(Snack item)
        {
            throw new NotImplementedException();
        }
    }
}
