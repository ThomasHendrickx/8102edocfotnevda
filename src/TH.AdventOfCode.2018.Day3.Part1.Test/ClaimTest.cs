using System;
using System.Linq;
using Xunit;

namespace TH.AdventOfCode._2018.Day3.Part1.Test
{
    public class ClaimTest
    {
        [Fact]
        public void ExampleCase1()
        {
            // Arrange
            var c = "#1 @ 1,3: 4x4";

            // Act
            var claim = new Claim(c);
            
            // Assert
            Assert.Equal("1", claim.Id);
            Assert.Equal(4*4, claim.Claims.Count());
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 2 && coordinate.Y == 4);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 2 && coordinate.Y == 5);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 2 && coordinate.Y == 6);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 2 && coordinate.Y == 7);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 3 && coordinate.Y == 4);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 3 && coordinate.Y == 5);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 3 && coordinate.Y == 6);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 3 && coordinate.Y == 7);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 4 && coordinate.Y == 4);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 4 && coordinate.Y == 5);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 4 && coordinate.Y == 6);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 4 && coordinate.Y == 7);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 5 && coordinate.Y == 4);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 5 && coordinate.Y == 5);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 5 && coordinate.Y == 6);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 5 && coordinate.Y == 7);
        }
        
        [Fact]
        public void ExampleCase2()
        {
            // Arrange
            var c = "#2 @ 3,1: 4x4";

            // Act
            var claim = new Claim(c);
            
            // Assert
            Assert.Equal("2", claim.Id);
            Assert.Equal(4*4, claim.Claims.Count());
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 4 && coordinate.Y == 2);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 4 && coordinate.Y == 3);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 4 && coordinate.Y == 4);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 4 && coordinate.Y == 5);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 5 && coordinate.Y == 2);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 5 && coordinate.Y == 3);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 5 && coordinate.Y == 4);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 5 && coordinate.Y == 5);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 6 && coordinate.Y == 2);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 6 && coordinate.Y == 3);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 6 && coordinate.Y == 4);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 6 && coordinate.Y == 5);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 7 && coordinate.Y == 2);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 7 && coordinate.Y == 3);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 7 && coordinate.Y == 4);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 7 && coordinate.Y == 5);
        }
        
        [Fact]
        public void ExampleCase3()
        {
            // Arrange
            var c = "#3 @ 5,5: 2x2";

            // Act
            var claim = new Claim(c);
            
            // Assert
            Assert.Equal("3", claim.Id);
            Assert.Equal(2*2, claim.Claims.Count());
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 6 && coordinate.Y == 6);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 6 && coordinate.Y == 7);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 7 && coordinate.Y == 6);
            Assert.Contains(claim.Claims, coordinate => coordinate.X == 7 && coordinate.Y == 7);
        }
    }
}