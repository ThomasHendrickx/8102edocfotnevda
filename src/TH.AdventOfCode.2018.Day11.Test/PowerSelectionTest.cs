using Xunit;

namespace TH.AdventOfCode._2018.Day11.Test
{
    public class PowerSelectionTest
    {
        [Fact]
        public void Case1()
        {
            // Arrange
            int x = 33, y = 45, serial = 18;

            // Act
            var powerSelection = new PowerSelection(x, y, serial);

            // Assert
            Assert.Equal(29, powerSelection.Power);
        }
        
        [Fact]
        public void Case2()
        {
            // Arrange
            int x = 21, y = 61, serial = 42;

            // Act
            var powerSelection = new PowerSelection(x, y, serial);

            // Assert
            Assert.Equal(30, powerSelection.Power);
        }       
    }
}