using FluentAssertions;
using Moq;
using Pokedex.App.Abstract;
using Pokedex.App.Concrete;
using Pokedex.App.Managers;
using Pokedex.Domain.Entity;
namespace Pokedex.Test
{
    public class UnitTest1
    {
        [Fact]
        public void AddNewPokemonViewTest()
        {
            //Arrange
            Pokemon pokemon = new Pokemon(1, "Bulbasaur");
            var mock = new Mock<IService<Pokemon>>();
            mock.Setup(m => m.GetItemById(1)).Returns(pokemon);
            mock.Setup(m => m.RemoveItem(It.IsAny<Pokemon>()));
            var manager = new PokemonManager();
            //Act            
            manager.RemovePokemonByIdView();
            //Assert
            mock.Verify( m => m.RemoveItem(pokemon));

        }
        [Fact]
        public void BasicTest()
        {
            //Arrange
            int a = 3;
            int b = 4;
            //Act            
            int result = a + b;
            //Assert
            result.Should().Be(7);

        }
    }
}