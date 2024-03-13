using Pokedex.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Pokedex.Domain.Entity
{
    public class Pokemon : BaseEntity
    {
        public string Name { get; set; }
        public Type PrimaryType { get; set; }
        public Type SecoundaryType { get; set; }

        public Pokemon(int id, string name) {
            Id = id;
            Name = name;
        }
        public Pokemon()
        {            
        }
    }
}
