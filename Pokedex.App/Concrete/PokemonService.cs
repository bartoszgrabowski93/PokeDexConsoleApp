using Pokedex.App.Common;
using Pokedex.Domain;
using Pokedex.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.App.Concrete
{
    public class PokemonService : BaseService<Pokemon>
    {
        public List<Pokemon> Pokemons { get; set; }

        public PokemonService() 
        {
            Pokemons = new List<Pokemon>();
        }
        
        public void AddNewPokemon(Pokemon pokemon) {
            Pokemons.Add(pokemon);
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

        public void ShowAllPokemon()
        {            
            foreach (var pokemon in Pokemons)
            {
                Console.WriteLine($"Number:{pokemon.Id}, Name: {pokemon.Name}"); ;
            }            
        }

       

        public void EditPokemon(Pokemon pokemonAcquiredData)
        {         
            Pokemon pokemonNewData = new Pokemon();
            pokemonNewData = pokemonAcquiredData;          
            var pokemonToRemove = new Pokemon();
            foreach (var pokemon in Pokemons)
            {
                if (pokemon.Id == pokemonNewData.Id)
                {
                    pokemonToRemove = pokemon;
                }
            }
            Pokemons.Remove(pokemonToRemove);            
            Pokemons.Add(pokemonNewData);
        }

        public Pokemon GetPokemonById(int id)
        {
            var result = new Pokemon();
            foreach(var pokemon in Pokemons)
            {
                if (pokemon.Id == id)
                {
                    result = pokemon;
                }
            }
            return result;
        }

        public Pokemon GetPokemonByName(string name)
        {
            var result = new Pokemon();
            foreach (var pokemon in Pokemons)
            {
                if (pokemon.Name == name)
                {
                    result = pokemon;
                }
            }
            return result;
        }

    }
}
