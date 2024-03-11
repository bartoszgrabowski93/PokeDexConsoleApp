using Pokedex.App.Concrete;
using Pokedex.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.App.Managers
{
    public class PokemonManager
    {   
        private readonly MenuActionService _actionService;
        private PokemonService _pokemonService;
        private List<Pokemon> pokemons;
        public PokemonManager(MenuActionService actionService)
        {
            _pokemonService = new PokemonService();
            _actionService = actionService;
        }
        public Pokemon AddNewPokemonView()
        {
            Pokemon pokemon = new Pokemon();
            Console.WriteLine("Please insert pokemon number: ");
            string newPokemonNumberString = Console.ReadLine();
            int newPokemonNumber = 0;
            Int32.TryParse(newPokemonNumberString, out newPokemonNumber);
            Console.WriteLine("Please insert pokemon name: ");
            string newPokemonName = Console.ReadLine();
            pokemon.Id = newPokemonNumber;
            pokemon.Name = newPokemonName;
            return pokemon;
        }

        public int RemovePokemonView()
        {
            Console.WriteLine("Type pokemon id you would like to remove: ");
            var userChoice = Console.ReadLine();
            Int32.TryParse(userChoice, out int id);
            return id;
        }

        public Pokemon EditPokemonView(List<Pokemon> allPokemon)
        {
            pokemons = allPokemon;
            Pokemon pokemonNewData = new Pokemon();
            Console.WriteLine("Insert pokemon's number you want to edit:");
            var idToEdit = Console.ReadLine();
            int pokemonToEditNumber;
            Int32.TryParse(idToEdit, out pokemonToEditNumber);
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i].Id == pokemonToEditNumber)
                {
                    Console.WriteLine($"You are editing details of {pokemons[i].Name}, pokemon number: {pokemons[i].Id}");
                    break;
                }
            }
            Console.WriteLine("Insert pokemon's new name:");
            var pokemonNewName = Console.ReadLine();
            pokemonNewData.Id = pokemonToEditNumber;
            pokemonNewData.Name = pokemonNewName;
            return pokemonNewData;

        }

    }
}
