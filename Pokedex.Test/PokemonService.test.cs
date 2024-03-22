using FluentAssertions;
using Moq;
using Pokedex.App.Abstract;
using Pokedex.App.Concrete;
using Pokedex.App.Common;
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

            //Act            

            //Assert
           

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