using Microsoft.EntityFrameworkCore;
using PokedexWebApi.Models;

namespace PokedexWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonStats> PokemonStatuses { get; set; }
    }
}
