using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using Microsoft.EntityFrameworkCore;
namespace MovieBookingApi.Repositories
{
    public class TicketRepository:IRepository<int,Ticket>
    {
        private readonly MovieBookingContext _context;

        public TicketRepository(MovieBookingContext context) 
        {
            _context=context;
        }

        public async Task<Ticket> Add(Ticket item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<Ticket> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<Ticket> Get(int key)
        {
            var format = await _context.Tickets.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<Ticket>> GetAll()
        {
            var movies = await _context.Tickets.ToListAsync();
            return movies;
        }

        public Task<Ticket> Update(Ticket item)
        {
            throw new NotImplementedException();
        }
    }
}
