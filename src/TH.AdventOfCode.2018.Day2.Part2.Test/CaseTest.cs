using System.Linq;
using Xunit;

namespace TH.AdventOfCode._2018.Day2.Part2.Test
{
    public class CaseTest
    {
        [Fact]
        public void Should_ReturnCorrectExampleCaseSolution_When_GivenExampleInput()
        {
            var x = "abcde,fghij,klmno,pqrst,fguij,axcye,wvxyz".Split(',');           
            var ids = x.Select(y => new BoxId(y)).ToList();
            var differenceList = DifferenceList.FromBoxIds(ids);
            Assert.Equal("fgij", differenceList.SmallestId);
        }
    }
}