using Xunit;

namespace TH.AdventOfCode._2018.Day2.Part1.Test
{
    public class BoxIdTests
    {
        [Fact]
        public void Case1()
        {
            // Arrange
            var id = "abcdef";
            
            // Act
            var boxId = new BoxId(id);

            // Assert
            
            Assert.Empty(boxId.Multiple);
        }

        [Fact]
        public void Case2()
        {
            // Arrange
            var id = "bababc";

            // Act
            var boxId = new BoxId(id);

            // Assert
            Assert.Equal(2, boxId.Multiple.Count);
            Assert.Contains(2, boxId.Multiple);
            Assert.Contains(3, boxId.Multiple);
        }

        [Fact]
        public void Case3()
        {
            // Arrange
            var id = "abbcde";

            // Act
            var boxId = new BoxId(id);

            // Assert
            Assert.Single(boxId.Multiple);
            Assert.Contains(2, boxId.Multiple);
        }

        [Fact]
        public void Case4()
        {
            // Arrange
            var id = "abcccd";

            // Act
            var boxId = new BoxId(id);

            // Assert
            Assert.Single(boxId.Multiple);
            Assert.Contains(3, boxId.Multiple);
        }

        [Fact]
        public void Case5()
        {
            // Arrange
            var id = "aabcdd";

            // Act
            var boxId = new BoxId(id);

            // Assert
            Assert.Single(boxId.Multiple);
            Assert.Contains(2, boxId.Multiple);
        }

        [Fact]
        public void Case6()
        {
            // Arrange
            var id = "abdcee";

            // Act
            var boxId = new BoxId(id);

            // Assert
            Assert.Single(boxId.Multiple);
            Assert.Contains(2, boxId.Multiple);
        }

        [Fact]
        public void Case7()
        {
            // Arrange
            var id = "ababab";

            // Act
            var boxId = new BoxId(id);

            // Assert
            Assert.Single(boxId.Multiple);
            Assert.Contains(3, boxId.Multiple);
        }
    }
}