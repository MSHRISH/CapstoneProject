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

        public async Task<Booking> Delete(int key)
        {
            var booking = await Get(key);
            if (booking != null)
            {
                _context.Remove(booking);
                await _context.SaveChangesAsync();
                return booking;
            }
            return null;
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

        public async Task<Booking> Update(Booking item)
        {
            var booking = await Get(item.Id);
            if (booking != null)
            {
                _context.Update(item);
                await _context.SaveChangesAsync();
                return booking;
            }
            return null;
        }
    }
}