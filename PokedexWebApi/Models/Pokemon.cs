using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokedexWebApi.Models
{
    [Table("Pokemon")]
    public class Pokemon
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PokemonID { get; set; }
        public string PokemonName { get; set; }
        public string PokemonType { get; set; }
        public string Description { get; set; }
    }
}
