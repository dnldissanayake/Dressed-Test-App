using Microsoft.EntityFrameworkCore;

namespace dressed_backend.Repositories
{
    public class DesignRepository
    {
        private readonly Data.ApplicationDbContext _context;

        public DesignRepository(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Models.Entities.Design>> GetAllAsync()
        {
            return await _context.Designs.ToListAsync();
        }

        public async Task<Models.Entities.Design?> GetByIdAsync(int id)
        {
            return await _context.Designs.FindAsync(id);
        }

        public async Task AddAsync(Models.Entities.Design design)
        {
            _context.Designs.Add(design);
            await _context.SaveChangesAsync();
        }

        public async Task<Models.Entities.Design?> FindAsync(int id)
        {
            return await _context.Designs.FindAsync(id);
        }

        public async Task DeleteAsync(Models.Entities.Design design)
        {
            _context.Designs.Remove(design);
            await _context.SaveChangesAsync();
        }
    }
}
