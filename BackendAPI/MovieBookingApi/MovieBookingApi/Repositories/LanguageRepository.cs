using MovieBookingApi.Context;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieBookingApi.Repositories
{
    public class LanguageRepository:IRepository<int,Language>
    {
        private readonly MovieBookingContext _context;

        public LanguageRepository(MovieBookingContext context) 
        {
            _context=context;
        }

        public async Task<Language> Add(Language item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public Task<Language> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<Language> Get(int key)
        {
            var format = await _context.Languages.FirstOrDefaultAsync(f => f.Id == key);
            return format;
        }

        public async Task<IEnumerable<Language>> GetAll()
        {
            var movies = await _context.Languages.ToListAsync();
            return movies;
        }

        public Task<Language> Update(Language item)
        {
            throw new NotImplementedException();
        }
    }
}
