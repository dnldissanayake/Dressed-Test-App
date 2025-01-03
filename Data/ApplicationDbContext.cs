using dressed_backend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace dressed_backend.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public required DbSet<Design> Designs { get; set; }
    }
}
