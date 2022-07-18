using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokedexWebApi.Enums;
using PokedexWebApi.Interfaces;
using PokedexWebApi.Models;

namespace PokedexWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokeStatController : ControllerBase
    {
        private readonly IPokedexDbRepository _pokedexDbRepository;

        public PokeStatController(IPokedexDbRepository pokedexDbRepository)
        {
            _pokedexDbRepository = pokedexDbRepository;
        }

        [HttpPost]
        public IActionResult CreatePokemonStat([FromBody] PokemonStats pokemonstats)
        {
            try
            {
                if (pokemonstats == null || !ModelState.IsValid)
                {
                    return BadRequest(SystemErrorCodes.PokemonNotValid.ToString());
                }
                bool customerExists = _pokedexDbRepository.DoesPokemonExistById(pokemonstats.PokemonID);
                if (customerExists)
                {
                    return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.PokemonDuplicate.ToString());
                }
                _pokedexDbRepository.CreateNewPokemonStat(pokemonstats);
            }
            catch (Exception e)
            {
                return BadRequest(SystemErrorCodes.PokemonStatCreationFailed.ToString());
            }
            return Ok(pokemonstats);
        }
    }
}
