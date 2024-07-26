using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using Microsoft.EntityFrameworkCore;
using MovieBookingApi.Models.TheaterModels;

namespace MovieBookingApi.Repositories
{
    public class ScreenSchemaRepository: IRepository<int, SchemaLayout>
    {
        private readonly MovieBookingContext _context;

        public ScreenSchemaRepository(MovieBookingContext context) 
        {
            _context = context;
        }

        public async Task<SchemaLayout> Add(SchemaLayout item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<SchemaLayout> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<SchemaLayout> Get(int key)
        {
            var format = await _context.ScreenSchemas.FirstOrDefaultAsync(f => f.Id == key);
            return format; 
        }

        public async Task<IEnumerable<SchemaLayout>> GetAll()
        {
            var movies = await _context.ScreenSchemas.ToListAsync();
            return movies;
        }

        public Task<SchemaLayout> Update(SchemaLayout item)
        {
            throw new NotImplementedException();
        }
    }
}
