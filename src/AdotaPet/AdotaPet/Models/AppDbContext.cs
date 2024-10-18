using Microsoft.EntityFrameworkCore;
using System;

namespace AdotaPet.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base   (options) { }

        public DbSet<Anuncio> Anuncios { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
