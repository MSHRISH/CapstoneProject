using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using System.Data.Entity;

namespace MovieBookingApi.Repositories
{
    public class UserRepository:IRepository<int,User>
    {
        private readonly MovieBookingContext _context;

        public UserRepository(MovieBookingContext context) 
        {
            _context=context;
        }

        public async Task<User> Add(User item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<User> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Get(int key)
        {
            var format = await _context.Users.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var movies = await _context.Users.ToListAsync();
            return movies;
        }

        public Task<User> Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
