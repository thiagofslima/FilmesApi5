using FilmesApi5.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi5.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opt) : base (opt)
        {
            
        }

        public DbSet<Filme> Filmes { get; set; }
    }
}
