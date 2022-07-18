using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokedexWebApi.Models
{
    [Table("PokemonStats")]
    public class PokemonStats
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PokeStatID { get; set; }
        public int PokeHp { get; set; }
        public int PokeAtt { get; set; }
        public int PokeDef { get; set; }
        public int PokeSpAtt { get; set; }
        public int PokeSpDef { get; set; }
        public int Speed { get; set; }

        [ForeignKey("Pokemon")]
        public int PokemonID { get; set; }
        public Pokemon? Pokemon { get; set; }
    }
}
