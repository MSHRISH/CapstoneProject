using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models.MovieModels;
using MovieBookingApi.Models.TheaterModels;
using System.Data.Entity;

namespace MovieBookingApi.Repositories
{
    public class ScreenLayoutRepository : IRepository<int, ScreenLayout>
    {
        private readonly MovieBookingContext _context;

        public ScreenLayoutRepository(MovieBookingContext context) 
        {
            _context=context;
        }

        public async Task<ScreenLayout> Add(ScreenLayout item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<ScreenLayout> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<ScreenLayout> Get(int key)
        {
            var movie = await _context.ScreenLayouts.FirstOrDefaultAsync(m => m.Id == key);
            return movie;
        }

        public async Task<IEnumerable<ScreenLayout>> GetAll()
        {
            var movies = await _context.ScreenLayouts.ToListAsync();
            return movies;
        }

        public Task<ScreenLayout> Update(ScreenLayout item)
        {
            throw new NotImplementedException();
        }
    }
}
