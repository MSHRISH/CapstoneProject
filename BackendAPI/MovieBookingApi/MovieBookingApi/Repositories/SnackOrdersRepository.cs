using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using System.Data.Entity;

namespace MovieBookingApi.Repositories
{
    public class SnackOrdersRepository:IRepository<int,SnackOrder>
    {
        private readonly MovieBookingContext _context;

        public SnackOrdersRepository(MovieBookingContext context)
        {
            _context=context;
        }

        public async Task<SnackOrder> Add(SnackOrder item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<SnackOrder> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<SnackOrder> Get(int key)
        {
            var format = await _context.SnackOrders.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<SnackOrder>> GetAll()
        {
            var movies = await _context.SnackOrders.ToListAsync();
            return movies;
        }

        public Task<SnackOrder> Update(SnackOrder item)
        {
            throw new NotImplementedException();
        }
    }
}
