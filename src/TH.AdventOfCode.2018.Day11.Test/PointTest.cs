using Xunit;

namespace TH.AdventOfCode._2018.Day11.Test
{
    public class PointTest
    {
        [Fact]
        public void Case1()
        {
            // Arrange
            int serial = 57, x = 122, y = 79;

            // Act 
            var point = new Point(x, y, serial);

            // Assert
            Assert.Equal(-5, point.PowerLevel);
        }
        
        [Fact]
        public void Case2()
        {
            // Arrange
            int serial = 39, x = 217, y = 196;

            // Act 
            var point = new Point(x, y, serial);

            // Assert
            Assert.Equal(0, point.PowerLevel);
        }
        
        [Fact]
        public void Case3()
        {
            // Arrange
            int serial = 71, x = 101, y = 153;

            // Act 
            var point = new Point(x, y, serial);

            // Assert
            Assert.Equal(4, point.PowerLevel);
        }
    }
}