using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;

using Microsoft.EntityFrameworkCore;

namespace MovieBookingApi.Repositories
{
    public class AdminRepository: IRepository<int,Admin>
    {
        private readonly MovieBookingContext _context;

        public AdminRepository(MovieBookingContext context) 
        {
            _context=context;
        }

        public async Task<Admin> Add(Admin item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<Admin> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<Admin> Get(int key)
        {
            var format = await _context.Admins.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<Admin>> GetAll()
        {
            var movies = await _context.Admins.ToListAsync();
            return movies;
        }

        public Task<Admin> Update(Admin item)
        {
            throw new NotImplementedException();
        }
    }
}
