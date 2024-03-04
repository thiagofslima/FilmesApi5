using FilmesApi5.Data.Dtos.Cinema;
using FilmesApi5.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi5.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base (opt)
        {
            
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}
