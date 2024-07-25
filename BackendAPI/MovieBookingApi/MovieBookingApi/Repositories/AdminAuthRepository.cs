using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;

using Microsoft.EntityFrameworkCore;

namespace MovieBookingApi.Repositories
{
    public class AdminAuthRepository:IRepository<int,AdminAuth>
    {
        private readonly MovieBookingContext _context;

        public AdminAuthRepository(MovieBookingContext context) 
        {
            _context=context;
        }

        public async Task<AdminAuth> Add(AdminAuth item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<AdminAuth> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<AdminAuth> Get(int key)
        {
            var format = await _context.AdminAuths.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<AdminAuth>> GetAll()
        {
            var movies = await _context.AdminAuths.ToListAsync();
            return movies;
        }

        public Task<AdminAuth> Update(AdminAuth item)
        {
            throw new NotImplementedException();
        }
    }
}
