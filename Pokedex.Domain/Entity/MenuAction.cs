using Pokedex.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pokedex.Domain.Entity
{
    public class MenuAction : BaseEntity
    {
        [XmlIgnore]
        public string Name { get; set; }
        [XmlIgnore]
        public string MenuName { get; set; }

        public MenuAction(int id, string name, string menuName)
        {
            Id = id;
            Name = name;
            MenuName = menuName;
        }
        public MenuAction()
        {

        }
    }
}
