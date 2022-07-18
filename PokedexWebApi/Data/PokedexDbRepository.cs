using PokedexWebApi.Interfaces;
using PokedexWebApi.Models;

namespace PokedexWebApi.Data
{
    public class PokedexDbRepository : IPokedexDbRepository
    {
        private DataContext _dataContext;

        public PokedexDbRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Pokemon CreateNewPokemon(Pokemon pokemon)
        {
            _dataContext.Pokemons.Add(pokemon);
            _dataContext.SaveChanges();

            return pokemon;
        }

        public bool DoesPokemonExistById(int id)
        {
            return _dataContext.Pokemons.Any(use => use.PokemonID == id);
        }

        public bool DoesPokemonExistByName(string name)
        {
            return _dataContext.Pokemons.Any(use => use.PokemonName == name);
        }

        public List<Pokemon> GetAllPokemon()
        {
            var pokemon = _dataContext.Pokemons.ToList();
            return pokemon;
        }

        public Pokemon GetPokemonById(int id)
        {
            var pokemon = _dataContext.Pokemons.Where(x => x.PokemonID == id).FirstOrDefault();
            return pokemon;
        }

        public Pokemon GetPokemonByName(string name)
        {
            var pokemon = _dataContext.Pokemons.Where(x => x.PokemonName == name).FirstOrDefault();
            return pokemon;
        }

        public PokemonStats CreateNewPokemonStat(PokemonStats pokemonstats)
        {
            _dataContext.PokemonStatuses.Add(pokemonstats);
            _dataContext.SaveChanges();

            return pokemonstats;
        }

        public List<PokemonStats> GetAllPokemonStats()
        {
            var pokemonstats = _dataContext.PokemonStatuses.ToList();
            return pokemonstats;
        }

        public PokemonStats GetPokemonStatsById(int id)
        {
            var pokemon = _dataContext.PokemonStatuses.Where(x => x.PokemonID == id).FirstOrDefault();
            return pokemon;
        }
    }
}
