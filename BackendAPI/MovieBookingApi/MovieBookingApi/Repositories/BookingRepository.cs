using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieBookingApi.Repositories
{
    public class BookingRepository: IRepository<int,Booking>
    {
        private readonly MovieBookingContext _context;

        public BookingRepository(MovieBookingContext context) 
        {
            _context = context;
        }

        public async Task<Booking> Add(Booking item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<Booking> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<Booking> Get(int key)
        {
            var format = await _context.Bookings.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<Booking>> GetAll()
        {
            var movies = await _context.Bookings.ToListAsync();
            return movies;
        }

        public Task<Booking> Update(Booking item)
        {
            throw new NotImplementedException();
        }
    }
}