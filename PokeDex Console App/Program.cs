
/*
  * 2d. Wyszukiwanie pokemonów według podanego filtra
  
 * 2a1. Wprowadź numer pokemona, nazwę
 * 2a1a. Sprawdź czy numer danego pokemona występuje już w bazie danych. Jeśli tak, wyświetl informacje o tym pokemonie. Zapytaj o jedną z 3 akcji: anulować wpisywanie, usunąć istniejącego pokemona, nadać istniejącemu pokemonowi inny numer.
 * 2a2a. Sprawdzić czy nazwa danego pokemona występuje już w istniejącej bazie. Jeśli tak, powtórz krok 2a1a.
 * 2a2. Wybierz typ podstawowy
 * 2a3. Zdecyduj czy pokemon posiada podtyp (drugi typ), Jeśli tak wyświetl ponownie listę typów
 * 2a4. Jeżeli został podany drugi typ, sprawdź czy typ ten nie jest ten sam co typ pierwszy, jeśli tak poinformuj użytkownika o tym.
 * 2a5. Zapytać użytkownika czy dany pokemon posiada ewolucję. Jeśli tak podać numer tej ewolucji / nazwę.
 * 
 */
using PokeDex_Console_App;

MenuActionService actionService = new MenuActionService();
actionService = Initialize(actionService);
var pokemonService = new PokemonService();
Console.WriteLine("Hello!");
Console.WriteLine("Wellcome to the PokedexApp.");
Console.WriteLine("What would u like to do:");
while (true) { 
var mainMenu = actionService.GetMenuActionsByMenuName("Main");
for (int i = 0; i < mainMenu.Count; i++)
{
    Console.WriteLine($"{mainMenu[i].Id}.{mainMenu[i].Name}");
}


var userChoice = Console.ReadKey();
switch (userChoice.KeyChar)
{
    case '1':
        int newPokemonNumber = pokemonService.AddNewPokemonView();
        pokemonService.AddNewPokemon(newPokemonNumber);
        break;
    case '2':
        var removePokemonId = pokemonService.RemovePokemonView();
        pokemonService.RemovePokemon(removePokemonId);
        break;
    case '3':
        var allPokemon = new List<Pokemon>();
        allPokemon = pokemonService.GetAllPokemon();
        pokemonService.ShowAllPokemon(allPokemon);
        break;
    case '4':
        var pokemonToEditId = pokemonService.EditPokemonView();
        pokemonService.EditPokemon(pokemonToEditId);            
        break;
    case '5':

        break;
    default:
        Console.WriteLine("Unnkown command. Please select one of the following numbers: ");          
            break;
}
}



static MenuActionService Initialize(MenuActionService actionService)
{
    actionService.AddNewAction(1, "Add new pokemon", "Main");
    actionService.AddNewAction(2, "Remove pokemon", "Main");
    actionService.AddNewAction(3, "Show all pokemons", "Main");
    actionService.AddNewAction(4, "Edit pokemon", "Main");
    actionService.AddNewAction(5, "Show type menu", "Main");
    

    actionService.AddNewAction(1, "Add new type", "TypeMenu");
    actionService.AddNewAction(2, "Remove type", "TypeMenu");
    actionService.AddNewAction(3, "Add types to a pokemon", "TypeMenu");
    actionService.AddNewAction(4, "Remove pokemon types", "TypeMenu");
    actionService.AddNewAction(5, "Edit pokemon types", "TypeMenu");
    

    return actionService;
}

