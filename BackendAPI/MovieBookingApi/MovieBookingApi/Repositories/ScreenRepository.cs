using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using Microsoft.EntityFrameworkCore;
using MovieBookingApi.Models.TheaterModels;

namespace MovieBookingApi.Repositories
{
    public class ScreenRepository:IRepository<int,Screen>
    {
        private readonly MovieBookingContext _context;

        public ScreenRepository(MovieBookingContext context) 
        {
            _context=context;
        }

        public async Task<Screen> Add(Screen item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<Screen> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<Screen> Get(int key)
        {
            var format = await _context.Screens.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<Screen>> GetAll()
        {
            var movies = await _context.Screens.ToListAsync();
            return movies;
        }

        public Task<Screen> Update(Screen item)
        {
            throw new NotImplementedException();
        }
    }
}
