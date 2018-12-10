using System.Linq;
using Xunit;

namespace TH.AdventOfCode._2018.Day6.Part1.Test
{
    public class ExampleCases
    {
        [Fact]
        public void Case1()
        {   
            // Arrange
            var destinations = "1, 1;1, 6;8, 3;3, 4;5, 5;8, 9".Split(';').Select(coor => new Destination(coor));
            
            // Act
            var map = new Map(destinations.ToList());
            
            // Assert
            Assert.Equal(17, map.SizeOf(map.DestinationWithMostPoints));
        }
    }
}