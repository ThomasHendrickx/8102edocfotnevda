using System.Linq;
using TH.AdventOfCode._2018.Day12;
using Xunit;

namespace Th.AdventOfCode._2018.Day12.Test
{
    public class LifeCycleTest
    {
        [Fact]
        public void Case()
        {
            // Arrange
            var initialState = "#..#.#..##......###...###";
            var combinations = "...## => #,..#.. => #,.#... => #,.#.#. => #,.#.## => #,.##.. => #,.#### => #,#.#.# => #,#.### => #,##.#. => #,##.## => #,###.. => #,###.# => #,####. => #"
                .Split(',')
                .Where(c => c.Last() == '#')
                .Select(c => c.Substring(0, 5));
            var lifecyclePotRow = new LifeCyclePotrow(initialState, combinations);
            
            // Act
            lifecyclePotRow.MoveGenerationsForward(20);

            // Assert
            Assert.Equal("..#....##....#####...#######....#.#..##.", lifecyclePotRow.CurrentState);
            Assert.Equal(325, lifecyclePotRow.CurrentSumOfPlantContainingPots);
        }
    }
}