using galeria_arte_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace galeria_arte_mvc.Data
{
    public class GaleriaDbContext : DbContext
    {
        public GaleriaDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Obra> Obras { get; set; }
        public DbSet<Exposicion> Exposiciones { get; set; }
    }
}
