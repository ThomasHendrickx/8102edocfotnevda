using System.Collections.Generic;
using Xunit;

namespace TH.AdventOfCode._2018.Day2.Test
{
    public class CheckSumTests
    {
        [Fact]
        public void Case()
        {
            // Arrange
            var boxIds = new List<BoxId>
            {
                new BoxId("abcdef"),
                new BoxId("bababc"),
                new BoxId("abbcde"),
                new BoxId("abcccd"),
                new BoxId("aabcdd"),
                new BoxId("abcdee"),
                new BoxId("ababab")
            };

            // Act
            var checkSum = new CheckSum(boxIds);
            
            // Assert
            Assert.Equal(12, checkSum.Result);
        }
    }
}