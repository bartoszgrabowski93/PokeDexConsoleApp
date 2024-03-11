using Pokedex.App.Common;
using Pokedex.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.App.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {
        public MenuActionService()
        {
            Initialize();
        }


        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Items)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;

        }

        private void Initialize()
        {
            AddItem(new MenuAction(1, "Add new pokemon", "Main"));
            AddItem(new MenuAction(2, "Remove pokemon", "Main"));
            AddItem(new MenuAction(3, "Show all pokemons", "Main"));
            AddItem(new MenuAction(4, "Edit pokemon", "Main"));
            AddItem(new MenuAction(5, "Show type menu", "Main"));


            AddItem(new MenuAction(1, "Add new type", "TypeMenu"));
            AddItem(new MenuAction(2, "Remove type", "TypeMenu"));
            AddItem(new MenuAction(3, "Add types to a pokemon", "TypeMenu"));
            AddItem(new MenuAction(4, "Remove pokemon types", "TypeMenu"));
            AddItem(new MenuAction(5, "Edit pokemon types", "TypeMenu"));
        }

    }
}
