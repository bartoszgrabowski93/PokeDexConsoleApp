using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex_Console_App
{
    internal class PokemonGeneration
    {
        public int Id { get; set; }
        public string RegionName { get; set; }
        public List<Pokemon> PokemonGenerationList { get; set; }
    }
}
