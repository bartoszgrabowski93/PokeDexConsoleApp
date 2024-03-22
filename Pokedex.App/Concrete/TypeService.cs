using Pokedex.App.Common;
using Pokedex.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.App.Concrete
{
    public class TypeService : BaseService<ElementType>
    {
        private List<ElementType> eleTypes;
        public TypeService() 
        {
            eleTypes = new List<ElementType>();
        }

        public List<ElementType> GetAllTypesList()
        {
            return eleTypes;
        }

        public void AddNewType(int id, string name) 
        {

        }
    }
}
