using Xunit;

namespace TH.AdventOfCode._2018.Day5.Part1.Test
{
    public class ExampleCases
    {
        [Fact]
        public void Case1()
        {
            // Arrange
            var polymerSequence = "aA";
            var polymer = new Polymer(polymerSequence);

            // Act
            polymer.React();

            // Assert
            Assert.Empty(polymer.Sequence);
        }
        
        
        [Fact]
        public void Case2()
        {
            // Arrange
            var polymerSequence = "abBA";
            var polymer = new Polymer(polymerSequence);

            // Act
            polymer.React();

            // Assert
            Assert.Empty(polymer.Sequence);
        }
               
        [Fact]
        public void Case3()
        {
            // Arrange
            var polymerSequence = "abAB";
            var polymer = new Polymer(polymerSequence);

            // Act
            polymer.React();

            // Assert
            Assert.Equal(polymerSequence, polymer.Sequence);
        }        
        
        [Fact]
        public void Case4()
        {
            // Arrange
            var polymerSequence = "aabAAB";
            var polymer = new Polymer(polymerSequence);

            // Act
            polymer.React();

            // Assert
            Assert.Equal(polymerSequence, polymer.Sequence);
        }
                
        [Fact]
        public void Case5()
        {
            // Arrange
            var polymerSequence = "dabAcCaCBAcCcaDA";
            var polymer = new Polymer(polymerSequence);

            // Act
            polymer.React();

            // Assert
            Assert.Equal("dabCBAcaDA", polymer.Sequence);
        }
    }
}