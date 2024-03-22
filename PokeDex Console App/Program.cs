using Pokedex.App;
using Pokedex.App.Abstract;
using Pokedex.App.Concrete;
using Pokedex.Domain.Entity;
using Pokedex.App.Managers;
using System.Linq;
using System.Xml.Serialization;



public class Program
{
    const string FILE_NAME=(@"C:\Users\Bartosz\Desktop\Temp\pokemon.csv");
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
            var fileService = new FileService();
            var allPokemon = new List<Pokemon>();
            // allPokemon = fileService.LoadXmlFile(FILE_NAME);            
            bool append = true;

            var userChoice = Console.ReadKey();
            switch (userChoice.KeyChar)
            {

                case '1':
                    Pokemon newPokemon = pokemonManager.AddNewPokemonView();
                    pokemonService.AddNewPokemon(newPokemon);
                    break;
                case '2':
                    var removePokemonId = pokemonManager.RemovePokemonByIdView();
                    pokemonService.RemovePokemon(removePokemonId);
                    break;
                case '3':               
                    pokemonService.ShowAllPokemon();
                    break;
                case '4':
                    var pokemonToEditId = pokemonManager.EditPokemonView(allPokemon);
                    pokemonService.EditPokemon(pokemonToEditId);
                    break;
                case '5':                    
                    fileService.SaveToXMLFile(FILE_NAME, allPokemon, "Pokemon", append);
                    break;
                default:
                    Console.WriteLine("Unnkown command. Please select one of the following numbers: ");
                    break;
            }
        }

       
    }
}