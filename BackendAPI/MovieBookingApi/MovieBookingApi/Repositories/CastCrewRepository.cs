using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieBookingApi.Repositories
{
    public class CastCrewRepository: IRepository<int,CastCrew>
    {
        private readonly MovieBookingContext _context;

        public CastCrewRepository(MovieBookingContext context) 
        {
            _context=context;
        }

        public async Task<CastCrew> Add(CastCrew item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<CastCrew> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<CastCrew> Get(int key)
        {
            var format = await _context.CastCrews.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<CastCrew>> GetAll()
        {
            var movies = await _context.CastCrews.ToListAsync();
            return movies;
        }

        public Task<CastCrew> Update(CastCrew item)
        {
            throw new NotImplementedException();
        }
    }
}
