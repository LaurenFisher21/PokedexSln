using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokedexWebApi.Enums;
using PokedexWebApi.Interfaces;
using PokedexWebApi.Models;

namespace PokedexWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokedexDbRepository _pokedexDbRepository;

        public PokemonController(IPokedexDbRepository pokedexDbRepository)
        {
            _pokedexDbRepository = pokedexDbRepository;
        }

        [HttpPost]
        public IActionResult CreatePokemon([FromBody] Pokemon pokemon)
        {
            try
            {
                if (pokemon == null || !ModelState.IsValid)
                {
                    return BadRequest(SystemErrorCodes.PokemonNotValid.ToString());
                }
                bool customerExists = _pokedexDbRepository.DoesPokemonExistByName(pokemon.PokemonName);
                if (customerExists)
                {
                    return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.PokemonDuplicate.ToString());
                }
                _pokedexDbRepository.CreateNewPokemon(pokemon);
            }
            catch (Exception e)
            {
                return BadRequest(SystemErrorCodes.PokemonCreationFailed.ToString());
            }
            return Ok(pokemon);
        }
    }
}
