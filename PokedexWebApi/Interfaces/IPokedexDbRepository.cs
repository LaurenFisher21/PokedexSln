using PokedexWebApi.Models;

namespace PokedexWebApi.Interfaces
{
    public interface IPokedexDbRepository
    {
        Pokemon CreateNewPokemon(Pokemon pokemon);
        public bool DoesPokemonExistById(int id);
        public bool DoesPokemonExistByName(string name);
        List<Pokemon> GetAllPokemon();
        Pokemon GetPokemonById(int id);
        Pokemon GetPokemonByName(string name);
        PokemonStats CreateNewPokemonStat(PokemonStats pokemonstats);
        List<PokemonStats> GetAllPokemonStats();
        PokemonStats GetPokemonStatsById(int id);
    }
}
