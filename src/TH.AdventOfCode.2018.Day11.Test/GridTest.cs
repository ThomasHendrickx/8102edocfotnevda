using Xunit;

namespace TH.AdventOfCode._2018.Day11.Test
{
    public class GridTest
    {
        [Fact]
        public void Case1()
        {
            // Arrange
            var serial = 18;
            var grid = new Grid(serial, 3);
            
            // Act
            var highest = grid.HightestPowerSelection;

            // Assert
            Assert.Equal(33, highest.X);
            Assert.Equal(45, highest.Y);
            Assert.Equal(29, highest.Power);
        }
        
        [Fact]
        public void Case2()
        {
            // Arrange
            var serial = 42;
            var grid = new Grid(serial, 3);
            
            // Act
            var highest = grid.HightestPowerSelection;

            // Assert
            Assert.Equal(21, highest.X);
            Assert.Equal(61, highest.Y);
            Assert.Equal(30, highest.Power);
        }
    }
}