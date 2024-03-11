using Pokedex.App;
using Pokedex.App.Abstract;
using Pokedex.App.Concrete;
using Pokedex.Domain.Entity;
using Pokedex.App.Managers;


public class Program
{
    private static void Main(string[] args)
    {
        MenuActionService actionService = new MenuActionService();
        PokemonManager pokemonManager = new PokemonManager(actionService);
        PokemonService pokemonService = new PokemonService();

        Console.WriteLine("Hello!");
        Console.WriteLine("Wellcome to the PokedexApp.");
       
        while (true)
        {
            Console.WriteLine("What would u like to do:");
            var mainMenu = actionService.GetMenuActionsByMenuName("Main");
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}.{mainMenu[i].Name}");
            }

            var allPokemon = new List<Pokemon>();
            allPokemon = pokemonService.GetAllPokemon();

            var userChoice = Console.ReadKey();
            switch (userChoice.KeyChar)
            {

                case '1':
                    Pokemon newPokemon = pokemonManager.AddNewPokemonView();
                    pokemonService.AddNewPokemon(newPokemon);
                    break;
                case '2':
                    var removePokemonId = pokemonManager.RemovePokemonView();
                    pokemonService.RemovePokemon(removePokemonId);
                    break;
                case '3':               
                    pokemonService.ShowAllPokemon(allPokemon);
                    break;
                case '4':
                    var pokemonToEditId = pokemonManager.EditPokemonView(allPokemon);
                    pokemonService.EditPokemon(pokemonToEditId);
                    break;
                case '5':

                    break;
                default:
                    Console.WriteLine("Unnkown command. Please select one of the following numbers: ");
                    break;
            }
        }

       
    }
}