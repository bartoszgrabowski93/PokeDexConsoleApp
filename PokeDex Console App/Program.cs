using Pokedex.App;
using Pokedex.App.Abstract;
using Pokedex.App.Concrete;
using Pokedex.Domain.Entity;
using Pokedex.App.Managers;
using System.Linq;
using System.Xml.Serialization;



public class Program
{
    const string FILE_NAME=(@"D:\Temp\pokemon.xml");
    private static void Main(string[] args)
    {
          
        MenuActionService actionService = new MenuActionService();
        PokemonManager pokemonManager = new PokemonManager(actionService);
        PokemonService pokemonService = new PokemonService();

        var fileService = new FileService();
        var allPokemon = new List<Pokemon>();
        XmlRootAttribute root = new XmlRootAttribute();
        root.ElementName = "Pokemon";
        root.IsNullable = true;
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Pokemon>), root);
        string xml = File.ReadAllText(FILE_NAME);
        StringReader stringReader = new StringReader(xml);

        var xmlPokemons = (List<Pokemon>)xmlSerializer.Deserialize(stringReader);
        pokemonService.AddPokemonList(xmlPokemons);

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
                    allPokemon = pokemonService.GetAllPokemon();
                    fileService.SaveToXMLFile(FILE_NAME, allPokemon, "Pokemon", append);
                    break;
                default:
                    Console.WriteLine("Unnkown command. Please select one of the following numbers: ");
                    break;
            }
        }

       
    }
}