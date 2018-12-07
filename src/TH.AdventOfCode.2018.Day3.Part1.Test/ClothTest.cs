using System.Linq;
using Xunit;

namespace TH.AdventOfCode._2018.Day3.Part1.Test
{
    public class ClothTest
    {
        [Fact]
        public void Case()
        {
            // Arrange
            var cs = new[]
            {
                "#1 @ 1,3: 4x4",
                "#2 @ 3,1: 4x4",
                "#3 @ 5,5: 2x2"
            };
            var claims = cs.Select(c => new Claim(c));
            var cloth = new Cloth();

            // Act         
            foreach (var claim in claims)
            {
                cloth.AddClaim(claim);
            }

            // Assert
            Assert.Equal(4, cloth.NumberOfCellsWithMultipleClaims());
        }
    }
}