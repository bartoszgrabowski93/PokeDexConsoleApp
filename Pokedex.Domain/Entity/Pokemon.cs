using Pokedex.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace Pokedex.Domain.Entity
{
    public class Pokemon : BaseEntity
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Primary Type")]
        public ElementType PrimaryType { get; set; }
        [XmlElement("Secoundary Type")]
        public ElementType SecoundaryType { get; set; }

        public Pokemon(int id, string name) {
            Id = id;
            Name = name;
        }
        public Pokemon()
        {            
        }
    }
}
