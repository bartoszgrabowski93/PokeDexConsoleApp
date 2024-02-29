using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex_Console_App
{
    internal class PokemonService
    {
        public List<Pokemon> Pokemons { get; set; }

        public PokemonService() 
        {
            Pokemons = new List<Pokemon>();
        }

        public int AddNewPokemonView()
        {
            Console.WriteLine("Please insert pokemon number: ");
            string newPokemonNumberString = Console.ReadLine();
            int newPokemonNumber = 0;
            Int32.TryParse(newPokemonNumberString, out newPokemonNumber);
            return newPokemonNumber;
        }
                
        public void AddNewPokemon(int id) {
            Pokemon newPokemon = new Pokemon();            
            Console.WriteLine("Please insert pokemon name: ");
            string newPokemonName = Console.ReadLine();
            newPokemon.Id = id;
            newPokemon.Name = newPokemonName;
            Pokemons.Add(newPokemon);
        }

        public int RemovePokemonView()
        {
            Console.WriteLine("Type pokemon id you would like to remove: ");
            var userChoice = Console.ReadLine();
            Int32.TryParse(userChoice, out int id);
           return id;
        }

        public void RemovePokemon(int id)
        {
            Pokemon pokemonToRemove = new Pokemon();
            foreach (var pokemon in Pokemons)
            {
                if (pokemon.Id == id)
                {
                    pokemonToRemove = pokemon;
                    break;
                }
            }
            Pokemons.Remove(pokemonToRemove);         

        }

        public List<Pokemon> GetAllPokemon()
        {
            var result = new List<Pokemon>();
            foreach (var pokemon in Pokemons)
            {
                result.Add(pokemon);
            }
            return result;
        }

        public void ShowAllPokemon(List<Pokemon> pokemons)
        {
            var result = new List<Pokemon>();
            result = pokemons;
            foreach (var pokemon in result)
            {
                Console.WriteLine($"Number:{pokemon.Id}, Name: {pokemon.Name}"); ;
            }            
        }

        public int EditPokemonView()
        {
            Console.WriteLine("Insert pokemon's number you want to edit:");
            var idToEdit = Console.ReadLine();
            int pokemonToEditNumber = 0;
            Int32.TryParse(idToEdit, out pokemonToEditNumber);
            return pokemonToEditNumber;
        }

        public void EditPokemon(int id)
        {
            int idToEdit = id;
            foreach ( var pokemon in Pokemons)
            {
                if (pokemon.Id == id)
                {
                    Console.WriteLine($"You are editing details of {pokemon.Name}, pokemon number: {pokemon.Id}" );
                    Pokemons.Remove(pokemon);
                    Pokemon editedPokemon = new Pokemon();
                    editedPokemon.Id = id;
                    Console.WriteLine("Write name of edited pokemon: ");
                    string editedPokemonNewName = Console.ReadLine();
                    editedPokemon.Name = editedPokemonNewName;
                    Pokemons.Add(editedPokemon);
                    break;
                }
            }            
            
        }

       
    }
}
