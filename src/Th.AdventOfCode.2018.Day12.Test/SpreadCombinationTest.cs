using System.Collections.Generic;
using TH.AdventOfCode._2018.Day12;
using Xunit;

namespace Th.AdventOfCode._2018.Day12.Test
{
    public class SpreadCombinationTest
    {
        [Theory, MemberData(nameof(PotTestData))]
        public void Case1(bool first, bool second, bool third, bool fourth, bool fifth)
        {
            // Arrange
            var combination = "...##";
            var pots = new LinkedList<Pot>();
            pots.AddFirst(new Pot {HasPlant = fifth});
            pots.AddFirst(new Pot {HasPlant = fourth});
            pots.AddFirst(new Pot {HasPlant = third});
            pots.AddFirst(new Pot {HasPlant = second});
            pots.AddFirst(new Pot {HasPlant = first});

            // Act
            var spreadCombination = new SpreadCombination(combination);

            // Assert
            if (!first && !second && !third && fourth && fifth)
            {
                Assert.True(spreadCombination.CanSpread(pots.First.Next.Next));
            }
            else
            {
                Assert.False(spreadCombination.CanSpread(pots.First.Next.Next));
            }
        }

        private static List<object[]> _potTestData;
        public static IEnumerable<object[]> PotTestData = _potTestData ?? (_potTestData = GetPotTestData());
        private static List<object[]> GetPotTestData()
        {
            var combinations = new List<object[]>();
            for (var i = 0; i < 2; i++)
            {
                var first = i == 0;
                for (var j = 0; j < 2; j++)
                {
                    var second = j == 0;
                    for (var k = 0; k < 2; k++)
                    {
                        var third = k == 0;
                        for (var l = 0; l < 2; l++)
                        {
                            var fourth = l == 0;
                            for (var m = 0; m < 2; m++)
                            {
                                var fifth = m == 0;
                                combinations.Add(new object[]
                                {
                                    first, second, third, fourth, fifth
                                });
                            }
                        }
                    }
                }
            }

            return combinations;
        }
    }
}