using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieBookingApi.Repositories
{
    public class CertificationRepository:IRepository<int,Certification>
    {
        private readonly MovieBookingContext _context;

        public CertificationRepository(MovieBookingContext context) 
        {
            _context = context;
        }

        public async Task<Certification> Add(Certification item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<Certification> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<Certification> Get(int key)
        {
            var format = await _context.Certifications.FirstOrDefaultAsync(f=>f.Id==key);
            return format;
        }

        public async Task<IEnumerable<Certification>> GetAll()
        {
            var movies = await _context.Certifications.ToListAsync();
            return movies;
        }

        public Task<Certification> Update(Certification item)
        {
            throw new NotImplementedException();
        }
    }
}
