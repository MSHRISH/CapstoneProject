using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using System.Data.Entity;

namespace MovieBookingApi.Repositories
{
    public class UserAuthRepository:IRepository<int,UserAuth>
    {
        private readonly MovieBookingContext _context;

        public UserAuthRepository(MovieBookingContext context)
        {
            _context=context;
        }

        public async Task<UserAuth> Add(UserAuth item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<UserAuth> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<UserAuth> Get(int key)
        {
            var format = await _context.UserAuths.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<UserAuth>> GetAll()
        {
            var movies = await _context.UserAuths.ToListAsync();
            return movies;
        }

        public Task<UserAuth> Update(UserAuth item)
        {
            throw new NotImplementedException();
        }
    }
}
