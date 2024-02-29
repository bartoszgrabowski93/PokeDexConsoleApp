using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex_Console_App
{
    internal class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PokemonType PrimaryType { get; set; }
        public PokemonType SecoundaryType { get; set; }

    }
}
