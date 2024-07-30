using Microsoft.EntityFrameworkCore;
using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models.TheaterModels;

namespace MovieBookingApi.Repositories
{
    public class SchemaRepository:IRepository<int,Schema>
    {
        private readonly MovieBookingContext _context;

        public SchemaRepository(MovieBookingContext context) 
        {
            _context=context;
        }

        public async Task<Schema> Add(Schema item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<Schema> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<Schema> Get(int key)
        {
            var movie = await _context.Schemas.FirstOrDefaultAsync(m => m.Id == key);
            return movie;
        }

        public async Task<IEnumerable<Schema>> GetAll()
        {
            var movies = await _context.Schemas.ToListAsync();
            return movies;
        }

        public Task<Schema> Update(Schema item)
        {
            throw new NotImplementedException();
        }
    }
}
