using Pokedex.Domain;
using Pokedex.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pokedex.Domain.Entity
{
    public class PokemonGeneration : BaseEntity
    {
        [XmlElement("Region name")]
        public string RegionName { get; set; }
        [XmlElement("Pokemon in this region list")]
        public List<Pokemon> PokemonGenerationList { get; set; }
        public PokemonGeneration() 
        {

        }
    }
    

}
