using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeMachine.Tests
{
    public class CupTest
    {

        [Fact]
        public void HasCups_ShouldReturnTrue_WhenEnoughCupsExist()
        {
            //Arrange
            var smallCup = new Cup(2, 10);

            //Act
            bool result = smallCup.HasCups(1);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void HasCups_ShouldReturnFals_WhenEnougCupsNoExist()
        {
            //Arrange
            var smallCup = new Cup(2, 10);

            //Act
            bool result = smallCup.HasCups(3);

            //Assert
            Assert.False(result);
        }


    }
}
