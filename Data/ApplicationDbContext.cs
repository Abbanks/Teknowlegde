using Microsoft.EntityFrameworkCore;
using Teknowlegde.Data.Entity;

namespace Teknowlegde.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
