using Microsoft.EntityFrameworkCore;
using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models.MovieModels;

namespace MovieBookingApi.Repositories
{
    public class MemberTypeRepository:IRepository<int,MemberType>
    {
        private readonly MovieBookingContext _context;

        public MemberTypeRepository(MovieBookingContext context) 
        {
            _context=context;
        }

        public Task<MemberType> Add(MemberType item)
        {
            throw new NotImplementedException();
        }

        public Task<MemberType> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<MemberType> Get(int key)
        {
            var movie = await _context.MemberTypes.FirstOrDefaultAsync(m => m.Id == key);
            return movie;
        }

        public async Task<IEnumerable<MemberType>> GetAll()
        {
            var movies = await _context.MemberTypes.ToListAsync();
            return movies;
        }

        public Task<MemberType> Update(MemberType item)
        {
            throw new NotImplementedException();
        }
    }
}
