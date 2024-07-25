using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using System.Data.Entity;

namespace MovieBookingApi.Repositories
{
    public class ScreenSchemaRepository: IRepository<int, ScreenSchema>
    {
        private readonly MovieBookingContext _context;

        public ScreenSchemaRepository(MovieBookingContext context) 
        {
            _context = context;
        }

        public async Task<ScreenSchema> Add(ScreenSchema item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<ScreenSchema> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<ScreenSchema> Get(int key)
        {
            var format = await _context.ScreenSchemas.FirstOrDefaultAsync(f => f.Id == key);
            return format; 
        }

        public async Task<IEnumerable<ScreenSchema>> GetAll()
        {
            var movies = await _context.ScreenSchemas.ToListAsync();
            return movies;
        }

        public Task<ScreenSchema> Update(ScreenSchema item)
        {
            throw new NotImplementedException();
        }
    }
}
