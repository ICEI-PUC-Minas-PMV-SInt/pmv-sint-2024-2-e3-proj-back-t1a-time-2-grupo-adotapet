using Microsoft.EntityFrameworkCore;

namespace AdotaPet.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios {get;set;}
    }
}