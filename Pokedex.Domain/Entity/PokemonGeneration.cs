using Pokedex.Domain;
using Pokedex.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Domain.Entity
{
    internal class PokemonGeneration : BaseEntity
    {        
        public string RegionName { get; set; }
        public List<Pokemon> PokemonGenerationList { get; set; }
    }
}
